#define _CRT_SECURE_NO_WARNINGS
#include <Windows.h>
#include "resource.h"
#include<cstdio>

CONST char g_sz_WINDOW_CLASS[] = "Main Window";
CONST char WinName[] = "%s. Size: %ix%i; Corners Location:LT:(%ix%i),  LB:(%ix%i),  RT:(%ix%i),  RB:(%ix%i)";

INT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR  lpCmdLine, INT nCmdShow)
{
	WNDCLASSEX wClass;
	ZeroMemory(&wClass, sizeof(wClass));

	//Смотри конспект.
	//1)
	wClass.style = 0;
	wClass.cbSize = sizeof(wClass); //cb - CountBytes
	wClass.cbClsExtra = 0;
	wClass.cbWndExtra = 0;

	wClass.hIcon = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_ICON_CCross));
	wClass.hIconSm = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_ICON_DEVIL));
	wClass.hCursor = (HCURSOR)LoadImage(hInstance, "Cursors\\Hand.ani", IMAGE_CURSOR, 32, 32, LR_LOADFROMFILE);
	wClass.hbrBackground = (HBRUSH)COLOR_WINDOW;

	wClass.hInstance = hInstance;
	wClass.lpszMenuName = NULL;
	wClass.lpszClassName = g_sz_WINDOW_CLASS;
	wClass.lpfnWndProc = (WNDPROC)WndProc;

	if (!RegisterClassEx(&wClass))
	{
		MessageBox(NULL, "Class Registration Fail", "Error", MB_OK | MB_ICONERROR);
		return 0;
	}

	//2)
	HWND hwnd = CreateWindowEx
		(
			NULL,								//Ex-styles
			g_sz_WINDOW_CLASS,					//Class name
			g_sz_WINDOW_CLASS,					//Window title
			WS_OVERLAPPEDWINDOW,				//Window style. Такой стиль всегда задется для главного окна. 
			(GetSystemMetrics(SM_CXSCREEN) * 12) / 100, (GetSystemMetrics(SM_CYSCREEN) * 12) / 100,		//Position - положение окна при запуске
			(GetSystemMetrics(SM_CXSCREEN) * 75) / 100, (GetSystemMetrics(SM_CYSCREEN) * 75) / 100,		//Size - размер создаваемого окна
			NULL,								//Parent
			NULL,								//hMenu: 
												//для главного окна это ResourceID главного меню. 
												//Для дочернего окна (элемента какого-то окна): ResourceID соответствующего элемента.
												//По этому ResousceID нужный элемент всегда можно получить при помощи функции GetDlgItem() 
			hInstance,
			NULL
		);
	if (hwnd == NULL)
	{
		MessageBox(NULL, "Window Creation Fail", "Error", MB_OK | MB_ICONERROR);
		return 0;
	}

	ShowWindow(hwnd, nCmdShow);		//Задает режим отображения окна (Развернуто на весь экран, свернуто в окно, свернуто на панель задач)
	UpdateWindow(hwnd);				//Прорисовывает окно.

	//3)
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
		break;
	case WM_SIZE:
	{
		CHAR change[512]{};
		RECT rect;
		GetWindowRect(hwnd, &rect);
		INT width = rect.right - rect.left;
		INT height = rect.bottom - rect.top;
		sprintf
		(
			change,
			WinName,
			g_sz_WINDOW_CLASS,
			width,
			height,
			(int)rect.left, (int)rect.top,
			(int)rect.left, (int)rect.bottom,
			(int)rect.right, (int)rect.top,
			(int)rect.right, (int)rect.bottom
		);
		SetWindowText(hwnd, change);
	}
	break;
	case WM_MOVE:
	{
		CHAR change[512]{};
		RECT rect;
		GetWindowRect(hwnd, &rect);
		INT width = rect.right - rect.left;
		INT height = rect.bottom - rect.top;
		//sprintf_s(change, "%s (Location LT:(%ix%i),  LB:(%ix%i),  RT:(%ix%i),  RB:(%ix%i)", g_sz_WINDOW_CLASS, (int)rect.left, (int)rect.top, (int)rect.left, (int)rect.bottom, (int)rect.right, (int)rect.top, (int)rect.right, (int)rect.bottom);
		sprintf
		(
			change,
			WinName,
			g_sz_WINDOW_CLASS,
			width,
			height,
			(int)rect.left, (int)rect.top,
			(int)rect.left, (int)rect.bottom,
			(int)rect.right, (int)rect.top,
			(int)rect.right, (int)rect.bottom
		);
		SetWindowText(hwnd, change);
	}
	break;
	case WM_COMMAND:
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_CLOSE:
		DestroyWindow(hwnd);
		break;
	default: return DefWindowProc(hwnd, uMsg, wParam, lParam);
	}
	return 0;
}