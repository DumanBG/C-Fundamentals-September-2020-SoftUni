using System;

namespace _03.CharacterInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            PrintIntBetween(firstSymbol, secondSymbol);

           
        }

        private static void PrintIntBetween(char firstSymbol, char secondSymbol)
        {
            if ((int)firstSymbol > (int)secondSymbol)
            {
                char first = firstSymbol; //превъртаме без луп първи с втори;
                firstSymbol = secondSymbol;
                secondSymbol = first;

            }
            for (int i = firstSymbol+1; i < secondSymbol; i++)
            {
                Console.Write((char)i + " ");
            }



        }
    }
}
