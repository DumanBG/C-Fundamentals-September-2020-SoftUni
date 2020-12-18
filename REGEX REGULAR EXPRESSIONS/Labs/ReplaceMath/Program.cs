using System;
using System.Text.RegularExpressions;

namespace ReplaceMath
{
    class Program
    {
        static void Main(string[] args)
        {
            //REPLACE "Nakov: 123, Branson: 456"; s// Nakov: 999, Branson: 999
            string text = "Nakov: 123, Branson: 456";
            string pattern = @"\d{3}";
            string replacement = "999";

            Regex regex = new Regex(pattern);
            string result = regex.Replace(text, replacement);

            Console.WriteLine(result);
            // Nakov: 999, Branson: 999


            //Split "1   2 3      4";  v // 1, 2, 3, 4
            string input = "1   2 3      4";
            string thePattern = @"\s+"; // split po edin ili pove4e whiteSpace

            string[] arraySplitted = Regex.Split(input, thePattern);
            Console.WriteLine(string.Join(", ", arraySplitted));
            // 1, 2, 3, 4

        }
    }
}
