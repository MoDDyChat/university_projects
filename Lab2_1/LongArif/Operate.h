#include <iostream>
#include <windows.h>

using namespace std;
const int N = 10000;

//Поменять знак
void changeSign(char a[]) {
	for (int i = 0; i < N; ++i)
		a[i] = 9 - a[i];
	for (int i = 0; i < N; ++i)
		if (a[i] == 9)
			a[i] = 0;
		else {
			a[i]++;
			break;
		}
}

//Ввод числа
void input(char a[]) {
	char str[N + 2];
	cin.getline(str, N + 2);
	int sign = 1, start = 0;
	if (str[0] == '+' || str[0] == '-') {
		start = 1;
		sign = (str[0] == '+' ? 1 : -1);
	}
	int i = strlen(str) - 1;
	int j = 0;
	for (; i >= start; i--) {
		a[j++] = str[i] - '0';
	}
	for (; j < N; j++)
		a[j] = 0;
	if (sign == -1)
		changeSign(a);
}

//Вывод числа
void output(char a[]) {
	int sign = 1;
	if (a[N - 1] >= 5) {
		sign = -1;
		printf("-");
		changeSign(a);
	}
	int i = N - 1;
	for (; i > 0 && a[i] == 0; --i)
		;
	for (; i >= 0; --i)
		printf("%i", a[i]);
	printf("\n");
}

//Сложение
void add(char imb[], char a[], char b[]) {
	int r = 0;
	for (int i = 0; i < N; ++i) {
		int t = a[i] + b[i] + r;
		imb[i] = t % 10;
		r = t / 10;
	}
}

//Вычитание
void sub(char imb[], char a[], char b[]) {
	changeSign(b);
	add(imb, a, b);
	changeSign(b);
}

//Умножение
void mult(char res[], char a[], char b[]) {
	for (int i = 0; i < N; ++i)
		res[i] = 0;
	for (int i = 0; i < N; ++i)
		for (int j = 0; i + j < N; ++j) {
			int t = a[i] * b[j] + res[i + j];
			res[i + j] = t % 10;
			res[i + j + 1] += t / 10;
		}
}

//Уменьшение на единицу
void decrease(char a[], char b[]) {
	for (int i = 0; i < N; i++) {
		if (a[i] >= b[i]) {
			a[i] -= b[i];
		}
		else {
			a[i] = 10 + a[i] - b[i];
			a[i + 1]--;
		}
	}
}

//Проверка на ноль
int checknull(char a[]) {
	for (int i = 0; i < N; i++) {
		if (a[i] != 0) return 0;
	}
	return 1;
}

//Сравнение чисел
int compare(char a[], char b[]) {
	char result1[N + 1] = { 0 };
	sub(result1, a, b);
	if (result1[N - 1] >= 5) return -1;
	else {
		for (int i = 0; i < N; i++) {
			if (result1[i] != 0) return 1;
		}
		return 0;
	}
}

//Деление
void degree(char res[], char a[], char b[]) {
	char t[N + 1] = { 0 };
	bool signA, signB;
	signA = signB = false;
	if (a[N - 1] >= 5) {
		signA = true;
		changeSign(a);
	}
	if (b[N - 1] >= 5) {
		signB = true;
		changeSign(b);
	}
	int lengthA = N - 1, lengthB = N - 1, lengthT = 0;
	for (; lengthA > 0 && a[lengthA] == 0; --lengthA)
		;
	for (; lengthB > 0 && b[lengthB] == 0; --lengthB)
		;
	lengthA++;
	lengthB++;
	while (lengthT < lengthA and compare(t, b) < 0) {
		for (int j = lengthT - 1; j >= 0; --j) {
			t[j + 1] = t[j];
		}
		t[0] = a[lengthA - lengthT - 1];
		lengthT++;
	}
	int lengthRes = 1;
	for (; lengthRes < N; lengthRes++) {
		while (compare(t, b) >= 0) {
			decrease(t, b);
			res[lengthRes - 1]++;
		}
		if (lengthA <= lengthT) break;
		for (int j = lengthT - 1; j >= 0; --j) {
			t[j + 1] = t[j];
		}
		t[0] = a[lengthA - lengthT - 1];
		lengthT++;
	}

	if (signA != signB and !checknull(res)) cout << "-";
	if (checknull(res)) cout << "0";
	else {
		for (int i = 0; i < lengthRes; i++) {
			cout << (int)res[i];
		}
	}
	cout << endl;
}