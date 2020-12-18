using System;

namespace _03.SubstringRemoveOneWordManyTimesFromBigString
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyToRemove = Console.ReadLine();
            string text = Console.ReadLine();
            int index = text.IndexOf(keyToRemove);
            while(index !=1)
            {
               text= text.Remove(index, keyToRemove.Length);
                 index = text.IndexOf(keyToRemove);
            }
            Console.WriteLine(text);
        }
    }
}
