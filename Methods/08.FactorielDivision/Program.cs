using System;

namespace _08.FactorielDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());


            double firstfactoriel = FindFactoriel(first);
            double secondfactoriel = FindFactoriel(second);
            double result =1.00* Division(firstfactoriel, secondfactoriel);
            Console.WriteLine($"{result:F2}");
        }

        private static double Division(double firstfactoriel, double secondfactoriel)
        {


            return firstfactoriel / secondfactoriel;
        }


        public static double FindFactoriel(int number)
        {
            double result = 1.00;
            while (number != 1)

            {
                result = 1.00*result * number;
                number = number - 1;
            }
            return result;
        }
    }
}