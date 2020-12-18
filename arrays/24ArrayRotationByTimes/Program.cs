using System;
using System.Linq;

namespace _24ArrayRotationByTimes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rotation = int.Parse(Console.ReadLine());


            for (int i = 0; i < rotation; i++)
            {
                int firstElement = array[0];
                int[] temp = new int[array.Length];

                for (int j = 1; j < array.Length; j++)
                {
                    temp[j - 1] = array[j];
                }
                temp[temp.Length - 1] = firstElement;
                array = temp;
            }
            Console.WriteLine(string.Join(' ',array));
        }
    }
}

            
            //*
            
            //string[] line = Console.ReadLine().Split(" ");

            //int rotation = int.Parse(Console.ReadLine());
            //int[] array = new int[line.Length];
           
            //for (int i = 0; i < line.Length; i++)
            //{
            //    array[i] = int.Parse(line[i]);
            //}
           
            //for (int i = 0; i < rotation; i++)
            //{
            //    int currentElement = array[0];
            //    for (int j = 0; j < array.Length - 1; j++)
            //    {
            //        array[j] = array[j + 1];

            //    }
            //    array[array.Length - 1] = currentElement;
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //*
