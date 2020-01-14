#include <iostream>
#include "conio.h"

using namespace std;

class Processor {
protected:
	double speed;
	bool isBoost;
public:
	string company;

	//Конструктор без параметров
	Processor() {
		speed = 0.0;
		isBoost = false;
		company = "intel";
		printf("Вызван конструктор Processor() \n");
	}

	//Конструктор с параметрами
	Processor(double speed, bool isBoost, string company) {
		this->speed = speed;
		this->isBoost = isBoost;
		this->company = company;
		printf("Вызван конструктор с параметрами Processor(double speed, bool isBoost, string company) \n");
	}

	//Копирующий конструктор
	Processor(const Processor &p) {
		this->speed = p.speed;
		this->isBoost = p.isBoost;
		this->company = p.company;
		printf("Вызван копирующий конструктор Processor(const Processor &p) \n");
	}

	//Деструктор класса
	~Processor() {
		printf("Вызван деструктор класса ~Processor(): Частота: %.1f ГГц, Разгон: %s, Про-во: %s \n", speed, isBoost ? "присутствует" : "отсутствует", company.c_str());
	}

	//Функция перемещения фигуры
	void ChangeSpeed(double newSpeed) {
		this->speed = newSpeed;
	}
	//Функция установки координат
	void ChangeBoostCap(bool isBoost);
};

void Processor::ChangeBoostCap(bool isBoost) {
	isBoost = isBoost;
}

class VideoProcessor: public Processor {
protected:
	int videoMemory;
	int coolerCount;
public:
	//Конструктор без параметров
	VideoProcessor() : Processor() {
		videoMemory = 0;
		coolerCount = 0;
		company = "nvidia";
		printf("Вызван конструктор VideoProcessor() \n");
	}

	//Конструктор с параметрами
	VideoProcessor(double speed, bool isBoost, string company, int videoMemory, int coolerCount) : Processor(speed, isBoost, company) {
		this->videoMemory = videoMemory;
		this->coolerCount = coolerCount;
		printf("Вызван конструктор с параметрами VideoProcessor(double speed, bool isBoost, string company, int videoMemory, int coolerCount) \n");
	}

	//Копирующий конструктор
	VideoProcessor(const VideoProcessor &g) {
		this->speed = g.speed;
		this->isBoost = g.isBoost;
		this->company = g.company;
		this->videoMemory = g.videoMemory;
		this->coolerCount = g.coolerCount;
		printf("Вызван копирующий конструктор VideoProcessor(const VideoProcessor &g) \n");
	}

	//Деструктор класса
	~VideoProcessor() {
		printf("Вызван деструктор класса ~VideoProcessor(): Частота: %.1f ГГц, Разгон: %s, Про-во: %s, Видеопамять: %d, Кулеров: %i \n", speed, isBoost ? "присутствует" : "отсутствует", company.c_str(), videoMemory, coolerCount);
	}

	void ChangeCoolerCount(int coolerCount) {
		this->coolerCount = coolerCount;
	}
};

class Computer {
protected:
	Processor* CPU;
	VideoProcessor* GPU;
public:
	Computer() {
		printf("Вызван конструктор Computer() \n");
		CPU = new Processor;
		GPU = new VideoProcessor;
	}
	Computer(double cpuSpeed, double gpuSpeed, bool cpuBoost, bool gpuBoost, string cpuCompany, string gpuCompany, int videoMemory, int coolerCount) {
		printf("Вызван конструктор Computer(double speed, bool isBoost, string company, int videoMemory, int coolerCount) \n");
		CPU = new Processor(cpuSpeed, cpuBoost, cpuCompany);
		GPU = new VideoProcessor(gpuSpeed, gpuBoost, gpuCompany, videoMemory, coolerCount);
	}
	Computer(const Computer& c) {
		printf("Вызван конструктор Computer(const Computer& c) \n");
		CPU = new Processor((c.CPU));
		//CPU = *(c.CPU)
		GPU = new VideoProcessor(*(c.GPU));
	}
	~Computer() {
		printf("Вызван деструктор класса ~Computer() \n");
		delete CPU;
		delete GPU;
	}
};

int main() {
	setlocale(LC_ALL, "Russian");
	{
		Processor c1(3.4, true, "amd");
		c1.ChangeBoostCap(false);
		c1.ChangeSpeed(3.6);
		c1.company = "intel";
		Processor c2(c1);
		c2.company = "amd";

		printf("\n");

		//Помещение объекта класса VideoProcessor в переменную типа Processor
		Processor* g1 = new VideoProcessor(); 
		//Из g1 мы не можем обратиться к методам класса VideoProcessor

		printf("\n");

		Computer *comp1 = new Computer(2.6, 2.7, true, false, "intel", "nvidia", 4096, 3);
		Computer *comp2 = new Computer(*comp1);

		printf("\n");

		delete g1;
		delete comp1;
		delete comp2;
	}
	_getch();
	return 0;
}