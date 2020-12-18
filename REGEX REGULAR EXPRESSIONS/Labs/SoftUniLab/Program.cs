using System;
using System.Text.RegularExpressions;

namespace SoftUniLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);
            // Ime Imevo  Pesho Petrov Ivan Andonov Ivanov 
            string input = Console.ReadLine();

            Console.WriteLine(regex.IsMatch(input));  // проверява дали има поне един match  на pattern-a с inputa // връща true ili false
            Console.WriteLine(regex.Match(input).Value); // връща първия match:  Ime Imevo
            Console.WriteLine(regex.Matches(input).Count); //Дава лист  и на листа Count - броя на намиранията

            MatchCollection matches = regex.Matches(input);
            foreach(Match match in matches)  // Изрично  във foreach  ( Match  xxxxx in xxxx)
            {
                Console.WriteLine(match.Value); // Ivan Ivanov
                Console.WriteLine(match.Index);  // Index : 0   , 11 ,24
                Console.WriteLine(match.Length);   // дължина на match
        //   Console.WriteLine($"Ime:{match.Groups[1].Value} Familiq: {match.Groups[2].Value}");  // като масив дава първата група, може [1] [2]
              //   Console.WriteLine(match.Groups.Count);
            }
        }
    }
}
