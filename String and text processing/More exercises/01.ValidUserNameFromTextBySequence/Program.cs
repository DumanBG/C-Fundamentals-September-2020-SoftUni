using System;
using System.Linq;
using System.Text;

namespace _01.ValidUserNameFromTextBySequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            bool validIsTrue = true;


            foreach (string item in text)
            {
                if (item.Length >= 3 && item.Length <= 16)
                {
                    for (int i = 0; i < item.Length; i++)

                    {

                        char currentLetter = item[i];
                        if (!char.IsLetterOrDigit(currentLetter) && currentLetter != '-' && currentLetter != '_')
                        {
                            validIsTrue = false;
                            break;
                        }


                    }
                    if (validIsTrue)
                    {
                        Console.WriteLine(item);
                    }

                    validIsTrue = true;
                }
            }
        }
    }
}
