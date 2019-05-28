//задача о загрузке рюкзака
//дерео в глубину
#include <iostream>
#include <conio.h>

using namespace std;

int R = 1; // Размер рюкзака 
int a[] = { 8, 1, 6, 4, 5, 2, 9, 3, 7, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 25, 24 }; //массив размера вещей
const int sizeArray = sizeof(a) / sizeof(int);

int v[sizeArray] = { };
int best[100][sizeArray];
int kbest = 0;
int mx = 0;
int sum = 0;
int index = 0;
int stop = 0;

void mark();
void stepnext();
bool stepback();
void show();
void menu();

int main() {
	system("color 70");
	setlocale(LC_ALL, "Russian");
	
	menu();
	do {
		stepnext();
		mark();
	} while (stepback());
	show();

	_getch();
	return 0;
}

void mark() {

	if (sum > R || sum < mx) {
		return;
	}
	if (sum > mx) {
		mx = sum;
		kbest = 0;
	}

	if (kbest < 100) {
		for (int i = 0; i < sizeArray; i++)
			best[kbest][i] = v[i];
	}
	kbest++;
}

void stepnext() {

	for (int i = index; i < sizeArray; i++) {
		if (sum + a[i] <= R) {
			sum += a[i];
			v[i] = 1;
		}
		else 
			v[i] = 0;
	}
}

bool stepback() {

	if (v[sizeArray - 1]) {
		v[sizeArray - 1] = 0;
		sum -= a[sizeArray - 1];
	}
	for (int i = sizeArray - 2; i >= 0; --i) {
		if (v[i]) {
			sum -= a[i];
			v[i] = 0;
			index = i + 1;
			return 1;
		}
	}
	return 0;
}

void show() {
	cout << "Комбинации по весу:" << endl;
	for (int i = 0; i < (kbest <= 100 ? kbest : 100); i++) {
		for (int j = 0; j < sizeArray; j++) {
			if (best[i][j])
				cout << a[j] << ' ';
		}
		cout << endl;
	}
}

void menu() {
	do {
		cout << "Введите размер рюкзака:";
		cin >> R;
	} while (!R);
}

