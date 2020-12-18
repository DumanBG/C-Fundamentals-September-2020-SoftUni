using System;
using System.Linq;
using System.Text;

namespace _05.MultiplyByNumberLong
{
    class Program
    {
        static void Main(string[] args)
        {
            //trim na нули отпред от голям стринг правим голям стринг билдер с умножение
            //Избягваме case-oве  с първи 0-ли, string.Empty
            StringBuilder sb = new StringBuilder();
            string longNumber = Console.ReadLine().TrimStart('0');
            int smallNumber = int.Parse(Console.ReadLine());
            int temp = 0;
            if (smallNumber == 0 || longNumber == string.Empty)
            {
                Console.WriteLine(0);
                return;
            }
            foreach (char character in longNumber.Reverse())
            {
                int digit = int.Parse(character.ToString());
                int result = digit * smallNumber + temp;

                int restDigit = result % 10;
                temp = result / 10;
                sb.Insert(0, restDigit);
            }
            if (temp != 0)
            {
                sb.Insert(0, temp);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
