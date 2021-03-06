// test.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>
#include <stdio.h>

#define _WINSOCK_DEPRECATED_NO_WARNINGS
#define DEFAULT_PROTOCOL 0
#define MAX 255
#include <WinSock2.h>
#include <string>
#include <fstream>
#include <time.h>
using namespace std;

int main()
{
	WSADATA wsaData;
	string clientSet = "1 2 2 3 3 3 4 5 6 7 ";
	ofstream f;
	f.open("client_log.txt");
	time_t rawtime;
	struct tm * timeinfo;
	time(&rawtime);
	timeinfo = localtime(&rawtime);
	f << asctime(timeinfo)<<"Client START\n\n";

	//ініціалізація інтерфейсу
	int iResult = WSAStartup(0x0202, &wsaData);
	if (iResult != 0)
	{
		cout << "ERROR at WSAStartup\n";
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "ERROR at WSAStartup\n\n";
		f.close();
		return 1;
	}
	else
	{
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "WSAData created\n\n";
		cout << "WSAData created\n";
	}

	//створення сокету
	SOCKET clientSocket;
	clientSocket = socket(PF_INET, SOCK_STREAM, DEFAULT_PROTOCOL);
	if (clientSocket == 0)
	{
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "ERROR: Socket is not created\n\n";
		cout << "ERROR: Socket is not created\n";
		f.close();
		return 1;
	}
	else
	{
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "Socket is created\n\n";
		cout << "Socket is created\n";
	}

	//під'єднання до сервера
	sockaddr_in clientService;
	clientService.sin_family = PF_INET;
	clientService.sin_addr.s_addr = inet_addr("127.0.0.1");
	clientService.sin_port = htons(1055);
	iResult = connect(clientSocket, (SOCKADDR*) &clientService, sizeof(clientService));
	if (iResult != 0)
	{
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "connection ERROR\n\n";
		cout << "connection ERROR\n";
		f.close();
		return 1;
	}
	else
	{
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "Socket is connected\n\n";
		cout << "Socket is connected\n";
	}

	//_____________
	//робота із сервером
	//_______________
	int iBytesSent;
	int iBytesRecv;
	char recvbuf[MAX];
	char sendbuf[MAX];
	string str;
	while (1)
	{
		cout << '>';
		getline(cin, str);
		strcpy(sendbuf, str.c_str());

		//++++++++++++++++++++++++++++++++++++++++
		iBytesSent = send(clientSocket, sendbuf, MAX, 0);
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "Client sent " << iBytesSent << " bytes" << endl << sendbuf << endl << endl;
		cout << "Client sent " << iBytesSent << " bytes" << endl;

		iBytesRecv = SOCKET_ERROR;
		while (iBytesRecv == SOCKET_ERROR)
		{
			iBytesRecv = recv(clientSocket, recvbuf, MAX, 0);
			if (iBytesRecv != SOCKET_ERROR)
			{
				time(&rawtime);
				timeinfo = localtime(&rawtime);
				f << asctime(timeinfo);
				f << "Received " << iBytesSent << " bytes" << endl << recvbuf << endl << endl;
				cout << "\nReceived " << iBytesRecv << " bytes" << endl;
				cout << recvbuf << endl;
				break;
			}
		}

		//Synchronization
		if (str == "Synchronization")
		{
			time(&rawtime);
			timeinfo = localtime(&rawtime);
			f << asctime(timeinfo);
			f << "clientSet before Synchronization = " << clientSet << endl << endl;
			cout << "\nclientSet before Synchronization = " << clientSet << endl;
			char sendbuf3[MAX];
			strcpy(sendbuf3, clientSet.c_str());
			iBytesSent = send(clientSocket, sendbuf3, MAX, 0);
			time(&rawtime);
			timeinfo = localtime(&rawtime);
			f << asctime(timeinfo);
			f << "Client sent " << iBytesSent << " bytes" << endl << sendbuf3 << endl << endl;
			cout << "\nClient sent " << iBytesSent << " bytes" << endl;
			cout << sendbuf3 << endl;

			iBytesRecv = SOCKET_ERROR;
			while (iBytesRecv == SOCKET_ERROR)
			{
				iBytesRecv = recv(clientSocket, recvbuf, MAX, 0);
				if (iBytesRecv != SOCKET_ERROR)
				{
					time(&rawtime);
					timeinfo = localtime(&rawtime);
					f << asctime(timeinfo);
					f << "Received " << iBytesSent << " bytes" << endl << recvbuf << endl << endl;
					cout << "\nReceived " << iBytesRecv << " bytes" << endl;
					cout << recvbuf << endl;
					clientSet = recvbuf;
					break;
				}
			}

			time(&rawtime);
			timeinfo = localtime(&rawtime);
			f << asctime(timeinfo);
			f << "clientSet after Synchronization = " << clientSet << endl << endl;
			cout << "\nclientSet after Synchronization = " << clientSet << endl;
		}
		
		if (str == "End of work")
		{
			break;
		}

	}

	if (closesocket(clientSocket) != 0)
	{
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "ERROR: socket is not closed";
		cout << "ERROR: socket is not closed";
		f.close();
		return 1;
	}
	WSACleanup();
	time(&rawtime);
	timeinfo = localtime(&rawtime);
	f << asctime(timeinfo) << "Client END\n\n";
	f.close();
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
