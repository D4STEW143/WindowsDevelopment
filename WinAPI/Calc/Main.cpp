#define _CRT_SECURE_NO_WARNINGS
#include <Windows.h>
#include <float.h>
#include "resource.h"
#include "Dimentions.h"
#include "Skins.h"
#include<cstdio>

CONST CHAR g_sz_WINDOW_CLASS[] = "Calc_VPD_311";
//CONST CHAR g_sz_METAL_MISTRAL[] = "MetalMistral";
//CONST CHAR g_sz_SQUARE_BLUE[] = "SquareBlue";

CONST CHAR* g_OPERATIONS[] = { "+", "-", "*", "/" };



INT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
INT GetTitleBarHeight(HWND hwnd);
VOID SetSkin(HWND hwnd, CONST CHAR skin[]);

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
		WS_OVERLAPPEDWINDOW ^ WS_THICKFRAME ^ WS_MAXIMIZEBOX,
		CW_USEDEFAULT, CW_USEDEFAULT,
		g_i_WINDOW_WIDTH + 16, g_i_WINDOW_HEIGHT + 42,
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
	static INT index = 0;
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

		CHAR sz_digit[2]{};
		for (int i = 6; i >= 0; i -= 3)
		{
			for (int j = 0; j < 3; j++)
			{
				sz_digit[0] = i + j + '1';
				CreateWindowEx
				(
					NULL, "Button", sz_digit,
					WS_CHILD | WS_VISIBLE | BS_BITMAP,
					BUTTON_SHIFT_X(j),
					BUTTON_SHIFT_Y(2 - i / 3),
					g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
					hwnd,
					(HMENU)(IDC_BUTTON_1 + i + j),
					GetModuleHandle(NULL), NULL
				);
			}
		}

		HWND hButton0 = CreateWindowEx
		(
			NULL, "Button", "0",
			WS_CHILD | WS_VISIBLE | BS_BITMAP,
			BUTTON_SHIFT_X(0), BUTTON_SHIFT_Y(3),
			g_i_BUTTON_DOUBLE_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_0, GetModuleHandle(NULL), NULL
		);
		/*HBITMAP bmpButton0 = (HBITMAP)LoadImage(NULL, "Icon\\Buttons\\Zero.bmp", IMAGE_BITMAP, g_i_BUTTON_DOUBLE_SIZE, g_i_BUTTON_SIZE, LR_LOADFROMFILE);
		SendMessage(hButton0, BM_SETIMAGE, IMAGE_BITMAP, (LPARAM)bmpButton0);*/

		CreateWindowEx
		(
			NULL, "Button", ".",
			WS_CHILD | WS_VISIBLE | BS_BITMAP,
			BUTTON_SHIFT_X(2),
			BUTTON_SHIFT_Y(3),
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd,
			(HMENU)IDC_BUTTON_POINT, GetModuleHandle(NULL), NULL
		);

		for (int i = 0; i < 4;i++)
		{
			CreateWindowEx(
				NULL, "Button", g_OPERATIONS[i],
				WS_CHILD | WS_VISIBLE | BS_BITMAP,
				BUTTON_SHIFT_X(3), BUTTON_SHIFT_Y(3 - i),
				g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
				hwnd, (HMENU)(IDC_BUTTON_PLUS + i), GetModuleHandle(NULL), NULL
			);
		}
		CreateWindowEx(
			NULL, "Button", "<-",
			WS_CHILD | WS_VISIBLE | BS_BITMAP,
			BUTTON_SHIFT_X(4), BUTTON_SHIFT_Y(0),
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_BSP, GetModuleHandle(NULL), NULL
		);
		CreateWindowEx(
			NULL, "Button", "Clear",
			WS_CHILD | WS_VISIBLE | BS_BITMAP,
			BUTTON_SHIFT_X(4), BUTTON_SHIFT_Y(1),
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd, (HMENU)IDC_BUTTON_CLR, GetModuleHandle(NULL), NULL
		);
		CreateWindowEx(
			NULL, "Button", "=",
			WS_CHILD | WS_VISIBLE | BS_BITMAP,
			BUTTON_SHIFT_X(4), BUTTON_SHIFT_Y(2),
			g_i_BUTTON_SIZE, g_i_BUTTON_DOUBLE_SIZE,
			hwnd, (HMENU)IDC_BUTTON_EQUAL, GetModuleHandle(NULL), NULL
		);

		SetSkin(hwnd, "square_blue");
	}
	break;
	case WM_CTLCOLOREDIT:
	{
		HDC hdcEdit = (HDC)wParam;
		//SetBkMode(hdcEdit, OPAQUE);
		SetBkColor(hdcEdit, g_DISPLAY_BACKGROUND_COLOR[index]);
		SetTextColor(hdcEdit, g_DISPLAY_FOREGROUND_COLOR[index]);

		HBRUSH hbrBackground = CreateSolidBrush(g_WINDIW_BACKGROUND_COLOR[index]);
		SetClassLongPtr(hwnd, GCLP_HBRBACKGROUND, (LONG)hbrBackground);
		SendMessage(hwnd, WM_ERASEBKGND, wParam, 0);
		//SetSkin(hwnd, "square_blue");
		RedrawWindow(hwnd, NULL, NULL, RDW_ERASE);
		return (LRESULT)hbrBackground;
	}
	break;
	case WM_COMMAND:
	{
		static DOUBLE a = DBL_MIN;
		static DOUBLE b = DBL_MIN;
		static WORD operation = 0;
		static BOOL input = FALSE;
		static BOOL operation_input = FALSE;
		static BOOL equal_pressed = FALSE;

		HWND hEditDisplay = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
		CONST INT SIZE = 256;
		CHAR sz_display[SIZE]{};
		CHAR sz_digit[2]{};

		//SetSkin(hwnd, "SquareBlue");
		///////////////////////////////////////Font/////////////////////////////////////////
		/*HFONT hFont = CreateFont(18, 0, 0, 0, FW_DONTCARE, FALSE, FALSE, FALSE, ANSI_CHARSET,
			OUT_TT_PRECIS, CLIP_DEFAULT_PRECIS, DEFAULT_QUALITY,
			DEFAULT_PITCH | FF_DONTCARE, TEXT("MOSCOW2024"));
		SendMessage(hEditDisplay, WM_SETFONT, (WPARAM)hFont, TRUE);*/
		////////////////////////////////////////////////////////////////////////////////////

		if (LOWORD(wParam) >= IDC_BUTTON_0 && LOWORD(wParam) <= IDC_BUTTON_9)
		{
			if (operation_input || equal_pressed)
			{
				SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)"");
				operation_input = equal_pressed = FALSE;
			}
			sz_digit[0] = LOWORD(wParam) - IDC_BUTTON_0 + '0';
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (strlen(sz_display) == 1 && sz_display[0] == '0')
			{
				sz_display[0] = sz_digit[0];
			}
			else
			{
				strcat(sz_display, sz_digit);
			}
			SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display);
			input = TRUE;

		}
		/*if (LOWORD(wParam) == IDC_BUTTON_POINT)
		{
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (strchr(sz_display, '.'))break;
			strcat(sz_display, ".");
			SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display);
		}*/
		switch (LOWORD(wParam))
		{
		case IDC_BUTTON_POINT:
		{
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (strchr(sz_display, '.'))break;
			strcat(sz_display, ".");
			SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display);
		}
		break;
		/*case IDC_BUTTON_PLUS:
		{
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (sz_display[SendMessage(hEditDisplay, WM_GETTEXTLENGTH, 0, 0) - 1] != '+')
			{
				strcat(sz_display, "+");
				SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display);
			}
			else break;
		}
		break;
		case IDC_BUTTON_MINUS:
		{
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (sz_display[SendMessage(hEditDisplay, WM_GETTEXTLENGTH, 0, 0) - 1] != '-')
			{
				strcat(sz_display, "-");
				SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display);
			}
			else break;
		}
		break;
		case IDC_BUTTON_ASTER:
		{
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (sz_display[SendMessage(hEditDisplay, WM_GETTEXTLENGTH, 0, 0) - 1] != '*')
			{
				strcat(sz_display, "*");
				SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display);
			}
			else break;
		}
		break;
		case IDC_BUTTON_SLASH:
		{
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (sz_display[SendMessage(hEditDisplay, WM_GETTEXTLENGTH, 0, 0) - 1] != '/')
			{
				strcat(sz_display, "/");
				SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display);
			}
			else break;
		}*/
		break;
		case IDC_BUTTON_BSP:
		{
			/*CHAR sz_display_bsp[SIZE]{};
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (strlen(sz_display) != 0)
			{
				strncpy(sz_display_bsp, sz_display, SendMessage(hEditDisplay, WM_GETTEXTLENGTH, 0, 0) - 1);
				SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display_bsp);
			}
			else break;*/
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (strlen(sz_display) != 0)
			{
				sz_display[strlen(sz_display) - 1] = 0;
				SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display);
			}
			else break;

		}
		break;
		case IDC_BUTTON_CLR:
		{
			/*SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			memset(sz_display, '\0', SIZE);
			SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display);*/
			a = b = DBL_MIN;
			operation = 0;
			input = operation_input = FALSE;
			SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)"0");
		}
		break;
		}
		////////////////////////////////////////EQUAL/////////////////////////////////
		if (LOWORD(wParam) >= IDC_BUTTON_PLUS && LOWORD(wParam) <= IDC_BUTTON_SLASH)
		{
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (input && a == DBL_MIN) a = atof(sz_display);
			//input = FALSE;
			if (operation && input) SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_EQUAL), 0);
			operation = LOWORD(wParam);
			operation_input = TRUE;
			equal_pressed = FALSE;
		}
		if (LOWORD(wParam) == IDC_BUTTON_EQUAL)
		{
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (input)b = atof(sz_display);
			input = FALSE;
			switch (operation)
			{
			case IDC_BUTTON_PLUS:a += b; break;
			case IDC_BUTTON_MINUS:a -= b; break;
			case IDC_BUTTON_ASTER:a *= b; break;
			case IDC_BUTTON_SLASH:a /= b; break;
			}
			operation_input = FALSE;
			equal_pressed = TRUE;
			sprintf(sz_display, "%g", a);
			SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display);
		}
		//////////////////////////////////////////////////////////////////////////////
		SetFocus(hwnd);//для того чтобы клава работала правильно

	}
	break;
	case WM_KEYDOWN:
	{
		if (GetKeyState(VK_SHIFT) < 0 && wParam == 0x38)
		{
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_ASTER), BM_SETSTATE, TRUE, 0);
		}
		else if (wParam >= '0' && wParam <= '9')
		{
			SendMessage(GetDlgItem(hwnd, wParam - '0' + IDC_BUTTON_0), BM_SETSTATE, TRUE, 0);
		}
		else if (wParam >= 0x60 && wParam <= 0x69)
		{
			SendMessage(GetDlgItem(hwnd, wParam - 0x60 + IDC_BUTTON_0), BM_SETSTATE, TRUE, 0);
		}
		switch (wParam)
		{
		case VK_OEM_PLUS:
		case VK_ADD:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_PLUS), BM_SETSTATE, TRUE, 0);
			break;
		case VK_OEM_MINUS:
		case VK_SUBTRACT:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_MINUS), BM_SETSTATE, TRUE, 0);
			break;
		case VK_MULTIPLY:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_ASTER), BM_SETSTATE, TRUE, 0);
			break;
		case VK_OEM_2:
		case VK_DIVIDE:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_SLASH), BM_SETSTATE, TRUE, 0);
			break;
		case VK_DECIMAL:
		case VK_OEM_PERIOD:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_POINT), BM_SETSTATE, TRUE, 0);
			break;
		case VK_BACK:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_BSP), BM_SETSTATE, TRUE, 0);
			break;
		case VK_ESCAPE:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_CLR), BM_SETSTATE, TRUE, 0);
			break;
		case VK_RETURN:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_EQUAL), BM_SETSTATE, TRUE, 0);
			break;
		}
	}
	break;
	case WM_KEYUP:
	{
		if (GetKeyState(VK_SHIFT) < 0 && wParam == 0x38)
		{
			SendMessage(hwnd, WM_COMMAND, IDC_BUTTON_ASTER, 0);
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_ASTER), BM_SETSTATE, FALSE, 0);
		}
		else if (wParam >= '0' && wParam <= '9')
		{
			SendMessage(hwnd, WM_COMMAND, LOWORD(wParam - '0' + IDC_BUTTON_0), 0);
			SendMessage(GetDlgItem(hwnd, wParam - '0' + IDC_BUTTON_0), BM_SETSTATE, FALSE, 0);
		}
		else if (wParam >= 0x60 && wParam <= 0x69)
		{
			SendMessage(hwnd, WM_COMMAND, LOWORD(wParam - 0x60 + IDC_BUTTON_0), 0);
			SendMessage(GetDlgItem(hwnd, wParam - 0x60 + IDC_BUTTON_0), BM_SETSTATE, FALSE, 0);
		}
		switch (wParam)
		{
		case VK_OEM_PLUS:
		case VK_ADD:
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_PLUS), 0);
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_PLUS), BM_SETSTATE, FALSE, 0);
			break;
		case VK_OEM_MINUS:
		case VK_SUBTRACT:
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_MINUS), 0);
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_MINUS), BM_SETSTATE, FALSE, 0);
			break;
		case VK_MULTIPLY:
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_ASTER), 0);
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_ASTER), BM_SETSTATE, FALSE, 0);
			break;
		case VK_OEM_2:
		case VK_DIVIDE:
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_SLASH), 0);
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_SLASH), BM_SETSTATE, FALSE, 0);
			break;
		case VK_DECIMAL:
		case VK_OEM_PERIOD:
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_POINT), 0);
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_POINT), BM_SETSTATE, FALSE, 0);
			break;
		case VK_BACK:
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_BSP), 0);
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_BSP), BM_SETSTATE, FALSE, 0);
			break;
		case VK_ESCAPE:
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_CLR), 0);
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_CLR), BM_SETSTATE, FALSE, 0);
			break;
		case VK_RETURN:
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_EQUAL), 0);
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_EQUAL), BM_SETSTATE, FALSE, 0);
			break;
		}
	}
	break;
	case WM_CONTEXTMENU:
	{
		//1)создаем всплывающее меню
		HMENU hMenu = CreatePopupMenu();

		//2)добавляем пункты в это меню
		InsertMenu(hMenu, 0, MF_BYPOSITION | MF_STRING, IDR_EXIT, "Exit");
		InsertMenu(hMenu, 0, MF_BYPOSITION | MF_SEPARATOR, 0, NULL);
		InsertMenu(hMenu, 0, MF_BYPOSITION | MF_STRING, IDR_METAL_MISTRAL, "Metal Mistral");
		InsertMenu(hMenu, 0, MF_BYPOSITION | MF_STRING, IDR_SQUARE_BLUE, "Square Blue");

		//3)Открыть меню
		DWORD item = TrackPopupMenu(hMenu, TPM_RIGHTALIGN | TPM_BOTTOMALIGN | TPM_RETURNCMD, LOWORD(lParam), HIWORD(lParam), 0, hwnd, NULL);
		switch (item)
		{
		case IDR_SQUARE_BLUE:	//index = IDR_SQUARE_BLUE;		break;
		case IDR_METAL_MISTRAL:	//SetSkin(hwnd, "metal_mistral");		break;
			index = item - IDR_SQUARE_BLUE;
			break;
		case IDR_EXIT:			SendMessage(hwnd, WM_CLOSE, 0, 0);	break;
		}

		HWND hEditDisplay = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
		HDC hdcDisplay = GetDC(hEditDisplay);
		SendMessage(hwnd, WM_CTLCOLOREDIT, (WPARAM)hdcDisplay, 0);
		ReleaseDC(hEditDisplay,hdcDisplay);
		SetSkin(hwnd, g_SKIN[index]);
		SetFocus(hEditDisplay);
		//4)Удаляем меню
		DestroyMenu(hMenu);
	}
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

INT GetTitleBarHeight(HWND hwnd)
{
	RECT window_rect;
	RECT client_rect;
	GetWindowRect(hwnd, &window_rect);
	GetClientRect(hwnd, &client_rect);
	INT titleBarHeight = (window_rect.bottom - window_rect.top) - (client_rect.bottom - client_rect.top);

	return titleBarHeight;
	//return 0;
}

CONST CHAR* g_BUTTONS[] =
{
	"button_0.bmp",
	"button_1.bmp",
	"button_2.bmp",
	"button_3.bmp",
	"button_4.bmp",
	"button_5.bmp",
	"button_6.bmp",
	"button_7.bmp",
	"button_8.bmp",
	"button_9.bmp",
	"button_point.bmp",
	"button_plus.bmp",
	"button_minus.bmp",
	"button_aster.bmp",
	"button_slash.bmp",
	"button_bsp.bmp",
	"button_clr.bmp",
	"button_equal.bmp",
};

VOID SetSkin(HWND hwnd, CONST CHAR skin[])
{
	//CHAR sz_route[] = "Icon\\Buttons\\square_blue\\button_%i.bmp";
	//CHAR sz_buffer[256]{};
	//HWND hEditDisplay = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);

	////Zero
	//sprintf(sz_buffer, sz_route, 0);
	//HBITMAP bmpButton0 = (HBITMAP)LoadImage(NULL, sz_buffer, IMAGE_BITMAP, g_i_BUTTON_DOUBLE_SIZE, g_i_BUTTON_SIZE, LR_LOADFROMFILE);
	//SendMessage(GetDlgItem(hwnd, IDC_BUTTON_0), BM_SETIMAGE, IMAGE_BITMAP, (LPARAM)bmpButton0);

	////Digits & Operators
	//for (int i = 1; i < 17; i++)
	//{
	//	HWND Button = GetDlgItem(hwnd, IDC_BUTTON_0 + i);
	//	sprintf(sz_buffer, sz_route, i);
	//	HBITMAP bmpButton = (HBITMAP)LoadImage(NULL, sz_buffer, IMAGE_BITMAP, g_i_BUTTON_SIZE, g_i_BUTTON_SIZE, LR_LOADFROMFILE);
	//	SendMessage(Button, BM_SETIMAGE, IMAGE_BITMAP, (LPARAM)bmpButton);
	//}

	////Equal
	//sprintf(sz_buffer, sz_route, 17);
	//HBITMAP bmpButtonEqual = (HBITMAP)LoadImage(NULL, sz_buffer, IMAGE_BITMAP, g_i_BUTTON_SIZE, g_i_BUTTON_DOUBLE_SIZE, LR_LOADFROMFILE);
	//SendMessage(GetDlgItem(hwnd, IDC_BUTTON_EQUAL), BM_SETIMAGE, IMAGE_BITMAP, (LPARAM)bmpButtonEqual);

	CHAR sz_filename[MAX_PATH]{};
	for (int i = IDC_BUTTON_0; i <= IDC_BUTTON_EQUAL; i++)
	{
		HWND hButton = GetDlgItem(hwnd, i);
		sprintf(sz_filename, "Icon\\Buttons\\%s\\%s", skin, g_BUTTONS[i - IDC_BUTTON_0]);
		HBITMAP bmpButton = (HBITMAP)LoadImage(
			NULL,
			sz_filename,
			IMAGE_BITMAP,
			i == IDC_BUTTON_0 ? g_i_BUTTON_DOUBLE_SIZE : g_i_BUTTON_SIZE,
			i == IDC_BUTTON_EQUAL ? g_i_BUTTON_DOUBLE_SIZE : g_i_BUTTON_SIZE,
			LR_LOADFROMFILE
		);
		SendMessage(hButton, BM_SETIMAGE, IMAGE_BITMAP, (LPARAM)bmpButton);
	}
}