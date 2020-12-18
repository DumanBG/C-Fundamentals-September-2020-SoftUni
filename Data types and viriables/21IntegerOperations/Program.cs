using System;

namespace _21IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int forth = int.Parse(Console.ReadLine());

            int sum = ((first + second) / third) * forth;


            Console.WriteLine(sum);
        }
    }
}
