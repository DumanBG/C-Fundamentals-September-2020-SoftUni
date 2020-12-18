using System;

namespace _06CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double area = GetArea(a, b);
            Console.WriteLine(area);

          
            static double GetArea(int a, int b)
            {
                return a * b;
            }
        }
    }
}
