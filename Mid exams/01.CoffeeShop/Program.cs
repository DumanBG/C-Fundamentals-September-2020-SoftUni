using System;

namespace _01.CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countCapsule = int.Parse(Console.ReadLine());
                double currentSum = (days * countCapsule) * capsulePrice;
                total += currentSum;

                Console.WriteLine($"The price for the coffee is: ${currentSum:F2}");

            }
            Console.WriteLine($"Total: ${total:F2}");
            

        }
    }
}
