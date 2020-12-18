using System;

namespace _31SnowBall
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long snowballValue = 0; int snowballSnow = 0; int snowballTime = 0; int snowballQuality = 0;
            for (int i = 1; i <= n; i++)
            {
                int newSnowballSnow = int.Parse(Console.ReadLine());
                int newSnowballTime = int.Parse(Console.ReadLine());
                int newSnowballQuality = int.Parse(Console.ReadLine());
                long sum = (long)Math.Pow(((double)newSnowballSnow / newSnowballTime), newSnowballQuality);
                if (sum > snowballValue)
                {
                    snowballValue = sum; snowballSnow = newSnowballSnow; snowballTime = newSnowballTime; snowballQuality = newSnowballQuality;
                }
            }

            Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");

        }
    }
}