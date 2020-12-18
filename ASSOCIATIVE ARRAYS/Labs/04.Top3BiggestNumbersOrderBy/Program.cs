using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Top3BiggestNumbersOrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse)
                .OrderByDescending(n => n).Take(3).ToList();    // Take samo 3

            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
