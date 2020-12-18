using System;

namespace _08.StarLettersChangeNumbersMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // A12b s17G  //A12b s17G // 12/1=12, 12+2=14, 17*19=323, 323–7=316, 14+316=330
          
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            // izkarvame cqlata ang azbuka;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];

                char firstLetter = current[0];
                char lastLetter = current[current.Length-1];
                double number = double.Parse(current.Substring(1, current.Length - 2));

                int firstElementIndex = alphabet.IndexOf(char.ToUpper(firstLetter))+1;// taka se upva i vzema index +1
                int secondElementIndex = alphabet.IndexOf(char.ToUpper(lastLetter))+1;

                if(char.IsUpper(firstLetter))
                {
                    number = number / firstElementIndex;  // +1 зашото alpha започва от 0;
                }
                else
                {
                    number = number * firstElementIndex;
                }
                if(char.IsUpper(lastLetter))
                {
                    number = number - secondElementIndex;  // +1 зашото alpha започва от 0;
                }
                else
                {
                    number = number + secondElementIndex;
                }
            
                result += number;
            }

            Console.WriteLine($"{result:F2}");


        }
    }
}
