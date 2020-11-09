#include <iostream>
using namespace std;

class Plane {
public:
	virtual ~Plane() {};
	virtual void createPlane() const = 0;
};

class BigPlane : public Plane {
public:
	void createPlane() const override {
		cout << "Создан большой самолёт" << endl;
	}
};

class SmallPlane : public Plane {
public:
	void createPlane() const override {
		cout << "Создан маленький самолёт" << endl;
	}
};

class Car {
public:
	virtual ~Car() {};
	virtual void createCar() const = 0;
};

class BigCar : public Car {
	void createCar() const override {
		cout << "Создан большой автомобиль" << endl;
	}
};

class SmallCar : public Car {
	void createCar() const override {
		cout << "Создан маленький автомобиль" << endl;
	}
};

class TransportFactory {
public:
	virtual Plane* createPlane() const = 0;
	virtual Car* createCar() const = 0;
};

class SmallFactory : public TransportFactory {
	Plane* createPlane() const override {
		return new SmallPlane();
	}
	Car* createCar() const override {
		return new SmallCar();
	}
};

class BigFactory : public TransportFactory {
	Plane* createPlane() const override {
		return new BigPlane();
	}
	Car* createCar() const override {
		return new BigCar();
	}
};

int main()
{
	setlocale(LC_ALL, "ru");
	const TransportFactory* sf = new SmallFactory();
	const TransportFactory* bf = new BigFactory();

	Plane *smallPlane = sf->createPlane();
	Car* bigCar = bf->createCar();
	
}

