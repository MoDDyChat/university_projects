using System;
using System.Diagnostics;

namespace OOP_Lab33
{
    class Program
    {
        static void menu(Storage<Shape> shapes)
        {
            bool stop = false;
            int choice;
            do
            {
                Console.WriteLine("1: Вставить объект в хранилище");
                Console.WriteLine("2: Удалить объект из хранилища");
                Console.WriteLine("3: Вызвать функции объекта по номеру");
                Console.WriteLine("4: Получить информацию о объекте по номеру");
                Console.WriteLine("5: Узнать количество элементов в хранилище");
                Console.WriteLine("6: Протестировать хранилище");
                Console.WriteLine("7: Завершить программу");
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Выберете тип добавляемого объекта: ");
                            Console.WriteLine("1. Круг");
                            Console.WriteLine("2. Квадрат");
                            int figure = Int32.Parse(Console.ReadLine());

                            Console.Clear();
                            Console.WriteLine("По какому номеру вставить объект? - ");
                            int index = Int32.Parse(Console.ReadLine());
                            if (index > shapes.Count)
                                index = shapes.Count + 1;

                            if (figure == 1)
                                shapes.Insert(new Circle(), index);
                            else
                                shapes.Insert(new Square(), index);

                            Console.Clear();
                            Console.WriteLine(String.Format("Объект успешно добавлен в хранилище под номеру: {0}!", index));
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("По какому номеру удалить объект? - ");
                            int index = Int32.Parse(Console.ReadLine());
                            shapes.Remove(index);
                            Console.WriteLine(String.Format("Объект по номеру {0} был успешно удалён!", index));
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("По какому номеру вызвать функцию? - ");
                            int index = Int32.Parse(Console.ReadLine());
                            if (shapes.getObjectByIndex(index) is Circle c)
                            {
                                Console.Clear();
                                Console.WriteLine("Это объект типа Circle \n \n ");
                                Console.WriteLine("Выберете операцию: ");
                                Console.WriteLine("1. Передвинуть фигуру");
                                Console.WriteLine("2. Изменить радиус");
                                int ch = Int32.Parse(Console.ReadLine());
                                if (ch == 1)
                                {
                                    Console.WriteLine("\nВведите две изменяемые координаты через пробел: ");
                                    int dx = Int32.Parse(Console.ReadLine());
                                    int dy = Int32.Parse(Console.ReadLine());
                                    c.moveShape(dx, dy);
                                    Console.WriteLine("\nФигура успешно передвинута! Новые координаты: " + c.X + " " + c.Y);
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else if (ch == 2)
                                {
                                    Console.WriteLine("\nВведите разницу нового радиуса ");
                                    int dr = Int32.Parse(Console.ReadLine());
                                    c.changeRadius(dr);
                                    Console.WriteLine("\nРадиус фигуры изменён! Новый радиус: " + c.Radius);
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else if (shapes.getObjectByIndex(index) is Square s)
                            {
                                Console.Clear();
                                Console.WriteLine("Это объект типа Square \n \n ");
                                Console.WriteLine("Выберете операцию: ");
                                Console.WriteLine("1. Передвинуть фигуру");
                                Console.WriteLine("2. Изменить длину");
                                int ch = Int32.Parse(Console.ReadLine());
                                if (ch == 1)
                                {
                                    Console.WriteLine("\nВведите две изменяемые координаты через пробел: ");
                                    int dx = Int32.Parse(Console.ReadLine());
                                    int dy = Int32.Parse(Console.ReadLine());
                                    s.moveShape(dx, dy);
                                    Console.WriteLine("\nФигура успешно передвинута! Новые координаты: " + s.X + " " + s.Y);
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else if (ch == 2)
                                {
                                    Console.WriteLine("\nВведите разницу новой длины ");
                                    int dl = Int32.Parse(Console.ReadLine());
                                    s.changeRadius(dl);
                                    Console.WriteLine("\nДлина фигуры изменена. Новая длина: " + s.Length);
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("По какому номеру получить информацию? ");
                            int index = Int32.Parse(Console.ReadLine());
                            if (index > shapes.Count)
                            {
                                Console.WriteLine("Вы вышли за пределы списка!");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            Shape currentShape = shapes.getObjectByIndex(index);
                            if (currentShape is Circle c)
                                Console.WriteLine(String.Format("Это объект Circle, координаты X: {0}, Y: {1}", currentShape.X, currentShape.Y));
                            else if (shapes.getObjectByIndex(index) is Square s)
                                Console.WriteLine(String.Format("Это объект Square, координаты X: {0}, Y: {1}", currentShape.X, currentShape.Y));
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 5:
                        Console.Clear();
                        Console.WriteLine(String.Format("В хранилище {0} элементов", shapes.Count));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        {
                            var stopWatch = Stopwatch.StartNew();
                            //var date1 = new DateTime();
                            var rand = new Random();
                            Storage<Shape> shapes1 = new Storage<Shape>();
                            for (int i = 0; i < 1000000; i++)
                            {
                                switch (rand.Next(0, 2))
                                {
                                    case 0:
                                        int figure = rand.Next(0, 1);
                                        if (figure == 1)
                                            shapes1.AddLast(new Square());
                                        else
                                            shapes1.AddLast(new Circle());
                                        break;
                                    case 1:
                                        shapes1.Remove(rand.Next(0, shapes1.Count));
                                        break;
                                    case 2:
                                        if (shapes1.getObjectByIndex(rand.Next(0, shapes1.Count)) is Circle c)
                                            c.changeRadius(rand.Next(0, 100));
                                        else if (shapes1.getObjectByIndex(rand.Next(0, shapes1.Count)) is Square s)
                                            s.changeLength(rand.Next(0, 100));
                                        break;
                                }
                            }
                            
                            Console.WriteLine(String.Format("Тестирование завершено! "));
                            Console.WriteLine("Это заняло: " + stopWatch.ElapsedMilliseconds + " миллисекунд");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        
                    case 7:
                        stop = true;
                        break;
                }
            } while (!stop);
        }
        
        static void generateRandomStorage(Storage<Shape> shapes)
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int figure = rand.Next(1, 3);
                if (figure == 1)
                {
                    shapes.AddLast(new Square());
                    shapes.Current().X = rand.Next(0, 100);
                    shapes.Current().Y = rand.Next(0, 100);
                    shapes.Current().changeLength(rand.Next(0, 100));
                    if (rand.Next(0, 2) == 1)
                        shapes.Current().moveShape(rand.Next(0, 100), rand.Next(0, 100));
                }
                else
                {
                    shapes.AddLast(new Circle());
                    shapes.Current().X = rand.Next(0, 100);
                    shapes.Current().Y = rand.Next(0, 100);
                    shapes.Current().changeRadius(rand.Next(0, 100));
                    if (rand.Next(0, 2) == 1)
                        shapes.Current().moveShape(rand.Next(0, 100), rand.Next(0, 100));
                }
            }
        }

        static void Main(string[] args)
        {
            Storage<Shape> shapes = new Storage<Shape>();
            generateRandomStorage(shapes);
            menu(shapes);

            Console.ReadKey();
        }
    }   
}