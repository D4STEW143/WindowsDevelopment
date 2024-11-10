#include<Windows.h>
#include"resource.h"

//#define MESSAGE_BOX

//#define MYVARIANT

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{

#ifdef MESSAGE_BOX
	MessageBox
	(
		NULL,
		"Hello WinAPI \nЭто окно сообщения!",
		"Question",
		MB_YESNOCANCEL | MB_ICONQUESTION | MB_HELP | MB_DEFBUTTON4 | MB_SYSTEMMODAL
	);
#endif // MESSAGE_BOX

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
		//HWND СopyButton = GetDlgItem(hwnd, IDC_BUTTON1);
	}
	break;
	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case IDOK: MessageBox(hwnd, "Была нажата кнопка ОК", "Info", MB_OK | MB_ICONINFORMATION); break;
		case IDCANCEL: EndDialog(hwnd, 0); break;
		case IDC_BUTTON_COPY: {
#ifdef MYVARIANT
			CHAR chBufferTmp[256]; //массив для получения строки с ввода
			UINT hEdit1 = GetDlgItemText(hwnd, IDC_EDIT1, (LPSTR)chBufferTmp, sizeof(chBufferTmp)); //получаем строку с первого edit control и даем ее в массив chBufferTmp
			CHAR* chBuffer = new CHAR[hEdit1 + 1];//создаем динамический массив равный количеству символов полученой строки + 1
			for (int i = 0; i < hEdit1; i++)
			{
				chBuffer[i] = chBufferTmp[i]; //переносим данные из массива для считывания в массив для показа
			}
			chBuffer[hEdit1] = '\0';//зануляем конец массива(без этого показывается ерунда в конце строки)
			BOOL hEdit2 = SetDlgItemText(hwnd, IDC_EDIT2, (LPSTR)chBuffer);//выводим массив во второй edit control
			delete[] chBuffer;//очищаем память 
			break;
#endif // MYVARIANT
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};

			HWND hEditLogin = GetDlgItem(hwnd, IDC_EDIT_LOGIN);
			HWND hEditPassword = GetDlgItem(hwnd, IDC_EDIT_PASSWORD);
			
			SendMessage(hEditLogin, WM_GETTEXT, SIZE, (LPARAM)sz_buffer); 
			SendMessage(hEditPassword, WM_SETTEXT, 0, (LPARAM)sz_buffer);

			break;
		}
		}
		break;
	case WM_CLOSE:
		EndDialog(hwnd, 0); break;
		break;
	}
	return FALSE;
}