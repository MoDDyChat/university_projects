#include <iostream>
#include <locale>
using namespace std;


class Shape
{
public:
	int x, y;

	Shape() {
		cout << "Shape()" << endl;
		x = 0;
		y = 0;
	}
	Shape(Shape* shape) {
		cout << "Shape(Shape* shape)" << endl;
		x = shape->x;
		y = shape->y;
	}
	Shape(Shape& shape) {
		cout << "Shape(Shape& shape)" << endl;
		x = shape.x;
		y = shape.y;
	}

	virtual ~Shape() {
		cout << "Вызван деструктор Shape" << endl;
	}

	void PrintInfo() {
		printf("Shape { x = %d, y = %d }\n", this->x, this->y);
	}

	virtual string ClassName() {
		return "Shape";
	}

	virtual bool isA(string className) {
		return className == ClassName();
	}
};

class Square : public Shape
{
public:
	int width;
	Square() {
		cout << "Square()" << endl;
		x = 0;
		y = 0;
		width = 0;
	}
	Square(Square* square) {
		cout << "Square(Square* square)" << endl;
		x = square->x;
		y = square->y;
		width = square->width;
	}
	Square(Square& square) {
		cout << "Square(Square& square)" << endl;
		x = square.x;
		y = square.y;
		width = square.width;
	}

	virtual ~Square() override { //перекрывает
		cout << "Вызван деструктор Square" << endl;
	}

	void PrintInfo() { //переопределяет метод родителя
		printf("Square { x = %d, y = %d, width = %d }\n", this->x, this->y, this->width);
	}

	virtual string ClassName() override { //перекрывает
		return "Square";
	}

	virtual bool isA(string className) override { //перекрывает
		return className == ClassName() || Shape::isA(className);
	}

	int GetArea() {
		return width * width;
	}
};

class TestFunction
{
public:
	//передается объект полностью
	void testFunc1(Shape shape, int dx, int dy) {
		printf("testFunc1(Shape) x = %d, y=%d, dx=%d, dy=%d\n", shape.x, shape.y, dx, dy);
		shape.x += dx;
		shape.y += dy;
	}
	//передается указатель на объект
	void testFunc2(Shape* shape, int dx, int dy) {
		printf("testFunc2(Shape*) x = %d, y=%d, dx=%d, dy=%d\n", shape->x, shape->y, dx, dy);
		shape->x += dx;
		shape->y += dy;
	}
	//передаётся адрес на объект
	void testFunc3(Shape& shape, int dx, int dy) {
		printf("testFunc3(Shape&) x = %d, y=%d, dx=%d, dy=%d\n", shape.x, shape.y, dx, dy);
		shape.x += dx;
		shape.y += dy;
	}
};



int main() {
	setlocale(LC_ALL, "Rus");

	cout << endl << "КОНСТРУКТОРЫ / ДЕСТРУКТОРЫ:" << endl << endl;
	{
		Shape s1;
		Square sq1;

		Shape* s2 = new Square(sq1);
		Shape s3(s1);

		delete s2;
	}

	Square* sq1 = new Square();
	sq1->x = 10;
	Shape* s1 = new Square();
	s1->x = 10;

	sq1->PrintInfo();
	s1->PrintInfo(); //Мы не перекрыли, а переопределили метод, а потому вызывается метод предка

	delete sq1;
	delete s1;

	cout << endl << endl << "ПЕРЕДАЧА ОБЪЕКТОВ В ФУНКЦИИ:" << endl << endl;

	{
		Shape s2;
		s2.x = 50;
		s2.y = 50;
		s2.PrintInfo();
		cout << endl;

		TestFunction testFunction;
		testFunction.testFunc1(s2, 100, 100); //копируем объект
		s2.PrintInfo(); //50, 50
		cout << endl;

		testFunction.testFunc2(&s2, 100, 100); //передаём указатель на объект
		s2.PrintInfo(); //150, 150
		cout << endl;

		testFunction.testFunc3(s2, 100, 100); //передаём сам объект
		s2.PrintInfo(); //250, 250
		cout << endl;
	}

	cout << endl << endl << "ПРИВЕДЕНИЕ ТИПОВ:" << endl << endl;

	Shape* DoubleSquare = new Square();

	if (DoubleSquare->isA("Square")) {
		((Square*)DoubleSquare)->width = 16;
		cout << "1) Площадь квадрата = " << ((Square*)DoubleSquare)->GetArea() << endl;
	}

	Square* TripleSquare = dynamic_cast<Square*>(DoubleSquare);
	if (TripleSquare) // Нет ошибки
	{
		TripleSquare->width = 17;
		cout << "2) Площадь квадрата = " << TripleSquare->GetArea() << endl;
	}


	cout << "Конец программы" << endl;
	delete DoubleSquare;
}