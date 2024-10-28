#include<Windows.h>
#include"resource.h"

//#define MESSAGE_BOX

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
		case IDC_BUTTON1: {
			//HWND hEdit1 = GetDlgItem(hwnd, IDC_EDIT1);
			INT chText;
			CHAR* chBufferTmp[1024];
			UINT hEdit1 = GetDlgItemText(hwnd, IDC_EDIT1, (LPSTR)chBufferTmp, 1024);
			CHAR* chBuffer[sizeof(hEdit1)];
			for (int i = 0; i < sizeof(hEdit1); i++)
			{
				chBuffer[i] = chBufferTmp[i];
			}
			BOOL hEdit2 = SetDlgItemText(hwnd, IDC_EDIT2, (LPCSTR)chBuffer);
			//chText = SendMessage(hEdit1, EM_GETLINE, 0, (LPARAM)(LPSTR)chBuffer);
			//chBuffer[chText] =(LPTSTR)"\0";
			//MessageBox(hwnd, "Строка скопирована и будет вставлена во второе Edit-окно", "CopyInfo", MB_OK | MB_ICONINFORMATION);
			//MessageBox(hwnd, (LPTSTR)chBuffer, "CopyInfo", MB_OK | MB_ICONINFORMATION);

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