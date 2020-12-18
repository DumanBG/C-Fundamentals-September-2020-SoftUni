using System;
using System.Text.RegularExpressions;

namespace DemoTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Nakov: 123, Branson: 456";
            string pattern = @"([A-Z][a-z]+): (\d+)";
            
            Regex regex = new Regex(pattern);
            Match match = regex.Match(text);

            Console.WriteLine(match.Groups.Count); // 3
            Console.WriteLine("Matched text: \"{0}\"", match.Value); // "Nakov 123"
            Console.WriteLine($"Matched text: {match.Value}");   // Nakov 123
            Console.WriteLine($"Name: {match.Groups[1]}"); // Nakov
            Console.WriteLine($"Number: {match.Groups[2]}"); // 123


    
        }
    }
}
