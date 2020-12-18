using System;
using System.Collections.Generic;

namespace _02.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> treasure = new Dictionary<string, int>();
            string resours = Console.ReadLine();
        
            while(resours !="stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if(!treasure.ContainsKey(resours))
                {
                    treasure.Add(resours, 0);
                }
                treasure[resours] += quantity;


                resours = Console.ReadLine();
            }
            foreach (var pair in treasure)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
