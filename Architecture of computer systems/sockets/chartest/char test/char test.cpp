#include "pch.h"
#include <ctime>
#include <iostream>
using namespace std;
#include <fstream>

int main()
{
	ofstream f;
	f.open("test.txt");
	f << "Dsfgdgdfg";
	f.close();
}