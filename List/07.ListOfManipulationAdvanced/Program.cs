using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListOfManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> oldList = list;

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] operations = command.Split();

                if (operations[0] == "Contains")
                {
                    if (list.Contains(int.Parse(operations[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (operations[0] == "PrintEven")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 == 0)
                        {
                            Console.Write($"{list[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (operations[0] == "PrintOdd")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 != 0)
                        {
                            Console.Write($"{list[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (operations[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine(sum);
                }
                else if (operations[0] == "Filter")
                {
                    string symbol = operations[1];
                    int filter = int.Parse(operations[2]);
                    if (symbol == "<")
                    {
                        Console.WriteLine(string.Join(" ", list.FindAll(x => x < filter)));
                    }
                    else if (symbol == ">")
                    {
                        Console.WriteLine(string.Join(" ", list.FindAll(x => x > filter)));
                    }
                    else if (symbol == ">=")
                    {
                        // result = numbersMore.Where(x => x >= filter).ToList();
                        Console.WriteLine(string.Join(" ", list.FindAll(x => x >= filter)));
                    }
                    else if (symbol == "<=")
                    {
                        Console.WriteLine(string.Join(" ", list.FindAll(x => x <= filter)));
                    }
                }



                command = Console.ReadLine();
            }
            if (oldList != list)
            {
                Console.WriteLine(String.Join(" ", list));
            }
        }
    }
}