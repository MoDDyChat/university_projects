using System;
using System.Collections.Generic;

namespace SiAKOD_Lab33
{
    class Program
    {
        static int numsCount = 25;
        static Random rand = new Random();
        static List<int> nums = new List<int>();
        static System.Text.StringBuilder numsOut = new System.Text.StringBuilder();

        public enum NodePosition
        {
            left,
            right,
            parent
        }

        class Tree
        {
            public int Data = 0;
            public Tree LeftTree;
            public Tree RightTree;

            public void addData(int _Data)
            {
                if (Data == 0)
                    Data = _Data;
                else if (Data >= _Data)
                {
                    if(LeftTree == null)
                        LeftTree = new Tree();
                    LeftTree.addData(_Data);
                }
                else if (Data < _Data)
                {
                    if (RightTree == null)
                        RightTree = new Tree();
                    RightTree.addData(_Data);
                }
            }

            private void printData(string _Data, NodePosition nodePosition)
            {
                switch (nodePosition)
                {
                    case NodePosition.left:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("L:");
                        Console.ForegroundColor = (_Data == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
                        Console.WriteLine(_Data);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case NodePosition.right:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("R:");
                        Console.ForegroundColor = (_Data == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
                        Console.WriteLine(_Data);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case NodePosition.parent:
                        Console.WriteLine(_Data);
                        break;
                }
            }

            public void printFormat(string indent, NodePosition nodePosition, bool isLast, bool isEmpty)
            {

                Console.Write(indent);
                if (isLast)
                {
                    Console.Write("└─");
                    indent += "  ";
                }
                else
                {
                    Console.Write("├─");
                    indent += "| ";
                }

                var stringData = isEmpty ? "-" : Data.ToString();
                printData(stringData, nodePosition);

                if (!isEmpty && (LeftTree != null || RightTree != null))
                {
                    if (LeftTree != null)
                        LeftTree.printFormat(indent, NodePosition.left, false, false);
                    else
                        printFormat(indent, NodePosition.left, false, true);

                    if (RightTree != null)
                        RightTree.printFormat(indent, NodePosition.right, true, false);
                    else
                        printFormat(indent, NodePosition.right, true, true);
                }
            }

            public string treeDeTour(Tree Tree)
            {
                string s = "";
                if (Tree != null)
                {
                    s += treeDeTour(Tree.LeftTree);
                    s += Convert.ToString(Tree.Data) + " ";
                    s += treeDeTour(Tree.RightTree);
                }
                return s;
            }
        }

        static void menu(Tree Tree)
        {
            bool stop = false;
            int choise;
            do
            {
                updateScreen(Tree);
                Console.WriteLine();
                Console.WriteLine("1: Добавить элемент в дерево");
                Console.WriteLine("2: Совершить симметричный обход дерева");
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
                        addDataGUI(Tree);
                        break;
                    case 2:
                        updateScreen(Tree);
                        Console.WriteLine(String.Format("Симметричный обход дерева (LNR): {0}", Tree.treeDeTour(Tree)));
                        Console.ReadKey();
                        break;
                    case 3:
                        //addNumsGUI();
                        break;
                }
            } while (!stop);

        }

        static void addDataGUI(Tree Tree)
        {
            updateScreen(Tree);
            Console.Write("Введите двузначное число, которого ещё нет в списке: ");
            Tree.addData(Int32.Parse(Console.ReadLine()));
            updateScreen(Tree);
        }

        static void updateScreen(Tree Tree)
        {
            Console.Clear();
            Tree.printFormat("", NodePosition.parent, true, false);

        }

        static void generateNums()
        {
            for (int i = 0; i < numsCount; i++)
            {
                int randNum = rand.Next(10, 99);
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
            numsOut.Append("Рандомно сгенирированные двузначные числа: \n");
            for (int i = 0; i < numsCount; i++)
            {
                if (i < 9)
                    numsOut.Append(String.Format("{0}:   {1,-10}", i + 1, nums[i]));
                else if (i < 99)
                    numsOut.Append(String.Format("{0}:  {1,-10}", i + 1, nums[i]));
                else
                    numsOut.Append(String.Format("{0}: {1,-10}", i + 1, nums[i]));
                if ((i + 1) % 9 == 0)
                    numsOut.Append("\n");
            }
            Console.WriteLine(numsOut);
            Console.WriteLine();
        }

        static void numsToTree(Tree Tree)
        {
            for(int i = 0; i < numsCount; i++)
            {
                Tree.addData(nums[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;

            generateNums();

            displayNums();
            Console.ReadKey();

            Tree newTree = new Tree();
            numsToTree(newTree);

            menu(newTree);

            Console.WriteLine(String.Format("Симметричный обход дерева (LNR): {0}",newTree.treeDeTour(newTree)));
            
            Console.Read();
        }
    }
}
