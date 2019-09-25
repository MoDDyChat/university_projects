#include <stdio.h>
#include <iostream>
#define M 3
int numberOfSteps(int x, int y, int A[M][M]);
void printArray(int A[M][M]);
int offset[8][2];

int main()
{
	setlocale(LC_CTYPE, "");
	int A[M][M];
	int steps[8];
	int x = 3, y = 3, count = 1, idx = 0;
	std::cout << "введите х" << std::endl;
	std::cin >> x;
	std::cout << "введите y" << std::endl;
	std::cin >> y;

	offset[0][0] = 2; offset[0][1] = 1;
	offset[1][0] = 2; offset[1][1] = -1;
	offset[2][0] = 1; offset[2][1] = 2;
	offset[3][0] = 1; offset[3][1] = -2;
	offset[4][0] = -1; offset[4][1] = 2;
	offset[5][0] = -1; offset[5][1] = -2;
	offset[6][0] = -2; offset[6][1] = 1;
	offset[7][0] = -2; offset[7][1] = -1;
	for (int i = 0; i < M; i++) {
		for (int j = 0; j < M; j++) {
			A[i][j] = 0;
		}
	}
	A[x][y] = count;

	do {
		for (int k = 0; k < 8; k++) {
			steps[k] = numberOfSteps(x + offset[k][0], y + offset[k][1], A);
		}
		for (int k = 0; k < 8; k++) {
			if (steps[k] > 0) {
				idx = k;
				break;
			}
			if (k == 7) {
				for (int i = 0; i < 8; i++) {
					if (steps[i] == 0) {
						A[x + offset[i][0]][y + offset[i][1]] = ++count;
					}
				}
				printArray(A);
				return 0;
			}
		}
		for (int k = 0; k < 8; k++) {
			if (steps[k] < steps[idx] && steps[k]>0) {
				idx = k;
			}
		}

		x += offset[idx][0];
		y += offset[idx][1];
		A[x][y] = ++count;

	} while (true);
	return 0;
}

int numberOfSteps(int x, int y, int A[M][M])
{
	if ((x < 0 || x >= M || y < 0 || y >= M || A[x][y] != 0)) {
		return -1;
	}
	int count = 0;
	for (int k = 0; k < 8; k++) {
		int xn = x + offset[k][0];
		int yn = y + offset[k][1];
		if (xn >= 0 && xn < M && yn >= 0 && yn < M && A[xn][yn] == 0) {
			count++;
		}
	}
	return count;
}

void printArray(int A[M][M])
{
	for (int i = 0; i < M; i++) {
		for (int j = 0; j < M; j++) {
			printf("%4d", A[i][j]);
		}
		printf("\n");
	}
	system("pause");
}