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
        static double b;

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
                        searchGUI();
                        break;
                    case 3:
                        addNumsGUI();
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

        static int search(int searchNum)
        {
            int current = 0;
            current = searchNum % tableSize;

            if (table[current] == searchNum)
                return current;
            else
            {
                int j = 1;
                try
                {
                    while (table[(current + j * j) % tableSize] != searchNum)
                        j++;
                    return (current + j * j) % tableSize;
                }
                catch
                {
                    return -1;
                }
            }
        }

        static void searchGUI()
        {
            do
            {
                updateScreen();
                Console.Write("Введите число, которое вы хотите найти в таблице: ");
                int searchNum;
                try
                {
                    searchNum = Int32.Parse(Console.ReadLine());
                    if ((searchNum / 100 < 10) && (searchNum / 100 >= 1)) {
                        int searchIndex = search(searchNum);
                        if (searchIndex != -1)
                        {
                            updateScreen();
                            Console.WriteLine(String.Format("Число {0} найдено в таблице под индексом {1} \n",searchNum, searchIndex));
                            Console.ReadKey();
                        }
                        else
                        {
                            updateScreen();
                            Console.WriteLine(String.Format("Число {0} отсутствует в таблице! \n", searchNum));
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        updateScreen();
                        Console.WriteLine(String.Format("Число {0} не подходит. Введите трёхзначное число, которого ещё нет в списке \n", searchNum));
                        Console.ReadKey();
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Введите корректное число! \n");
                    Console.ReadKey();
                }
            } while (true);
        }

        static void addNumsGUI()
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
                        if (search(addNum) == -1)
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

            int addIndex = addNums(addNum);

            if (addIndex == -1)
            {
                Console.WriteLine(String.Format("Число {0} невозможно добавить в таблицу", addNum));
                return;
            }

            updateScreen();
            Console.WriteLine(String.Format("Число {0} было добавлено в таблицу под индексом {1}", addNum, addIndex));
            Console.ReadKey();
        }

        static int addNums(int addNum)
        {
            int current = addNum % tableSize;


            //Если ячейка пустая, кладём в неё значение ключа
            if (table[current] == 0)
            {
                table[current] = addNum;
                return current;
            }

            //Иначе используем открытую адресацию с квадратичным опробованием
            else
            {
                int j = 1;
                try
                {
                    while (table[(current + j * j) % tableSize] != 0)
                        j++;
                    table[(current + j * j) % tableSize] = addNum;
                    return (current + j * j) % tableSize;
                }
                catch
                {
                    return -1;
                }
            }
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
                        if (search(deleteNum) == -1)
                        {
                            updateScreen();
                            Console.WriteLine(String.Format("Число {0} отсутствует в таблице", deleteNum));
                            Console.WriteLine("Нажмите любую клавишу для продолжения ввода");
                            Console.ReadKey();
                            updateScreen();
                        }
                        else
                        {
                            int deleteIndex = search(deleteNum);
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
                    int replaceIndex = search(firstNum);
                    if (replaceIndex != -1) {
                        if (search(secondNum) == -1)
                        {
                            table[replaceIndex] = 0;
                            int newIndex = addNums(secondNum);
                            updateScreen();
                            Console.WriteLine(String.Format("Число {0} [{1}] успешно заменено на число {2} [{3}] в таблице!", firstNum, replaceIndex, secondNum, newIndex));
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

        static void displayNums()
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
                    b += 1;
                    table[current] = nums[i];
                }

                //Иначе используем открытую адресацию с квадратичным опробованием
                else
                {
                    int j = 1;
                    while (table[(current + j * j) % tableSize] != 0)
                        j++;
                    table[(current + j * j) % tableSize] = nums[i];
                    b += j; //Считаем количество проб, необходимых для размещения ключа в таблице
                }
            }
        }

        static void displayTable()
        {
            int alpha = 0;
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
                if (table[i] != 0)
                    alpha++;
            }
            Console.WriteLine(tableOut);
            Console.WriteLine(String.Format("\nКоэффициент заполнения таблицы: {0}", (alpha * 1f / tableSize * 1f).ToString("0.00")));
            Console.WriteLine(String.Format("Среднее количество шагов, необходимых для размещения ключа в таблице: {0}", (b / numsCount).ToString("0.00")));
            Console.WriteLine("\n--------------------------------------------------------");
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(115, 30);

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
