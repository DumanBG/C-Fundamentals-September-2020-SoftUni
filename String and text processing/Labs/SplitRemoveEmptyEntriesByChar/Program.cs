using System;

namespace SplitRemoveEmptyEntriesByChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "hey, op, , , ,,, hey hey";
            string[] result = text.Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);
            // горното маха повече от един елемента като чар масив
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
