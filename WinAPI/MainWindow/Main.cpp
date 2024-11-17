#include <Windows.h>

CONST char g_sz_WINDOW_CLASS[] = "Main Window";

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

	wClass.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wClass.hIconSm = LoadIcon(NULL, IDI_APPLICATION);
	wClass.hCursor = LoadCursor(NULL, IDC_ARROW);
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
			CW_USEDEFAULT, CW_USEDEFAULT,		//Position - положение окна при запуске
			CW_USEDEFAULT, CW_USEDEFAULT,		//Size - размер создаваемого окна
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