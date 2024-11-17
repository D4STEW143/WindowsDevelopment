#define _CRT_SECURE_NO_WARNINGS
#include <Windows.h>
#include "resource.h"
#include <cstdio>

CONST CHAR* g_VALUES[] = { "This", "is", "my", "first", "List", "Box" };

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
BOOL CALLBACK DlgProcAddItem(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
BOOL CALLBACK DlgProcEditItem(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, (DLGPROC)DlgProc, 0);
	return 0;
}

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_INITDIALOG:
	{
		HICON hIcon = LoadIcon(GetModuleHandle(NULL), MAKEINTRESOURCE(IDI_ICON1));
		SendMessage(hwnd, WM_SETICON, 0, (LPARAM)hIcon);

		HWND hListBox = GetDlgItem(hwnd, IDC_LIST);
		for (int i = 0; i < sizeof(g_VALUES) / sizeof(g_VALUES[0]); i++)
			SendMessage(hListBox, LB_ADDSTRING, 0, (LPARAM)g_VALUES[i]);
		SetFocus(hListBox);
	}
	break;



	case WM_COMMAND:
		/*if (HIWORD(wParam) == LBN_DBLCLK)
		{
			DialogBoxParam(GetModuleHandle(NULL), MAKEINTRESOURCE(IDD_DIALOG_EDIT_ITEM), hwnd, (DLGPROC)DlgProcEditItem, 0);
		}
		if (LOWORD(wParam) == VK_DELETE)
		{
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_DELETE), (LPARAM)GetDlgItem(hwnd, IDC_LIST));
		}*/

		switch (LOWORD(wParam))
		{
		case IDC_LIST:
		{
			if (HIWORD(wParam) == LBN_DBLCLK)//LBN-ListBoxNotification
			{
				DialogBoxParam(GetModuleHandle(NULL), MAKEINTRESOURCE(IDD_DIALOG_EDIT_ITEM), hwnd, (DLGPROC)DlgProcEditItem, 0);
			}
		}
		break;
		case IDC_BUTTON_ADD:
			DialogBoxParam(GetModuleHandle(NULL), MAKEINTRESOURCE(IDD_DIALOG_ADD_ITEM), hwnd, (DLGPROC)DlgProcAddItem, 0);
			break;
		case IDC_BUTTON_DELETE:
		{
			HWND hListBox = GetDlgItem(hwnd, IDC_LIST);
			if (SendMessage(hListBox, LB_GETCURSEL, 0, 0) != LB_ERR)
				SendMessage(hListBox, LB_DELETESTRING, SendMessage(hListBox, LB_GETCURSEL, 0, 0), 0);
			else
				SendMessage(hListBox, LB_DELETESTRING, SendMessage(hListBox, LB_GETCOUNT, 0, 0) - 1, 0);
		}
		break;
		case IDCANCEL:
			EndDialog(hwnd, 0);
			break;
		case IDOK:
		{
			HWND hListBox = GetDlgItem(hwnd, IDC_LIST);
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE];
			INT i = SendMessage(hListBox, LB_GETCURSEL, 0, 0);
			SendMessage(hListBox, LB_GETTEXT, i, (LPARAM)sz_buffer);

			CHAR sz_message[SIZE]{};
			sprintf(sz_message, "Вы выбрали эллемент №%i со значение \"%s\".", i, sz_buffer);
			MessageBox(hwnd, sz_message, "Info", MB_OK | MB_ICONINFORMATION);
		}

		}
		break;

	case WM_VKEYTOITEM:
		switch (LOWORD(wParam))
		{
		case VK_DELETE:
			//SendMessage(hwnd, WM_COMMAND, MAKEWPARAM(IDC_BUTTON_DELETE, BN_CLICKED), (LPARAM)GetDlgItem(hwnd, IDC_BUTTON_DELETE));
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_DELETE), (LPARAM)GetDlgItem(hwnd, IDC_LIST));
			break;
		case VK_RETURN:
			SendMessage(hwnd, WM_COMMAND, MAKEWPARAM(IDC_LIST, LBN_DBLCLK), (LPARAM)GetDlgItem(hwnd, IDC_LIST));
			break;
		}
		break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
		break;
	}
	return FALSE;
}


BOOL CALLBACK DlgProcAddItem(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_INITDIALOG:
	{
		HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_ADD_ITEM);
		SetFocus(hEdit);
	}
	break;
	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case IDOK:
		{
			HWND hParent = GetParent(hwnd);
			HWND hListBox = GetDlgItem(hParent, IDC_LIST);
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_ADD_ITEM);

			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, SIZE, (LPARAM)sz_buffer);

			//Проверка на копию
			if (SendMessage(hListBox, LB_FINDSTRINGEXACT, -1, (LPARAM)sz_buffer) == LB_ERR)
			{
				SendMessage(hListBox, LB_ADDSTRING, 0, (LPARAM)sz_buffer);
			}
			else
			{
				INT answer = MessageBox(hwnd, "Обнаруженно совпадение. Хотите ввести что-то другое?", "Error", MB_YESNO | MB_ICONWARNING);
				if (answer == IDYES) break;
			}
		}

		case IDCANCEL: EndDialog(hwnd, 0);
			break;
		}
		break;
	case WM_CLOSE: EndDialog(hwnd, 0); break;
	}
	return FALSE;
}

BOOL CALLBACK DlgProcEditItem(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_INITDIALOG:
	{
		//SendMessage(hwnd, WM_SETTEXT, 0, (LPARAM)"Изменить текст.");
		HWND hParent = GetParent(hwnd);
		HWND hListBox = GetDlgItem(hParent, IDC_LIST);
		HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_ADD_ITEM2);
		CONST INT SIZE = 256;
		CHAR sz_buffer[SIZE]{};
		SendMessage(hListBox, LB_GETTEXT, SendMessage(hListBox, LB_GETCURSEL, 0, 0), (LPARAM)sz_buffer);
		SendMessage(hEdit, WM_SETTEXT, NULL, (LPARAM)sz_buffer);
		SetFocus(hEdit);
		INT length = SendMessage(hEdit, WM_GETTEXTLENGTH, 0, 0);
		SendMessage(hEdit, EM_SETSEL, length, length); //выделяем текст в окне едит и каретка уходит в крайнее положение справа
		//SendMessage(hEdit, EM_REPLACESEL, 0, length);
	}
	break;

	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case IDOK:
		{
			HWND hParent = GetParent(hwnd);
			HWND hListBox = GetDlgItem(hParent, IDC_LIST);
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_ADD_ITEM2);

			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};

			SendMessage(hEdit, WM_GETTEXT, SIZE, (LPARAM)sz_buffer);

			if (SendMessage(hListBox, LB_FINDSTRINGEXACT, -1, (LPARAM)sz_buffer) == LB_ERR)
			{
				SendMessage(hListBox, LB_INSERTSTRING, SendMessage(hListBox, LB_GETCURSEL, 0, 0), (LPARAM)sz_buffer);
				SendMessage(hListBox, LB_DELETESTRING, SendMessage(hListBox, LB_GETCURSEL, 0, 0), 0);
			}
			else MessageBox(hwnd, "Обнаруженно совпадение.", "Error", MB_OK | MB_ICONWARNING);
		}

		case IDCANCEL: EndDialog(hwnd, 0); break;
		}
		break;
	case WM_CLOSE: EndDialog(hwnd, 0); break;
	}
	return FALSE;
}