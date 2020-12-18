using System;

namespace Passed02
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradeInput = double.Parse(Console.ReadLine());

            if(gradeInput>=3)
            {
                Console.WriteLine("Passed!");
            }


        }
    }
}
