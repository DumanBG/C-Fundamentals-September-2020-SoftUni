using System;

namespace _29SpaceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int daysCount = 0;
            int totalSpices = 0;
            int currentYield = startingYield;
            while (currentYield >= 100)
            {

                daysCount++;
                totalSpices += currentYield - 26;
                currentYield -= 10;
            }
            if (totalSpices > 0)
            {
                totalSpices -= 26;
            }
            Console.WriteLine($"{daysCount}\n{ totalSpices}");


        }
    }
}