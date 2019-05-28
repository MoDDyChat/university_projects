#include <iostream>
#include <conio.h>

using namespace std;

const int N = 5;
int a[N][N] = { {0, 2, 0, 4, 0}, {1, 0, 3, 5, 0}, {0, 3, 0, 2, 0}, {0, 7, 2, 0, 0}, {5, 3, 6, 0, 0} };
int b[N][N];
int in, out;
int len;

void way(int i, int j);
void findMin();
void menu();
void bCopy();

int main(){
	system("color 70");
	setlocale(LC_ALL, "Russian");

	bCopy();
	menu();
	findMin();
	way(in, out);
	
	system("pause");
	return 0;
}

void menu() {
	do {
		system("cls");
		cout << "Введите начальную точку пути (< " << N << "): ";
		cin >> in;
	} while (in >= N);

	do {
		system("cls");
		cout << "Введите конечную точку пути (< " << N << "): ";
		cin >> out;
	} while (out >= N);
}

void bCopy() {
	for (int i = 0; i < N; ++i) {
		for (int j = 0; j < N; ++j) {
			b[i][j] = a[i][j];
		}
	}
}

void findMin() {
	while (true) {
		int flag = 1;
		for (int i = 0; i < N; ++i) 
			for (int j = 0; j < N; ++j)
				if (i != j && b[i][j]) 
					for (int k = 0; k < N; ++k) 
						if (k != i && k != j && b[j][k])
							if (b[i][k] == 0 || b[i][k] > b[i][j] + b[j][k]) {
								b[i][k] = b[i][j] + b[j][k];
								flag = 0;
							}
		if (flag) {
			break;
		}
	}
}

void way(int io, int jo) {
	cout << io << " --> ";
	len = b[io][jo];

	while (a[io][jo] != b[io][jo]) {
		for (int i = 0; i < N; ++i) {
			if (i != io && i != jo && a[io][i] && b[i][io] && b[io][jo] == a[io][i] + b[i][jo]) {
				cout << i << " --> ";
				io = i;
				break;
			}
		}
		
	}
	cout << jo << endl;
	if (!len) {
		cout << "Нет пути" << endl << endl;
	}
	else {
		cout << "Длина пути: " << len << endl << endl;
	}
	
}