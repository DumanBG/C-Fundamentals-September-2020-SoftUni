using System;
using System.Linq;

namespace _01ValidUserByMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(", ");

            foreach (var ch in text)
            {

                var currentString = ch;
                if (isValid(currentString))
                {
                    Console.WriteLine(currentString);
                }
            }
        }

        public static bool isValid(string currentString)
        {
            // has lenght >=3 &&<= 16
            //Contains only Letters, digits or - && _;

            return currentString.Length >= 3
                && currentString.Length <= 16
                && (currentString.All(c => char.IsLetterOrDigit(c)) ||
                currentString.Contains("-") || currentString.Contains("_"));
            
        }
    }
}
