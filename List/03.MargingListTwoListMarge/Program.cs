using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MargingListTwoListMarge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


            Console.WriteLine(String.Join(" ",MergeTwoLists(firstList,secondList)));
        }

        static List<int>MergeTwoLists(List<int> first, List<int> second)
        {
            //търсене на по-големия лист:
            int count = Math.Max(first.Count, second.Count);
            List<int> mergedList = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if(first.Count > i)
                {

                mergedList.Add(first[i]);
                }
                if(second.Count > i)
                {

                mergedList.Add(second[i]);
                }
            }


            return mergedList;

        }
    }
}
