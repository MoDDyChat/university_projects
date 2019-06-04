//задача о загрузке рюкзака
//дерео в глубину
#include <iostream>
#include <conio.h>

using namespace std;

int R = 1; // Размер рюкзака 
int mode = 0; //Метод подбора
int a[] = { 8, 1, 6, 4, 5, 2, 9, 3, 7, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 25, 24 }; //массив размера вещей
const int sizeArray = sizeof(a) / sizeof(int); //размер массива

int v_1[sizeArray] = { };
int best_1[100][sizeArray];

int v_2[sizeArray] = { };
int best_2[100][sizeArray];

int kbest = 0;
int mx = 0;
int sum = 0;
int index = 0;
int stop = 0;
bool c = false;

void mode1();
void mode2();
void mode3();
void mark1();
void mark2();
void stepnext();
bool stepback();
int next();
void show();
void menu();

int main() {
	system("color 70");
	setlocale(LC_ALL, "Russian");
	
	menu();
	
	if (mode == 1)
		mode1();
	else if (mode == 2)
		mode2();
	else if (mode == 3)
		mode3();
		
	system("pause");
	return 0;
}

void mode1() {
	do {
		stepnext();
		mark1();
	} while (stepback());
	show();
}

void mode2() {
	do {
		mark2();
	} while (next());
	show();
}

void mode3() {
	mode = 1;
	mode1();

	cout << endl;

	int kbest = 0;
	int mx = 0;
	int sum = 0;
	int index = 0;
	int stop = 0;

	mode = 2;
	mode2();
}

void mark1() {

	if (sum > R || sum < mx) {
		return;
	}
	if (sum > mx) {
		mx = sum;
		kbest = 0;
	}
	if (kbest < 100) {
		for (int i = 0; i < sizeArray; i++)
			best_1[kbest][i] = v_1[i];
	}
	kbest++;
}

void stepnext() {

	for (int i = index; i < sizeArray; i++) {
		if (sum + a[i] <= R) {
			sum += a[i];
			v_1[i] = 1;
		}
		else 
			v_1[i] = 0;
	}
}

bool stepback() {

	if (v_1[sizeArray - 1]) {
		v_1[sizeArray - 1] = 0;
		sum -= a[sizeArray - 1];
	}
	for (int i = sizeArray - 2; i >= 0; --i) {
		if (v_1[i]) {
			sum -= a[i];
			v_1[i] = 0;
			index = i + 1;
			return 1;
		}
	}
	return 0;
}

void mark2() {
	int sum = 0;
	for (int i = 0; i < sizeArray; ++i)
		if (v_2[i])
			sum += a[i];
	if (sum > R || sum < mx) return;
	if (sum > mx) {
		mx = sum;
		kbest = 0;
	}
	if (kbest < 100)
		for (int i = 0; i < sizeArray; ++i)
			best_2[kbest][i] = v_2[i];
	kbest++;
}

int next() {
	for (int i = sizeArray - 1; i >= 0; i--) {
		if (v_2[i])
			v_2[i] = 0;
		else {
			v_2[i] = 1;
			return 1;
		}
	}
	return 0;
}

void show() {
	cout << "Подборка для метода ";
	mode == 1 ? cout << "1: " << endl : cout << "2: " << endl;
	for (int i = 0; i < (kbest <= 100 ? kbest : 100); i++) {
		for (int j = 0; j < sizeArray; j++) {
			if (mode == 1) {
				if (best_1[i][j]) {
					c = true;
					cout << a[j] << ' ';
				}
			}
			if (mode == 2) {
				if (best_2[i][j]) {
					c = true;
					cout << a[j] << ' ';
				}
			}
		}
		if (c == true) {
			cout << endl;
			c = false;
		}
	}
}

void menu() {
	do {
		cout << "1 - Первый метод" << endl << "2 - Второй метод" << endl << "3 - Оба метода" << endl << endl;
		cout << "Какой метод выбрать?: ";
		cin >> mode;
		system("cls");
	} while (mode != 1 && mode != 2 && mode != 3);
	do {
		cout << "Введите размер рюкзака: ";
		cin >> R;
	} while (!R);
	cout << endl;
}

