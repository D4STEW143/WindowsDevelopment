#define _CRT_SECURE_NO_WARNINGS
#include <Windows.h>
#include <cstdio>
#include "resource.h"

#define IDC_EDIT_DISPLAY		999

#define IDC_BUTTON_0			1000
#define IDC_BUTTON_1			1001
#define IDC_BUTTON_2			1002
#define IDC_BUTTON_3			1003
#define IDC_BUTTON_4			1004
#define IDC_BUTTON_5			1005
#define IDC_BUTTON_6			1006
#define IDC_BUTTON_7			1007
#define IDC_BUTTON_8			1008
#define IDC_BUTTON_9			1009
#define IDC_BUTTON_POINT		1010

#define IDC_BUTTON_PLUS			1011
#define IDC_BUTTON_MINUS		1012
#define IDC_BUTTON_ASTER		1013 //Multiple
#define IDC_BUTTON_SLASH		1014 //Devide

#define IDC_BUTTON_BSP			1015 //BackSpace
#define IDC_BUTTON_CLR			1016 //Clear
#define IDC_BUTTON_EQUAL		1017 

#define LOGIC

CONST CHAR g_sz_WINDOW_CLASS[] = "Calc_VPD_311";

CONST INT g_i_SCREEN_WIDTH = 400;
CONST INT g_i_SCREEN_HEIGHT = 22;

CONST INT g_i_BUTTON_SIZE = 50;
CONST INT g_i_INTERVAL = 5;		

CONST INT g_i_START_X = 10;
CONST INT g_i_START_Y = 10;
CONST INT g_i_BUTTON_START_X = g_i_START_X;
CONST INT g_i_BUTTON_START_Y = g_i_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL;

CONST INT sz_SIZE = 256;

INT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	//1.Registration class window
	WNDCLASSEX wClass;
	ZeroMemory(&wClass, sizeof(wClass));

	wClass.style = 0;
	wClass.cbSize = sizeof(wClass);
	wClass.cbClsExtra = 0;
	wClass.cbWndExtra = 0;

	wClass.hIcon = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_ICON1));
	wClass.hIconSm = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_ICON1));
	wClass.hCursor = LoadCursor(hInstance, MAKEINTRESOURCE(IDC_ARROW));
	wClass.hbrBackground = (HBRUSH)COLOR_WINDOW;

	wClass.hInstance = hInstance;
	wClass.lpszClassName = g_sz_WINDOW_CLASS;
	wClass.lpszMenuName = NULL;
	wClass.lpfnWndProc = (WNDPROC)WndProc;

	if (!RegisterClassEx(&wClass))
	{
		MessageBox(NULL, "Class registration failure", "Error", MB_OK | MB_ICONERROR);
		return 0;
	}

	//2.Window creation
	HWND hwnd = CreateWindowEx
	(
		NULL,
		g_sz_WINDOW_CLASS,
		g_sz_WINDOW_CLASS,
		WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT, CW_USEDEFAULT,
		CW_USEDEFAULT, CW_USEDEFAULT,
		NULL,
		NULL,
		hInstance,
		NULL
	);
	ShowWindow(hwnd, nCmdShow);
	UpdateWindow(hwnd);

	//3.
	MSG msg;
	while (GetMessage(&msg, NULL, 0, 0) > 0)
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}

	return msg.wParam;
}

INT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_CREATE:
	{
		HWND hEdit = CreateWindowEx
		(
			NULL, "Edit", "0",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_RIGHT,
			g_i_START_X, g_i_START_Y,
			g_i_SCREEN_WIDTH, g_i_SCREEN_HEIGHT,
			hwnd,
			(HMENU)IDC_EDIT_DISPLAY,
			GetModuleHandle(NULL), NULL
		);

		HWND hBut0 = CreateWindowEx
		(
			NULL, "Button", "0",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL + g_i_BUTTON_SIZE, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL * 3 + g_i_BUTTON_SIZE * 3,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_0,
			GetModuleHandle(NULL), NULL
		);

		HWND hBut1 = CreateWindowEx
		(
			NULL, "Button", "1",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL * 2 + g_i_BUTTON_SIZE * 2,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_1,
			GetModuleHandle(NULL), NULL
		);

		HWND hBut2 = CreateWindowEx
		(
			NULL, "Button", "2",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL + g_i_BUTTON_SIZE, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL * 2 + g_i_BUTTON_SIZE * 2,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_2,
			GetModuleHandle(NULL), NULL
		);

		HWND hBut3 = CreateWindowEx
		(
			NULL, "Button", "3",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL * 2 + g_i_BUTTON_SIZE * 2, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL * 2 + g_i_BUTTON_SIZE * 2,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_3,
			GetModuleHandle(NULL), NULL
		);

		HWND hBut4 = CreateWindowEx
		(
			NULL, "Button", "4",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL + g_i_BUTTON_SIZE,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_4,
			GetModuleHandle(NULL), NULL
		);

		HWND hBut5 = CreateWindowEx
		(
			NULL, "Button", "5",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL + g_i_BUTTON_SIZE, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL + g_i_BUTTON_SIZE,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_5,
			GetModuleHandle(NULL), NULL
		);

		HWND hBut6 = CreateWindowEx
		(
			NULL, "Button", "6",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL * 2 + g_i_BUTTON_SIZE * 2, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL + g_i_BUTTON_SIZE,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_6,
			GetModuleHandle(NULL), NULL
		);

		HWND hBut7 = CreateWindowEx
		(
			NULL, "Button", "7",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_7,
			GetModuleHandle(NULL), NULL
		);

		HWND hBut8 = CreateWindowEx
		(
			NULL, "Button", "8",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL + g_i_BUTTON_SIZE, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_8,
			GetModuleHandle(NULL), NULL
		);

		HWND hBut9 = CreateWindowEx
		(
			NULL, "Button", "9",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL * 2 + g_i_BUTTON_SIZE * 2, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_9,
			GetModuleHandle(NULL), NULL
		);

		HWND hButEqual = CreateWindowEx
		(
			NULL, "Button", "=",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL * 5 + g_i_BUTTON_SIZE * 5, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL * 2 + g_i_BUTTON_SIZE * 2,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE * 2 + g_i_INTERVAL,
			hwnd, (HMENU)IDC_BUTTON_EQUAL,
			GetModuleHandle(NULL), NULL
		);

		HWND hButDot = CreateWindowEx
		(
			NULL, "Button", ",",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL * 2 + g_i_BUTTON_SIZE * 2, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL * 3 + g_i_BUTTON_SIZE * 3,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_POINT,
			GetModuleHandle(NULL), NULL
		);

		HWND hButPlus = CreateWindowEx
		(
			NULL, "Button", "+",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL * 4 + g_i_BUTTON_SIZE * 4, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_PLUS,
			GetModuleHandle(NULL), NULL
		);

		HWND hButMinus = CreateWindowEx
		(
			NULL, "Button", "-",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL * 4 + g_i_BUTTON_SIZE * 4, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL + g_i_BUTTON_SIZE,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_MINUS,
			GetModuleHandle(NULL), NULL
		);

		HWND hButMultiply = CreateWindowEx
		(
			NULL, "Button", "*",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL * 4 + g_i_BUTTON_SIZE * 4, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL * 2 + g_i_BUTTON_SIZE * 2,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_ASTER,
			GetModuleHandle(NULL), NULL
		);

		HWND hButDivide = CreateWindowEx
		(
			NULL, "Button", "/",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL * 4 + g_i_BUTTON_SIZE * 4, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL * 3 + g_i_BUTTON_SIZE * 3,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_SLASH,
			GetModuleHandle(NULL), NULL
		);

		HWND hButClr = CreateWindowEx
		(
			NULL, "Button", "Clear",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL * 5 + g_i_BUTTON_SIZE * 5, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_CLR,
			GetModuleHandle(NULL), NULL
		);
		HWND hButBSP = CreateWindowEx
		(
			NULL, "Button", "BSP",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_CENTER,
			g_i_BUTTON_START_X + g_i_INTERVAL * 5 + g_i_BUTTON_SIZE * 5, g_i_BUTTON_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL + g_i_BUTTON_SIZE,
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_BSP,
			GetModuleHandle(NULL), NULL
		);
	}
		break;
	case WM_COMMAND:
#ifdef LOGIC
		switch (LOWORD(wParam))
		{
		case IDC_BUTTON_0:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _0 = '0';
			CHAR sz_buf0_0[sz_SIZE]{};
			CHAR sz_buf0_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf0_0);
			sprintf(sz_buf0_1, "%s%c", sz_buf0_0, _0);
			SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf0_1);
		}
		break;
		case IDC_BUTTON_1:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _1 = '1';
			CHAR sz_buf1_0[sz_SIZE]{};
			CHAR sz_buf1_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf1_0);
			sprintf(sz_buf1_1, "%s%c", sz_buf1_0, _1);
			SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf1_1);
		}
		break;
		case IDC_BUTTON_2:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _2 = '2';
			CHAR sz_buf2_0[sz_SIZE]{};
			CHAR sz_buf2_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf2_0);
			sprintf(sz_buf2_1, "%s%c", sz_buf2_0, _2);
			SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf2_1);
		}
		break;
		case IDC_BUTTON_3:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _3 = '3';
			CHAR sz_buf3_0[sz_SIZE]{};
			CHAR sz_buf3_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf3_0);
			sprintf(sz_buf3_1, "%s%c", sz_buf3_0, _3);
			SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf3_1);
		}
		break;
		case IDC_BUTTON_4:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _4 = '4';
			CHAR sz_buf4_0[sz_SIZE]{};
			CHAR sz_buf4_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf4_0);
			sprintf(sz_buf4_1, "%s%c", sz_buf4_0, _4);
			SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf4_1);
		}
		break;
		case IDC_BUTTON_5:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _5 = '5';
			CHAR sz_buf5_0[sz_SIZE]{};
			CHAR sz_buf5_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf5_0);
			sprintf(sz_buf5_1, "%s%c", sz_buf5_0, _5);
			SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf5_1);
		}
		break;
		case IDC_BUTTON_6:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _6 = '6';
			CHAR sz_buf6_0[sz_SIZE]{};
			CHAR sz_buf6_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf6_0);
			sprintf(sz_buf6_1, "%s%c", sz_buf6_0, _6);
			SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf6_1);
		}
		break;
		case IDC_BUTTON_7:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _7 = '7';
			CHAR sz_buf7_0[sz_SIZE]{};
			CHAR sz_buf7_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf7_0);
			sprintf(sz_buf7_1, "%s%c", sz_buf7_0, _7);
			SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf7_1);
		}
		break;
		case IDC_BUTTON_8:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _8 = '8';
			CHAR sz_buf8_0[sz_SIZE]{};
			CHAR sz_buf8_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf8_0);
			sprintf(sz_buf8_1, "%s%c", sz_buf8_0, _8);
			SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf8_1);
		}
		break;
		case IDC_BUTTON_9:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _9 = '9';
			CHAR sz_buf9_0[sz_SIZE]{};
			CHAR sz_buf9_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf9_0);
			sprintf(sz_buf9_1, "%s%c", sz_buf9_0, _9);
			SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf9_1);
		}
		break;
		case IDC_BUTTON_POINT:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _point = '.';
			CHAR sz_buf_point_0[sz_SIZE]{};
			CHAR sz_buf_point_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf_point_0);
			if (sz_buf_point_0[SendMessage(hEdit, WM_GETTEXTLENGTH, 0, 0) - 1] == _point)
			{
				MessageBox(hwnd, "Same symbol", "Error", MB_OK | MB_ICONERROR);
			}
			else
			{
				sprintf(sz_buf_point_1, "%s%c", sz_buf_point_0, _point);
				SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf_point_1);
			}
		}
		break;
		case IDC_BUTTON_PLUS:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _plus = '+';
			CHAR sz_buf_plus_0[sz_SIZE]{};
			CHAR sz_buf_plus_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf_plus_0);
			if (sz_buf_plus_0[SendMessage(hEdit, WM_GETTEXTLENGTH, 0, 0) - 1] == _plus)
			{
				MessageBox(hwnd, "Same symbol", "Error", MB_OK | MB_ICONERROR);
			}
			else
			{
				sprintf(sz_buf_plus_1, "%s%c", sz_buf_plus_0, _plus);
				SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf_plus_1);
			}
		}
		break;

		// TODO:
		// ПЕРЕПИШИ НАЗВАНИЯ МАСИВОВ ПОД ЕДИНЫМ ИМЕНЕМ sz_buf_0 & sz_buf_1
		//

		case IDC_BUTTON_MINUS:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _minus = '-';
			CHAR sz_buf_0[sz_SIZE]{};
			CHAR sz_buf_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf_0);
			if (sz_buf_0[SendMessage(hEdit, WM_GETTEXTLENGTH, 0, 0) - 1] == _minus)
			{
				MessageBox(hwnd, "Same symbol", "Error", MB_OK | MB_ICONERROR);
			}
			else
			{
				sprintf(sz_buf_1, "%s%c", sz_buf_0, _minus);
				SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf_1);
			}
		}
		break;
		case IDC_BUTTON_ASTER:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _aster = '*';
			CHAR sz_buf_0[sz_SIZE]{};
			CHAR sz_buf_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf_0);
			if (sz_buf_0[SendMessage(hEdit, WM_GETTEXTLENGTH, 0, 0) - 1] == _aster)
			{
				MessageBox(hwnd, "Same symbol", "Error", MB_OK | MB_ICONERROR);
			}
			else
			{
				sprintf(sz_buf_1, "%s%c", sz_buf_0, _aster);
				SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf_1);
			}
		}
		break;
		case IDC_BUTTON_SLASH:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR _slash = '/';
			CHAR sz_buf_0[sz_SIZE]{};
			CHAR sz_buf_1[sz_SIZE]{};
			SendMessage(hEdit, WM_GETTEXT, sz_SIZE, (LPARAM)sz_buf_0);
			if (sz_buf_0[SendMessage(hEdit, WM_GETTEXTLENGTH, 0, 0) - 1] == _slash)
			{
				MessageBox(hwnd, "Same symbol", "Error", MB_OK | MB_ICONERROR);
			}
			else
			{
				sprintf(sz_buf_1, "%s%c", sz_buf_0, _slash);
				SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)sz_buf_1);
			}
		}
		break;
		case IDC_BUTTON_BSP:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
			CHAR sz_buf_0[sz_SIZE];
			//CHAR sz_buf_1[sz_SIZE];
		}
		break;
		break;
		}
#endif // LOGIC
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_CLOSE:
		DestroyWindow(hwnd);
		break;
	default: return DefWindowProc(hwnd, uMsg, wParam, lParam);
	}
	return FALSE;
}