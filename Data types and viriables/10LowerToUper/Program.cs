using System;

namespace _10LowerToUper
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());


            int ascii = (int)symbol;
            if (ascii >= 65 && ascii <=90 )
            {
                Console.WriteLine("upper-case");


            } else if (ascii >= 97 && ascii <= 122)
            {
                Console.WriteLine("lower-case");
         }
        }
    }
}
