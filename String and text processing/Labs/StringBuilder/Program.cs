using System;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder("pesho");
            result.Append("gosho");
            result.AppendLine("matilda");//AppendLine -na nov red
            result[0] = 'Z';
            result.Insert(2, "??");
            result.Remove(2, 1);//startIndex / lenght na mahane
            int lenght = result.Length;
            string stringResult = result.ToString();// Правим си операциите и го връщаме към стринг
        }
    }
}
