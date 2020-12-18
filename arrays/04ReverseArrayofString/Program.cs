using System;
using System.Linq;

namespace _04ReverseArrayofString
{
    class Program
    {
        static void Main(string[] args)
        {


            String[] elements = Console.ReadLine().Split(" ").ToArray();

            for (int i = 0; i < elements.Length / 2; i++)
            {
                String oldElement = elements[i];
                elements[i] = elements[elements.Length - 1 - i];
                elements[elements.Length - 1 - i] = oldElement;
            }
            Console.WriteLine(String.Join(" ", elements));
            }
    }
}
