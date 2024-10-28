#define _CRT_SECURE_NO_WARNINGS
#include <Windows.h>
#include <cstdio>
#include "resource.h"

CONST CHAR* initValues[]={ "This", "is", "my", "first", "List", "Box" };

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hInstPrev, LPSTR lpCmdLine, INT nCmdShow)
{
	DialogBox(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL,(DLGPROC)DlgProc, 0);
	return 0;
}

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_INITDIALOG: {
		HWND hList = GetDlgItem(hwnd, IDC_LIST1);
		for (int i = 0; i < sizeof(initValues) / sizeof(initValues[0]); i++) {
			SendMessage(hList, LB_ADDSTRING, 0, (LPARAM)initValues[i]);
		}
	}
		break;
	case WM_COMMAND:
		switch(LOWORD(wParam))
		{
		case IDOK:
		{
			HWND hList = GetDlgItem(hwnd, IDC_LIST1);
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};
			CHAR sz_message[SIZE]{};
			INT i = SendMessage(hList, LB_GETCURSEL, 0, 0);
			SendMessage(hList, LB_GETTEXT, i, (LPARAM)sz_buffer);
			sprintf(sz_message, "Вы выбрали пункт №%i со значением \"%s\".", i, sz_buffer);
			MessageBox(hwnd, sz_message, "Selected value", MB_OK | MB_ICONINFORMATION);
			break;
		}
			break;
		case IDCANCEL:EndDialog(hwnd, 0);break;
		}
		break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
		break;
	}
	return FALSE;
}