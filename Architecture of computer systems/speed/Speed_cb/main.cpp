// Speed.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

//#include "pch.h"
#include <iostream>

#include <ctime>

using namespace std;

#define nM 1000000
#define MAX_ARR 20

float arr[19];

void result()
{
	int i, j, z, a;
	string mas_type[] = { "int   ","long  ","float ","double","char  " };
	string mas_oper[] = { "+","-","*","/" };

	float MAX = arr[0];
	for (i = 1; i < MAX_ARR; i++)
		if (arr[i] > MAX)
			MAX = arr[i];

	for (a = 0, j = 0; j < 5; j++)
	{
		for (z = a, i = 0; i < 4; z++, i++)
		{
			cout << mas_oper[i].c_str() << " " << mas_type[j].c_str() << "  " << arr[z] << " \t";
			float percent = (float)arr[z] / (float)MAX * 100;
			cout << " " << percent << "% \t";

			if (percent == 100.0)
				cout << "\t";

			for (int _i = 0; _i <= percent / 2; _i++)
				cout << '*';
			cout << endl;

		}
		a += 4;
		cout << endl;
	}
}

template <typename T0>
float appropriation()
{
	T0 x0 = NULL, x1 = NULL, x2 = NULL, x3 = NULL, x4 = NULL, x5 = NULL, x6 = NULL, x7 = NULL, x8 = NULL, x9 = NULL,
		x10 = NULL, x11 = NULL, x12 = NULL, x13 = NULL, x14 = NULL, x15 = NULL, x16 = NULL, x17 = NULL, x18 = NULL, x19 = NULL;
	clock_t before_app = clock();
	for (int i = 0; i < nM; i++)
	{
		x0 = x1;
		x1 = x2;
		x2 = x3;
		x3 = x4;
		x4 = x5;
		x5 = x6;
		x6 = x7;
		x7 = x8;
		x8 = x9;
		x9 = x10;
		x10 = x11;
		x11 = x12;
		x12 = x13;
		x13 = x14;
		x14 = x15;
		x15 = x16;
		x16 = x17;
		x17 = x18;
		x18 = x0;
		x19 = x1;
	}
	clock_t after_app = clock();

	//return (after_app - before_app);
	return 0.0;
}

template <typename T>
float sum()
{
	T i = 24.3432;
	T x0 = 1.74, x1 = 1.543, x2 = 1.543, x3 = 1.3543, x4 = 1.983, x5 = 1.435, x6 = 1.96837, x7 = 1.453, x8 = 1.786, x9 = 1.243,
		x10 = 1.5354, x11 = 1.7863, x12 = 1.543, x13 = 1.65435, x14 = 1.232, x15 = 1.783, x16 = 1.23, x17 = 1.534, x18 = 1.6218, x19 = 1.354;
	clock_t before = clock();
	for (int n = 1; n < nM; n++)
	{
		x0 = n + i;
		x1 = n + i;
		x2 = n + i;
		x3 = n + i;
		x4 = n + i;
		x5 = n + i;
		x6 = n + i;
		x7 = n + i;
		x8 = n + i;
		x9 = n + i;
		x10 = n + i;
		x11 = n + i;
		x12 = n + i;
		x13 = n + i;
		x14 = n + i;
		x15 = n + i;
		x16 = n + i;
		x17 = n + i;
		x18 = n + i;
		x19 = n + i;
	}
	clock_t after = clock();
	return (((after - before) - appropriation<T>()) / CLOCKS_PER_SEC) / 20 / nM;
}

template <typename T1>
float min()
{
	T1 i = 24.3432;
	T1 x0 = 1.74, x1 = 1.543, x2 = 1.543, x3 = 1.3543, x4 = 1.983, x5 = 1.435, x6 = 1.96837, x7 = 1.453, x8 = 1.786, x9 = 1.243,
		x10 = 1.5354, x11 = 1.7863, x12 = 1.543, x13 = 1.65435, x14 = 1.232, x15 = 1.783, x16 = 1.23, x17 = 1.534, x18 = 1.6218, x19 = 1.354;
	clock_t before = clock();
	for (int n = 1; n < nM; n++)
	{
		x0 = n - i;
		x1 = n - i;
		x2 = n - i;
		x3 = n - i;
		x4 = n - i;
		x5 = n - i;
		x6 = n - i;
		x7 = n - i;
		x8 = n - i;
		x9 = n - i;
		x10 = n -  i;
		x11 = n - i;
		x12 = n - i;
		x13 = n - i;
		x14 = n - i;
		x15 = n - i;
		x16 = n - i;
		x17 = n - i;
		x18 = n - i;
		x19 = n - i;
	}
	clock_t after = clock();
	return (((after - before) - appropriation<T1>()) / CLOCKS_PER_SEC) / 20 / nM;
}

template <typename T2>
float mult()
{
	T2 i = 24.3432;
	T2 x0 = 1.74, x1 = 1.543, x2 = 1.543, x3 = 1.3543, x4 = 1.983, x5 = 1.435, x6 = 1.96837, x7 = 1.453, x8 = 1.786, x9 = 1.243,
		x10 = 1.5354, x11 = 1.7863, x12 = 1.543, x13 = 1.65435, x14 = 1.232, x15 = 1.783, x16 = 1.23, x17 = 1.534, x18 = 1.6218, x19 = 1.354;
	clock_t before = clock();
	for (int n = 1; n < nM; n++)
	{
		x0 = n * i;
		x1 = n * i;
		x2 = n * i;
		x3 = n * i;
		x4 = n * i;
		x5 = n * i;
		x6 = n * i;
		x7 = n * i;
		x8 = n * i;
		x9 = n * i;
		x10 = n * i;
		x11 = n * i;
		x12 = n * i;
		x13 = n * i;
		x14 = n * i;
		x15 = n * i;
		x16 = n * i;
		x17 = n * i;
		x18 = n * i;
		x19 = n * i;
	}
	clock_t after = clock();
	return (((after - before) - appropriation<T2>()) / CLOCKS_PER_SEC) / 20 / nM;
}

template <typename T3>
float divis()
{
	T3 i = 24.3432;
	T3 x0 = 1.74, x1 = 1.543, x2 = 1.543, x3 = 1.3543, x4 = 1.983, x5 = 1.435, x6 = 1.96837, x7 = 1.453, x8 = 1.786, x9 = 1.243,
		x10 = 1.5354, x11 = 1.7863, x12 = 1.543, x13 = 1.65435, x14 = 1.232, x15 = 1.783, x16 = 1.23, x17 = 1.534, x18 = 1.6218, x19 = 1.354;
	clock_t before = clock();
	for (int n = 1; n < nM; n++)
	{
		x0 = n / i ;
		x1 = n / i;
		x2 = n / i;
		x3 = n / i;
		x4 = n / i;
		x5 = n / i;
		x6 = n / i;
		x7 = n / i;
		x8 = n / i;
		x9 = n / i;
		x10 = n / i;
		x11 = n / i;
		x12 = n / i;
		x13 = n / i;
		x14 = n / i;
		x15 = n / i;
		x16 = n / i;
		x17 = n / i;
		x18 = n / i;
		x19 = n / i;
	}
	clock_t after = clock();
	return (((after - before) - appropriation<T3>()) / CLOCKS_PER_SEC) / 20 / nM;
}

int main()
{
	arr[0] = sum<int>();
	arr[1] = min<int>();
	arr[2] = mult<int>();
	arr[3] = divis<int>();
	arr[4] = sum<long>();
	arr[5] = min<long>();
	arr[6] = mult<long>();
	arr[7] = divis<long>();
	arr[8] = sum<float>();
	arr[9] = min<float>();
	arr[10] = mult<float>();
	arr[11] = divis<float>();
	arr[12] = sum<double>();
	arr[13] = min<double>();
	arr[14] = mult<double>();
	arr[15] = divis<double>();
	arr[16] = sum<char>();
	arr[17] = min<char>();
	arr[18] = mult<char>();
	arr[19] = divis<char>();
	result();
	return 0;
}


// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
