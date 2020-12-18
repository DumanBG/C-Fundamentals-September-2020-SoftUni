using System;
using System.Security.Cryptography.X509Certificates;

namespace _03Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(a, b);
                    break;
                case "substract":
                    Substract(a, b);
                    break;
                case "multiply":
                    Multiply(a, b);
                    break;
                case "divide":
                    Divide(a, b);
                    break;


            }
        }
            // Methods
           static void Multiply(int a, int b)
            {
                Console.WriteLine(a*b);

            }

            static void Divide(int a, int b)
            {
                Console.WriteLine(a / b);

            }
            static void Add(int a, int b)
            {
                Console.WriteLine(a + b);

            }
            static void Substract(int a, int b)
            {
                Console.WriteLine(a - b);

            }
        }
    }

