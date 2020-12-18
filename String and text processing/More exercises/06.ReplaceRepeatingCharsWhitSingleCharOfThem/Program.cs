using System;
using System.Text;

namespace _06.ReplaceRepeatingCharsWhitSingleCharOfThem
{
    class Program
    {
        static void Main(string[] args)
        {    //  aaaaabbbbbcdddeeeedssaa = aaaaabbbbbcdddeeeedssaa
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(input[0]);
            foreach(char ch in input)
            {
                if(ch != sb[sb.Length - 1])
                {
                    sb.Append(ch);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
