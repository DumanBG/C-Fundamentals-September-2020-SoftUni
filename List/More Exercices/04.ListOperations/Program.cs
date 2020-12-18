using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperationsShiftvaneRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArg = command.Split();
                string firstCommand = cmdArg[0];


                if (firstCommand == "Add")
                {
                    numbers.Add((int.Parse(cmdArg[1])));

                }
                else if (firstCommand == "Remove")
                {
                    if ((int.Parse(cmdArg[1]) >= 0 && (int.Parse(cmdArg[1]) <= numbers.Count)))
                    {
                        numbers.RemoveAt((int.Parse(cmdArg[1])));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(cmdArg[2]);
                    int item = int.Parse(cmdArg[1]);

                    if (index >= 0 && index <= numbers.Count - 1)
                    {
                        numbers.Insert(index, item);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (firstCommand == "Shift")
                {
                    int rotation = int.Parse(cmdArg[2]);
                    if (cmdArg[1] == "left")
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int firstElement = numbers[0]; //запазване на първия при въртене
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];

                            }
                            numbers[numbers.Count - 1] = firstElement;
                        }
                    }
                    else if (cmdArg[1] == "right")
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int lastElement = numbers[numbers.Count - 1]; //posl elem
                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }
                            numbers[0] = lastElement;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
