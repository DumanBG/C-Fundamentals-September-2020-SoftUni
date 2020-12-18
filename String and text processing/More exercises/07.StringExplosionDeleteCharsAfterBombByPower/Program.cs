using System;
using System.Text;

namespace _07.StringExplosionDeleteCharsAfterBombByPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            int bomb = 0;
            //abv>1>1>2>2asdasd            abv>>>>dasd
            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];

                if(currentChar == '>')
                {
                    bomb += int.Parse(input[i + 1].ToString());
                    continue;  // увеличаваме бимб сила и рестарт
                }
                if(bomb>0)
                {
                    input = input.Remove(i, 1); //махаме индекс
                    i--; // сваляме i  и после бомба
                    bomb--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
