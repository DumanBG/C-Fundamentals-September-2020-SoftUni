using System;

namespace _01ConvertMetersToKilometes
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            double kilometers =(double)meters / 1000;
         
           if(meters <= 0 )
            {
                return;
            }
            
            
            string strKilometers = String.Format($"{kilometers:F2}");
         
            Console.WriteLine(strKilometers);
        }
    }
}
