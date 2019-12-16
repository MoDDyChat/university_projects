using System;

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
                Console.WriteLine("3: Добавить объект в конец хранилища");
                Console.WriteLine("4: Получить информацию о объекте по индексу");
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
                            Console.WriteLine("По какому индексу вставить объект? - ");
                            int index = Int32.Parse(Console.ReadLine());
                            if (index > shapes.Count)
                                index = shapes.Count + 1;

                            if (figure == 1)
                                shapes.Insert(new Circle(), index);
                            else
                                shapes.Insert(new Square(), index);

                            Console.Clear();
                            Console.WriteLine(String.Format("Объект успешно добавлен в хранилище под индексом: {0}!", index));
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("По какому индексу удалить объект? - ");
                            int index = Int32.Parse(Console.ReadLine());
                            shapes.Remove(index);
                            Console.WriteLine(String.Format("Объект по индексу {0} был успешно удалён!", index));
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Выберете тип добавляемого объекта: ");
                            Console.WriteLine("1. Круг");
                            Console.WriteLine("2. Квадрат");
                            int figure = Int32.Parse(Console.ReadLine());
                            if (figure == 1)
                                shapes.AddLast(new Circle());
                            else
                                shapes.AddLast(new Square());
                            Console.Clear();
                            Console.WriteLine("Объект успешно добавлен в хранилище!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("По какому индексу получить информацию? ");
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
                            //var date1 = new DateTime();
                            var rand = new Random();
                            Storage<Shape> shapes1 = new Storage<Shape>();
                            for (int i = 0; i < 10000; i++)
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
                            //var date2 = new DateTime();
                            //TimeSpan interval = date2 - date1;
                            Console.WriteLine(String.Format("Тестирование завершено! "));
                            //Console.WriteLine("Это заняло: ", interval.Ticks);
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