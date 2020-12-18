using System;

namespace _30PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int count = 0;
            int x = N / 2;
            bool realHalf = N % x == 0;
            while (N >= M)
            {
                N -= M;
                count++;
                if (Y > 0 && realHalf && N == x)
                {
                    N /= Y;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(count);
        }
    }
}
