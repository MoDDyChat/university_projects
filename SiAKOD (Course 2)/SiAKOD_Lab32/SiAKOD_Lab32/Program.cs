using System;
using System.Collections.Generic;
using System.Linq;

namespace SiAKOD_Lab32
{
    class Program
    {
        static List<int> nums = new List<int>();
        static List<int> table = new List<int>();

        static int numsCount;
        static int tableSize;

        static System.Text.StringBuilder numsOut = new System.Text.StringBuilder();
        static System.Text.StringBuilder tableOut = new System.Text.StringBuilder();
        static Random rand = new Random();

        static void sizeChoise()
        {
            do
            {
                Console.Write("Введите количество желаемых элементов: ");
                try
                {
                    numsCount = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    break;
                }
                catch
                {
                    Console.Clear();
                    continue;
                }
            } while (true);
        }

        static void menu()
        {
            bool stop = false;
            int choise;
            do
            {
                updateScreen();
                Console.WriteLine("1: Ввести/сгенирировать новые элементы");
                Console.WriteLine("2: Поиск элемента в таблице");
                Console.WriteLine("3: Добавить элемент в таблицу");
                Console.WriteLine("4: Удалить элемент из таблицы");
                Console.WriteLine("5: Заменить элементы");
                try
                {
                    choise = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    continue;
                }

                switch (choise)
                {
                    case 1:
                        inputNums();
                        break;
                    case 2:
                        search();
                        break;
                    case 3:
                        addNums();
                        break;
                    case 4:
                        deleteNums(); 
                        break;
                    case 5:
                        replaceNums();
                        break;
                    case 6:
                        stop = true;
                        break;
                }
            } while (!stop);
            
        }

        static void inputNums()
        {
            updateScreen();

            Console.WriteLine("Вводите трёхзначные числа по одному на каждую строку;");
            Console.WriteLine("Введите вместо числа 'r', если хотите сгенирировать число рандомно;");
            Console.WriteLine("Не вводите ничего на строке, чтобы прекратить ввод чисел; \n");

            string newNum = "";
            int newNumInt = 0;

            do
            {
                newNum = Console.ReadLine();
                try
                {
                    newNumInt = Int32.Parse(newNum);
                    if ((newNumInt / 100 < 10) && (newNumInt / 100 >= 1) && !nums.Contains(newNumInt))
                    {
                        nums.Add(newNumInt);
                        hashTable();
                        updateScreen();
                        Console.WriteLine(String.Format("Число {0} успешно добавлено в список и в хеш-таблицу! \n", newNumInt));
                    }
                    else
                    {
                        updateScreen();
                        Console.WriteLine(String.Format("Число {0} не подходит. Введите трёхзначное число, которого ещё нет в списке \n", newNumInt));
                    }
                }
                catch
                {
                    if (newNum == "r" || newNum == "к")
                    {
                        while(true)
                        {
                            int randNum = rand.Next(100, 999);
                            if (!nums.Contains(randNum))
                            {
                                nums.Add(randNum);
                                hashTable();
                                updateScreen();
                                Console.WriteLine(String.Format("Случайное число {0} успешно добавлено в список и в хеш-таблицу! \n", randNum));
                                break;
                            }
                        }
                    }
                    else
                    {
                        updateScreen();
                        Console.WriteLine("Введите корректное число! \n");
                    }
                }
            } while (newNum != "");
        }

        static void search()
        {
            updateScreen();
            Console.Write("Введите число, которое вы хотите найти в таблице: ");
            int searchNum;
            do
            {
                try
                {
                    searchNum = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Введите корректное число! \n");
                }
            } while (true);

            updateScreen();
            if (searchNum == 0)
                Console.WriteLine("Число 0 является признаком пустой ячейки в таблице и не может быть использовано для поиска!");
            else if (table.IndexOf(searchNum) != -1)
                Console.WriteLine(String.Format("Число {0} найдено в таблице под индексом {1}.", searchNum, table.IndexOf(searchNum)));
            else
                Console.WriteLine(String.Format("Число {0} не было найдено в таблице.", searchNum));
            Console.ReadKey();
        }

        static void addNums()
        {
            updateScreen();
            int addNum;
            do
            {
                Console.Write("Введите трёхзначное число, которого ещё нет в списке: ");
                try
                {
                    addNum = Int32.Parse(Console.ReadLine());
                    if ((addNum / 100 < 10) && (addNum / 100 >= 1))
                    {
                        if (!table.Contains(addNum))
                            break;
                        else
                        {
                            updateScreen();
                            Console.WriteLine(String.Format("Число {0} уже присутствует в таблице под индексом {1}", addNum, table.IndexOf(addNum)));
                            Console.WriteLine("Нажмите любую клавишу для продолжения ввода");
                            Console.ReadKey();
                            updateScreen();
                        }
                    }
                    else
                    {
                        updateScreen();
                        Console.WriteLine("Введите трёхзначное число! ");
                        Console.WriteLine("Нажмите любую клавишу для продолжения ввода");
                        Console.ReadKey();
                        updateScreen();
                    }
                }
                catch
                {
                    Console.WriteLine("Введите корректное число! ");
                    Console.WriteLine("Нажмите любую клавишу для продолжения ввода");
                    Console.ReadKey();
                    updateScreen();
                }
            } while (true);
            int addIndex = 0;
            int current = 0;
            current = addNum % tableSize;

            //Если ячейка пустая, кладём в неё значение ключа
            if (table[current] == 0)
            {
                //b += 1;
                table[current] = addNum;
                addIndex = current;
            }

            //Иначе используем открытую адресацию с квадратичным опробованием
            else
            {
                int j = 1;
                while (table[(current + j * j) % tableSize] != 0)
                    j++;
                table[(current + j * j) % tableSize] = addNum;
                addIndex = (current + j * j) % tableSize;
                //b += j; //Считаем количество проб, необходимых для размещения ключа в таблице
            }

            updateScreen();
            Console.WriteLine(String.Format("Число {0} было добавлено в таблицу под индексом {1}", addNum, addIndex));
            Console.ReadKey();
        }

        static void deleteNums()
        {
            updateScreen();
            int deleteNum;
            do
            {
                Console.Write("Введите трёхзначное число, которое вы хотите удалить из таблицы: ");
                try
                {
                    deleteNum = Int32.Parse(Console.ReadLine());
                    if ((deleteNum / 100 < 10) && (deleteNum / 100 >= 1))
                    {
                        if (!table.Contains(deleteNum))
                        {
                            updateScreen();
                            Console.WriteLine(String.Format("Число {0} отсутствует в таблице", deleteNum));
                            Console.WriteLine("Нажмите любую клавишу для продолжения ввода");
                            Console.ReadKey();
                            updateScreen();
                        }
                        else
                        {
                            int deleteIndex = table.IndexOf(deleteNum);
                            table[deleteIndex] = 0;
                            updateScreen();
                            Console.WriteLine(String.Format("Число {0} успешно удалено из таблицы по индексу {1}", deleteNum, deleteIndex));
                            Console.ReadKey();
                            break;
                        }
                    }
                    else
                    {
                        updateScreen();
                        Console.WriteLine("Введите трёхзначное число! ");
                        Console.WriteLine("Нажмите любую клавишу для продолжения ввода");
                        Console.ReadKey();
                        updateScreen();
                    }
                }
                catch
                {
                    updateScreen();
                    Console.WriteLine("Введите корректное число! ");
                    Console.WriteLine("Нажмите любую клавишу для продолжения ввода");
                    Console.ReadKey();
                    updateScreen();
                }
            } while (true);
        }

        static void replaceNums()
        {
            string[] replaceNums = {"0", "0"};
            int firstNum;
            int secondNum;
            updateScreen();
            do
            {
                Console.WriteLine("Введите два числа для замены через пробел: ");
                try
                {
                    replaceNums = Console.ReadLine().Split(' ');
                    firstNum = int.Parse(replaceNums[0]);
                    secondNum = int.Parse(replaceNums[1]);
                }
                catch
                {
                    updateScreen();
                    Console.WriteLine("Введите корректное число! ");
                    Console.WriteLine("Нажмите любую клавишу для продолжения ввода");
                    Console.ReadKey();
                    updateScreen();
                    break;
                }

                if ((firstNum / 100 < 10) && (firstNum / 100 >= 1) && (secondNum / 100 < 10) && (secondNum / 100 >= 1))
                {
                    if (table.Contains(firstNum)) {
                        if (!table.Contains(secondNum))
                        {
                            int replaceIndex = table.IndexOf(firstNum);
                            table[replaceIndex] = secondNum;

                            updateScreen();
                            Console.WriteLine(String.Format("Число {0} успешно заменено на число {1} в таблице по индексу {2}", firstNum, secondNum, replaceIndex));
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            updateScreen();
                            Console.WriteLine(String.Format("Число {0} уже есть в хеш-таблце. Замена на него невозможна!", secondNum));
                            Console.WriteLine("Нажмите любую клавишу для продолжения ввода");
                            Console.ReadKey();
                            updateScreen();
                        }
                    }
                    else
                    {
                        updateScreen();
                        Console.WriteLine(String.Format("Число {0} отсутствует в хеш-таблице!", firstNum));
                        Console.WriteLine("Нажмите любую клавишу для продолжения ввода");
                        Console.ReadKey();
                        updateScreen();
                    }
                }
                else
                {
                    updateScreen();
                    Console.WriteLine("Введите два трёхзначных числа!");
                    Console.WriteLine("Нажмите любую клавишу для продолжения ввода");
                    Console.ReadKey();
                    updateScreen();
                }

                
                
                
            } while (true);
            
        }

        static void generateNums()
        {
            for (int i = 0; i < numsCount; i++)
            {
                int randNum = rand.Next(100, 999);
                if (!nums.Contains(randNum))
                {
                    nums.Add(randNum);
                }
                else i--;
            }
        }

        static public void displayNums()
        {
            numsOut.Clear();
            numsOut.Append("Рандомно сгенирированные трёхзначные числа: \n");
            for (int i = 0; i < numsCount; i++)
            {
                if (i < 9)
                    numsOut.Append(String.Format("{0}:   {1,-10}", i + 1, nums[i]));
                else if (i < 99)
                    numsOut.Append(String.Format("{0}:  {1,-10}", i + 1, nums[i]));
                else
                    numsOut.Append(String.Format("{0}: {1,-10}", i + 1, nums[i]));
                if ((i + 1) % 8 == 0)
                    numsOut.Append("\n");
            }
            Console.WriteLine(numsOut);
            Console.WriteLine();
        }

        static void updateScreen()
        {
            Console.Clear();
            displayNums();
            displayTable();
        }

        static void hashTable()
        {
            table.Clear();
            numsCount = nums.Count();
            tableSize = Convert.ToInt32(numsCount * 1.5 + 1);
            for (int i = 0; i < tableSize; i++)
            {
                table.Add(0);
            }

            for (int i = 0; i < numsCount; i++)
            {
                //Используем хеш-функцию: f(nums[i]) = nums[i] % tableSize
                int current = 0;
                current = nums[i] % tableSize;

                //Если ячейка пустая, кладём в неё значение ключа
                if (table[current] == 0)
                {
                    //b += 1;
                    table[current] = nums[i];
                }

                //Иначе используем открытую адресацию с квадратичным опробованием
                else
                {
                    int j = 1;
                    while (table[(current + j * j) % tableSize] != 0)
                        j++;
                    table[(current + j * j) % tableSize] = nums[i];
                    //b += j; //Считаем количество проб, необходимых для размещения ключа в таблице
                }
            }
        }

        static public void displayTable()
        {
            tableOut.Clear();
            tableOut.Append("Полученная хеш-таблица: \n");
            for (int i = 0; i < tableSize; i++)
            {
                if (i < 10)
                    tableOut.Append(String.Format("{0}:   {1,-10}", i, table[i]));
                else if (i < 100)
                    tableOut.Append(String.Format("{0}:  {1,-10}", i, table[i]));
                else
                    tableOut.Append(String.Format("{0}: {1,-10}", i, table[i]));
                if ((i + 1) % 8 == 0)
                    tableOut.Append("\n");
            }
            Console.WriteLine(tableOut);
            Console.WriteLine("\n--------------------------------------------------------");
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            sizeChoise();
            generateNums();
            displayNums();
            hashTable();
            displayTable();

            menu();

            Console.ReadKey();
        }
    }
}
