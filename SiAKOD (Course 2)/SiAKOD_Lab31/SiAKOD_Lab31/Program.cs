using System;

namespace SiAKOD_Lab31
{
    class Program
    {
        int numsAmount = 49; //Количество рандомных трёхзначных числе на входе
        int tableSize = 73; //Размер хэш-таблицы

        int[] nums = new int[49];
        int[] table = new int[73];

        double b = 0; //Общее число проб, необходимых для размещения ключа в таблице

        Random rand = new Random();
        System.Text.StringBuilder numsOut = new System.Text.StringBuilder();
        System.Text.StringBuilder tableOut = new System.Text.StringBuilder();

        //Заполнение массива рандомными трехзначными числами
        void genRandom()
        {
            for (int i = 0; i < numsAmount; i++)
            {
                nums[i] = rand.Next(100, 999);
                for (int j = 0; j < i; j++)
                    if (nums[i] == nums[j])
                    {
                        i--;
                        break;
                }
            }
        }

        //Вывод массива рандомных трёхзначных чисел в консоль
        public void displayNums()
        {
            numsOut.Append("Рандомно сгенирированные трёхзначные числа: \n");
            for (int i = 0; i < numsAmount; i++)
            {
                if (i < 9)
                    numsOut.Append(String.Format("{0}:  {1,-10}", i + 1, nums[i]));
                else
                    numsOut.Append(String.Format("{0}: {1,-10}", i + 1, nums[i]));
                if ((i + 1) % 7 == 0)
                    numsOut.Append("\n");
            }
            Console.WriteLine(numsOut);
        }

        //Заполнение хеш-таблицы числами из массива nums, используя открытую адресацию с квадратичным  опробыванием.
        public void hashTable()
        {
            for (int i = 0; i < numsAmount; i++)
            {
                //Используем хеш-функцию: f(nums[i]) = nums[i] % tableSize
                int current = 0;
                current = nums[i] % tableSize;

                //Если ячейка пустая, кладём в неё значение ключа
                if (table[current] == 0)
                {
                    table[current] = nums[i];
                }

                //Иначе используем открытую адресацию с квадратичным  опробыванием
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

        //Вывод хеш-таблицы в консоль
        public void displayTable()
        {
            tableOut.Append("Полученная хеш-таблица: \n");
            for (int i = 0; i < tableSize; i++)
            {
                if (i < 9)
                    tableOut.Append(String.Format("{0}:  {1,-10}", i + 1, table[i]));
                else
                    tableOut.Append(String.Format("{0}: {1,-10}", i + 1, table[i]));
                if ((i + 1) % 7 == 0)
                    tableOut.Append("\n");
            }
            Console.WriteLine(tableOut);
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            program.genRandom();
            program.displayNums();
            program.hashTable();

            program.displayTable();

            Console.WriteLine("\n");

            Console.WriteLine(String.Format("Количество сгенированных трёхзначных чисел: {0}", program.numsAmount));
            Console.WriteLine(String.Format("Размер полученной хеш-таблицы: {0}", program.tableSize));
            Console.WriteLine(String.Format("Коэффициент заполнения таблицы : {0}", (program.numsAmount * 1f / program.tableSize * 1f).ToString("0.00")));
            Console.WriteLine(String.Format("Среднее число проб: {0}", (program.b / program.numsAmount).ToString("0.00")));

            Console.ReadKey();
        }
    }
}
