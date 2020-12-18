using System;

namespace _03.ExtractFileUseLastWords
{
    class Program
    {
        static void Main(string[] args)
        {   //C:\Internal\training-internal\Template.pptx
            string[] filePath = Console.ReadLine().Split('\\'); //escape / s dve // ili @"\"
            var lastFile = filePath[filePath.Length - 1]; // vzemane na posleden element
            var array = lastFile.Split(".");
            string name = array[0];
            string extention = array[1];
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extention}");

        }
    }
}
