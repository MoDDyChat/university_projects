#include <iostream>
#include "conio.h"

using namespace std;

class Processor {
protected:
	double speed;
	bool isBoost;
public:
	string company;

	//����������� ��� ����������
	Processor() {
		speed = 0.0;
		isBoost = false;
		company = "intel";
		printf("������ ����������� Processor() \n");
	}

	//����������� � �����������
	Processor(double speed, bool isBoost, string company) {
		this->speed = speed;
		this->isBoost = isBoost;
		this->company = company;
		printf("������ ����������� � ����������� Processor(double speed, bool isBoost, string company) \n");
	}

	//���������� �����������
	Processor(const Processor &p) {
		this->speed = p.speed;
		this->isBoost = p.isBoost;
		this->company = p.company;
		printf("������ ���������� ����������� Processor(const Processor &p) \n");
	}

	//���������� ������
	~Processor() {
		printf("������ ���������� ������ ~Processor(): �������: %.1f ���, ������: %s, ���-��: %s \n", speed, isBoost ? "������������" : "�����������", company.c_str());
	}

	//������� ����������� ������
	void ChangeSpeed(double newSpeed) {
		this->speed = newSpeed;
	}
	//������� ��������� ���������
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
	//����������� ��� ����������
	VideoProcessor() : Processor() {
		videoMemory = 0;
		coolerCount = 0;
		company = "nvidia";
		printf("������ ����������� VideoProcessor() \n");
	}

	//����������� � �����������
	VideoProcessor(double speed, bool isBoost, string company, int videoMemory, int coolerCount) : Processor(speed, isBoost, company) {
		this->videoMemory = videoMemory;
		this->coolerCount = coolerCount;
		printf("������ ����������� � ����������� VideoProcessor(double speed, bool isBoost, string company, int videoMemory, int coolerCount) \n");
	}

	//���������� �����������
	VideoProcessor(const VideoProcessor &g) {
		this->speed = g.speed;
		this->isBoost = g.isBoost;
		this->company = g.company;
		this->videoMemory = g.videoMemory;
		this->coolerCount = g.coolerCount;
		printf("������ ���������� ����������� VideoProcessor(const VideoProcessor &g) \n");
	}

	//���������� ������
	~VideoProcessor() {
		printf("������ ���������� ������ ~VideoProcessor(): �������: %.1f ���, ������: %s, ���-��: %s, �����������: %d, �������: %i \n", speed, isBoost ? "������������" : "�����������", company.c_str(), videoMemory, coolerCount);
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
		printf("������ ����������� Computer() \n");
		CPU = new Processor;
		GPU = new VideoProcessor;
	}
	Computer(double cpuSpeed, double gpuSpeed, bool cpuBoost, bool gpuBoost, string cpuCompany, string gpuCompany, int videoMemory, int coolerCount) {
		printf("������ ����������� Computer(double speed, bool isBoost, string company, int videoMemory, int coolerCount) \n");
		CPU = new Processor(cpuSpeed, cpuBoost, cpuCompany);
		GPU = new VideoProcessor(gpuSpeed, gpuBoost, gpuCompany, videoMemory, coolerCount);
	}
	Computer(const Computer& c) {
		printf("������ ����������� Computer(const Computer& c) \n");
		CPU = new Processor(*(c.CPU));
		GPU = new VideoProcessor(*(c.GPU));
	}
	~Computer() {
		printf("������ ���������� ������ ~Computer() \n");
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

		//��������� ������� ������ VideoProcessor � ���������� ���� Processor
		Processor* g1 = new VideoProcessor(); 
		//�� g2 �� �� ����� ���������� � �������� ������ VideoProcessor

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