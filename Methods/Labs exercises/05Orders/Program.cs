using System;

namespace _05Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int units = int.Parse(Console.ReadLine());

            switch(input)
            {
                case "coffee":
                    Coffee(units);
                    break;
                case "water":
                    Water(units);
                    break;
                case "coke":
                    Coke(units);
                    break;
                case "snacks":
                    Snacks(units);
                    break;
            }

        }
         
            static void Coffee(int units)
            {
                Console.WriteLine($"{(units*1.5):F}");
            }
            static void Water(int units)
            {
                Console.WriteLine($"{(units * 1.0):F}");
            }
            static void Coke(int units)
            {
                Console.WriteLine($"{(units * 1.4):F}");
            }
            static void Snacks(int units)
            {
                Console.WriteLine($"{(units * 2.0):F}");
            }
        }
    }
