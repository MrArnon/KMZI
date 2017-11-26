// KMZI_1.cpp : Defines the entry point for the console application.
//

// Polyakov_Kmzi_1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
#include "fstream"
#include<string.h>
#include<string>
#include <windows.h>
#include <cstring>
using namespace std;

int input (string& info,istream & fin) //ввод сообщения из файла или из консоли
{ 
	char b='9';

	while ((b != '1') && (b!='0') )	
	{cout<<"Для ввода из консоли введите 0 "<<endl;
	cout<<"Для ввода из файла введите 1 "<<endl;
	cin>>b;//scanf("%d", &b);
	}
	if (b == '0') { cout<<"Введите строку"<<endl; getline(cin, info); getline(cin, info); }//cin >> info;
	else { cout << "Введите строку" << endl; getline(fin, info); }
int a=info.length();
return a;
}
int proverka()
{
	int i=0;
	string s;
	cin >> s;
	i = atoi(s.c_str());
	if (i == 0) { cout << "Введены некорректные данные, повторите ввод "<<endl; proverka(); }
	else return i;

}

void otrezok (int dlina,int& x,int& y)//находим размеры матрицы исходя из длины текста
{y=int(pow(dlina,(0.5)));
x=y;
while (y*x <dlina)
	x++;
}
int chisla_deshifr(int dlina,int & x,int& y)
{
	int a, b;
	otrezok(dlina, x, y);
	static int i=3;
	if(i>0){
	cout << "Угадайте два числа c "<<i<<" попыток"<<endl;
	//cin >> a >> b;
	a=proverka();
	b = proverka();
	i--;
	if  (a*b==dlina){ 
		if(b>a) {x=b;y=a; return 0;}
		else {x=a;y=b; return 0;}
	}
	else chisla_deshifr(dlina, x, y);
	}
	//((a == x && b == y) || (a == y && b == x)) return 0;
	
if(i==0)return 1;
else return 0;
}
void vstavka(string &info, int raz ,int dlina)
{
	for (int i = 0; i < (raz-dlina); i++)
		info += '/';
}
bool reverse_str(int x,int *xper)
{
	bool b = true;
	cout << "Введите порядок перестановки от 1 до " << x << endl;
	int *a=new int[x];
	
	for (int i = 0; i < x; i++)
		a[i] = 0;
	for (int i = 0; i < x; i++)
	{
		int temp=0;
		temp=proverka();
		//cin >> temp;
		xper[i] = temp;
		if (temp>=1 && temp<=x) a[(temp-1)]+=1 ;
	}
	int i = 0;
	while (b && i<x)
	{
		b = (a[i] == 1);
		i++;
	}
	delete[] a;
	if (b) return true;
	else {
		cout << "Вы неправильно ввели перестановку"<<endl;
		reverse_str(x, xper);
	} 
	
}
void vivid(int x, int y, char **matr)
{
	for (int i = 0; i < x; i++)
	{
		for (int j = 0; j < y; j++)

			cout << matr[j][i] <<"  ";
		cout << endl;
	}


}
void shifr(string info,int dlina, int* xper, int x,int y, char **matr)
{
	
	int k = 0;
	for (int i = 0; i < x; i++)
		for (int j = 0; j < y; j++)
		{
			matr[j][xper[i]-1] = info[k];
			k++;
			//vivid(x, y, matr);
			//cout << endl;
		}
	
}
void deshifr(string info, int dlina, int* yper, int x, int y, char **matr)
{
	int k = 0;
	for (int i = 0; i < y; i++)
		for (int j = 0; j < x; j++)
		{
			matr[yper[i] - 1][j] = info[k];
			k++;
			//vivid(x, y, matr);
			//cout << endl;
		}
}
void n_output(char **matr, int x, int y, int*xper, ofstream & fout)
{
	string n_info;
	
	for (int i = 0; i < x; i++)
		for (int j = 0; j < y; j++)
		{
			n_info += matr[j][xper[i] - 1];
			
		}
	int i = n_info.length()-1;
	while (n_info[i]=='/')
	{
		n_info.pop_back();
		i--;
	}
	cout << endl << n_info << endl;
	fout << n_info;
}

void output(char **matr,int x,int y,int*yper, ofstream & fout) //считывание уже зашифрованного сообщения из файла или консоли
{
	string n_info;
	
	for (int i = 0; i < y; i++)
		for (int j = 0; j < x; j++)
		{
			n_info += matr[yper[i]-1][j];
			
		}
	cout <<endl<< n_info<<endl;
	fout << n_info;
}
char** create_matr(int x,int y)
{
	char **matr = new char*[y]; // Создаем массив указателей
	for (int i = 0; i < y; i++)
	{
		matr[i] = new char[x]; // Создаем элементы
	}
	for (int i = 0; i < y; i++)

		for (int j = 0; j < x; j++)
			matr[i][j] = '1';

	return matr;
}
void destroy_matr(char**matr, int y)
{
	// Удаление массива
	for (int i = 0; i < y; i++)
	{
		delete matr[i]; // Удаляем каждый элемент
	}
	delete  matr; // А потом массив
}
int _tmain(int argc, _TCHAR* argv[])
{
setlocale(LC_ALL, "rus");
SetConsoleCP(1251);
SetConsoleOutputCP(1251);

ifstream fin("file1.txt");
ofstream fout("file2.txt");
int chislo=-1;
while((chislo != 1) && (chislo!=2) ) //меню для выбора работы программы
{cout<<"Для шифрования введите 1 "<<endl;
cout<<"Для расшифровки введите 2 "<<endl;
//cin>>chislo;
chislo=proverka();
}
string info;
int dlina=0;
int x = 0; int y = 0;
switch (chislo)
{case 1: 
	{dlina=input(info,fin);
	otrezok(dlina,x,y);
	vstavka(info, x*y,dlina);
	int *xper=new int[x];
	int *yper= new int[y];
	reverse_str(x, xper);
	reverse_str(y, yper);
	char **matr;
	matr=create_matr( x, y);
	shifr(info, dlina, xper, x, y, matr);
	output(matr, x, y, yper, fout);
	delete[] xper;
	delete[] yper;
	destroy_matr(matr, y);
     break;}
case 2:{dlina=input(info,fin);
	otrezok(dlina, x, y);
	if (chisla_deshifr(dlina, x, y)==1) {cout<<"Попытки закончились"<<endl;break;}
	int *xper = new int[x];
	int *yper = new int[y];
	reverse_str(x, xper);
	reverse_str(y, yper);
	char **matr;
	matr=create_matr( x, y);
	deshifr(info, dlina, yper, x, y, matr);
	n_output(matr, x, y, xper, fout);
	delete[] xper;
	delete[] yper;
	destroy_matr(matr, y);
	break;}
}

fin.close();
fout.close();
system("pause");
	return 0;
}



