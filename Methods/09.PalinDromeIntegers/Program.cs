using System;
using System.Linq;

namespace _09.PalinDromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {

                bool sameReversed = ReversedString(input);
                if (sameReversed)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();


            }
        }

        private static bool ReversedString(string text)
        {
           
                char[] cArray = text.ToCharArray();
                string reverse = String.Empty;
                for (int i = cArray.Length - 1; i > -1; i--)
                {
                    reverse += cArray[i];
                }
                if(text ==reverse)
            {
                return true;
            }

                return false;
            }
        }
}
