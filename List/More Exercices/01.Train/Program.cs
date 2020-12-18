using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] token = command.Split();

                if(token[0] == "Add")
                {
                    wagons.Add(int.Parse(token[1]));
                }
                else
                {
                   int newPassengers = int.Parse(token[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if(wagons[i]+newPassengers <=capacity)
                        {
                            wagons[i] = wagons[i] + newPassengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
                }
            Console.WriteLine(string.Join(" ",wagons));


            }

        }
    }
