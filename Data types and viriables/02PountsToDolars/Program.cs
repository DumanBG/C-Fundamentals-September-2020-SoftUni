using System;

namespace _02PountsToDolars
{
    class Program
    {
        static void Main(string[] args)
        {
            double BP = double.Parse(Console.ReadLine());

            
            
            string USD =string.Format($"{BP*1.31:F3}");

            Console.WriteLine(USD);
          
        }
    }
}
