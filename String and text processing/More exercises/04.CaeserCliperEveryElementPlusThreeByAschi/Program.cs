using System;

namespace _04.CaeserCliperEveryElementPlusThreeByAschi
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // Увеличаваме всеки чар с +3 бай аscii и принт кода
            foreach(char chr in input)
            {
                var currentChar =chr + 3;
                char c = (char)currentChar;
                Console.Write(c);
            }

        }
    }
}
