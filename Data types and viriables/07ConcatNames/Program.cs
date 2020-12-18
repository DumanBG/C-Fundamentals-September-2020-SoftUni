using System;

namespace _07ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string symbol = Console.ReadLine();

            //   string concat = string.Format($"{firstName}{symbol}{secondName}");
            //  Console.WriteLine(concat);

            Console.WriteLine($"{firstName}{symbol}{secondName}");
        }
    }
}
