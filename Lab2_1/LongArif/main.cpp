#include "Operate.h"
#include <windows.h>
	
int stop;

void menu() {
	do {
		char b[N + 1], a[N + 1], result[N + 1] = { 0 };

		cout << "������� ������ �����: ";
		input(a);

		cout << "������� ������ �����: ";
		input(b);

		cout << endl <<"����� ���� ����� = ";
		add(result, a, b);
		output(result);

		cout << "�������� ���� ����� = ";
		sub(result, a, b);
		output(result);

		cout << "������������ ���� ����� = ";
		mult(result, a, b);
		output(result);

		for (int i = 0; i < N + 1; i++) result[i] = 0;
		cout << "������� ���� ����� = ";
		degree(result, a, b);

		cout << endl << "����� ���� ����� = ";
		add(result, a, b);
		output(result);

		cout << endl << "������� ����� ������, ����� ��������� ������: ";
		//degree(result, a, b);

		getchar() == '\n' ? stop = 0 : stop = 1;
		system("cls");
	} while (stop != 1);
}

int main() {
	setlocale(LC_ALL, "Russian");
	system("color 70");
	menu();
	return 0;
}