// time test.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"

#include <stdio.h>
#include <time.h>
#include <iostream>
using namespace std;

int main()
{
	time_t rawtime;
	struct tm * timeinfo;
	time(&rawtime);
	timeinfo = localtime(&rawtime);
	cout << asctime(timeinfo) << endl;
	while (1)
	{
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		cout << asctime(timeinfo) << endl;
	}
		return 0;
}