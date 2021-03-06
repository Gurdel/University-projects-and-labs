// test.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>

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
	string serverSet = "2 3 3 5 9 55 66 ";
	ofstream f;
	f.open("server_log.txt");
	time_t rawtime;
	struct tm * timeinfo;
	time(&rawtime);
	timeinfo = localtime(&rawtime);
	f << asctime(timeinfo) << "Server START\n\n";

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
		cout << "WSAData created\n";
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "WSAData created\n\n";
	}

	//створення сокету
	SOCKET serverSocket;
	serverSocket = socket(PF_INET, SOCK_STREAM, DEFAULT_PROTOCOL);
	if (serverSocket == 0)
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
		cout << "Socket is created\n";
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "Socket is created\n\n";
	}

	//встановлення асоціації локальної адреси із сокетом
	sockaddr_in service;
	service.sin_family = PF_INET;
	service.sin_addr.s_addr = inet_addr("127.0.0.1");
	service.sin_port = htons(1055);
	iResult = bind(serverSocket, (SOCKADDR*)&service, sizeof(service));
	if (iResult != 0)
	{
		cout << "ERROR: bind() failed\n";
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "ERROR: bind() failed\n\n";
		f.close();
		return 1;
	}
	else
	{
		cout << "Socket is binded\n";
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "Socket is binded\n\n";
	}

	//прослуховування порта на з'єднання
	iResult = listen(serverSocket, 1);
	if (iResult != 0)
	{
		cout << "ERROR listening on socket\n";
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "ERROR listening on socket\n\n";
		f.close();
		return 1;
	}
	else
	{
		cout << "Listening on socket\n";
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "Listening on socket\n\n";
	}

	//вибір клієнтів із черги на приєднання до сервера
	SOCKET acceptSocet;
	cout << "Waiting for client to connect\n";
	time(&rawtime);
	timeinfo = localtime(&rawtime);
	f << asctime(timeinfo);
	f << "Waiting for client to connect\n\n";
	acceptSocet = SOCKET_ERROR;
	while (acceptSocet == SOCKET_ERROR)
	{
		acceptSocet = accept(serverSocket, NULL, NULL);
	}
	cout << "Client connected\n";
	time(&rawtime);
	timeinfo = localtime(&rawtime);
	f << asctime(timeinfo);
	f << "Client connected\n\n";
	serverSocket = acceptSocet;

	//______________
	//робота з клієнтом
	//______________
	int iBytesSent;
	int iBytesRecv;
	char recvbuf[MAX];
	string s;
	while (1)
	{
		iBytesRecv = SOCKET_ERROR;
		while (iBytesRecv == SOCKET_ERROR)
		{
			iBytesRecv = recv(serverSocket, recvbuf, MAX, 0);
			if (iBytesRecv != SOCKET_ERROR)
			{
				cout << "\nReceived " << iBytesRecv << " bytes" << endl;
				cout << recvbuf << endl;
				time(&rawtime);
				timeinfo = localtime(&rawtime);
				f << asctime(timeinfo);
				f << "Received " << iBytesRecv << " bytes" << endl << recvbuf << endl << endl;
				break;
			}
		}
		s = string(recvbuf);

		if (s == "Who")
		{
			char sendbuf1[MAX] = "Maksym Shevcenko K-27 || 30. Synchronization of sets of numbers";
			iBytesSent = send(serverSocket, sendbuf1, MAX, 0);
			cout << "\nServer sent " << iBytesSent << " bytes" << endl;
			cout << sendbuf1 << endl;
			time(&rawtime);
			timeinfo = localtime(&rawtime);
			f << asctime(timeinfo);
			f << "Server sent " << iBytesSent << " bytes" << endl << sendbuf1 << endl << endl;
			continue;
		}

		if (s == "Synchronization")
		{
			char sendbuf2[MAX] = "Server is ready for Synchronization";
			iBytesSent = send(serverSocket, sendbuf2, MAX, 0);
			cout << "\nServer sent " << iBytesSent << " bytes" << endl;
			cout << sendbuf2 << endl;
			time(&rawtime);
			timeinfo = localtime(&rawtime);
			f << asctime(timeinfo);
			f << "Server sent " << iBytesSent << " bytes" << endl << sendbuf2 << endl << endl;

			cout << "\nserverSet before Synchronization = " << serverSet << endl;
			time(&rawtime);
			timeinfo = localtime(&rawtime);
			f << asctime(timeinfo);
			f << "serverSet before Synchronization = " << serverSet << endl << endl;

			iBytesRecv = SOCKET_ERROR;
			while (iBytesRecv == SOCKET_ERROR)
			{
				iBytesRecv = recv(serverSocket, recvbuf, MAX, 0);
				if (iBytesRecv != SOCKET_ERROR)
				{
					cout << "\nReceived " << iBytesRecv << " bytes" << endl;
					cout << recvbuf << endl;
					time(&rawtime);
					timeinfo = localtime(&rawtime);
					f << asctime(timeinfo);
					f << "Received " << iBytesRecv << " bytes" << endl << recvbuf << endl << endl;
					break;
				}
			}
			s = string(recvbuf);

			string sets;
			string buf;
			while (serverSet.find(' ') != string::npos)
			{
				buf.clear();
				buf = serverSet.substr(0, serverSet.find(' ') + 1);
				if (s.find(buf) != string::npos)
				{
					s.erase(s.find(buf), buf.length());
				}
				sets += buf;
				serverSet.erase(0, serverSet.find(' ') + 1);
			}

			s += sets;
			serverSet = s;

			cout << "\nserverSet after Synchronization = " << serverSet << endl;
			time(&rawtime);
			timeinfo = localtime(&rawtime);
			f << asctime(timeinfo);
			f << "serverSet after Synchronization = " << serverSet << endl << endl;

			char sendbuf3[MAX];
			strcpy(sendbuf3, serverSet.c_str());
			iBytesSent = send(serverSocket, sendbuf3, MAX, 0);
			cout << "\nServer sent " << iBytesSent << " bytes" << endl;
			cout << sendbuf3 << endl;
			time(&rawtime);
			timeinfo = localtime(&rawtime);
			f << asctime(timeinfo);
			f << "Server sent " << iBytesSent << " bytes" << endl << sendbuf3 << endl << endl;
			continue;
		}

		if (s == "End of work")
		{
			char sendbuf1[MAX] = "Server EoW";
			iBytesSent = send(serverSocket, sendbuf1, MAX, 0);
			cout << "\nServer sent " << iBytesSent << " bytes" << endl;
			cout << sendbuf1 << endl;
			time(&rawtime);
			timeinfo = localtime(&rawtime);
			f << asctime(timeinfo);
			f << "Server sent " << iBytesSent << " bytes" << endl << sendbuf1 << endl << endl;
			break;
		}

		char sendbuf4[MAX] = "Wrong command";
		iBytesSent = send(serverSocket, sendbuf4, MAX, 0);
		cout << "\nServer sent " << iBytesSent << " bytes" << endl;
		cout << sendbuf4 << endl;
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "Server sent " << iBytesSent << " bytes" << endl << sendbuf4 << endl << endl;
	}

	if (closesocket(serverSocket) != 0)
	{
		cout << "ERROR: socket is not closed";
		time(&rawtime);
		timeinfo = localtime(&rawtime);
		f << asctime(timeinfo);
		f << "ERROR: socket is not closed";
		return 1;
	}
	WSACleanup();
	time(&rawtime);
	timeinfo = localtime(&rawtime);
	f << asctime(timeinfo) << "Server END\n\n";
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
