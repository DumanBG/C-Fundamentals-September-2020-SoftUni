using System;
using System.Globalization;
using System.Linq;

namespace _08CondensArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int n = nums.Length;
            for (int i = 0; i < n-1; i++)
            {
                int[] newArr = new int[nums.Length - 1];

                for (int j = 0; j < newArr.Length; j++)
                {
                    newArr[j] = nums[j] + nums[j + 1];

                }
                nums = newArr;


            }

            Console.WriteLine(String.Join(" ",nums));
        }

    }
}

