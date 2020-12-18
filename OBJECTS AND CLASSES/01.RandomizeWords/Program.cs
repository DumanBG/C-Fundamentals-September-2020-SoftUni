using System;
using System.Linq;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            StringRandomizer randomzer = new StringRandomizer();
            randomzer.words = Console.ReadLine().Split();

            randomzer.Randomise();
            randomzer.PrintWords();




        }
        public class StringRandomizer
        {
            public string[] words;

            public void Randomise()
            {
                Random rand = new Random();
                for (int i = 0; i < this.words.Length; i++)
                {
                    int randomPosition = rand.Next(0, this.words.Length);
                    string temp = this.words[i];
                    this.words[i] = this.words[randomPosition];
                    this.words[randomPosition] = temp;

                }
            }
           public void PrintWords()
            {
                Console.WriteLine(string.Join(Environment.NewLine, this.words));
            }

        }
    }
}
