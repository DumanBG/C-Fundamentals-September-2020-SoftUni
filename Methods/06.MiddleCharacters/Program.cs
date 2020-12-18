using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            if (input.Length % 2 == 0)
            {
                 output = GetEvenMidleChars(input);

            }
       
            else
            {
                 output = GetOddMidle(input);

            }
            Console.WriteLine(output);

        }

        private static string GetOddMidle(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index,1);
            return chars;
        }
        private static string GetEvenMidleChars(string input)
        {
            int index = input.Length / 2-1;
            //четни
            string chars = input.Substring(index, 2);
            return chars;
        }
    }
}
