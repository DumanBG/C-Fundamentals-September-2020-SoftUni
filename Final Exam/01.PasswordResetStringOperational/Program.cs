using System;
using System.Linq;

namespace _01.PasswordResetStringOperational
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdArg = tokens[0];
                switch (cmdArg)
                {
                    case "TakeOdd":
                        string newString = "";
                        // Вземане само на ODD symbols from string
                        newString = string.Concat(password.Where((c, i) => i % 2 != 0));
                        password = newString;
                        Console.WriteLine(password);
                        break;

                    case "Cut":
                        //•	Cut {index} {length}
                        int index = int.Parse(tokens[1]);
                        int length = int.Parse(tokens[2]);
                        string cutted = password.Substring(index, length);
                        int FirstGet = password.IndexOf(cutted);
                        password = password.Remove(FirstGet, length);
                         Console.WriteLine(password);

                        break;
                    case "Substitute":
                        //   	Substitute { substring} { substitute}  || Substitute :: -
                        string toReplace = tokens[1];
                        string replaceWith = tokens[2];

                        if (!password.Contains(toReplace))
                            {
                            Console.WriteLine("Nothing to replace!");
                        }else
                        {
                            password = password.Replace(toReplace, replaceWith);
                            Console.WriteLine(password);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
