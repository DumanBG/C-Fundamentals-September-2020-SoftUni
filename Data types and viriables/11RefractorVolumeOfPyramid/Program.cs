using System;

namespace _11RefractorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double  Width, Heigth = 0;
            Console.Write("Length: ");
          var  length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
           var heigth = double.Parse(Console.ReadLine());
           double volume = (length * width * heigth) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:F2}");

        }
    }
}
