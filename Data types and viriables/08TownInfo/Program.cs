using System;

namespace _08TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Town Sofia has population of 1286383 and area 492 square km.

            string city = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int square = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {city} has population of {population} and area {square} square km.");


      
        }
    }
}
