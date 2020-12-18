using System;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string codeText = Console.ReadLine();
            //ILikeSharan

            string input = Console.ReadLine();
            while (input != "Finish")
            {

                string[] cmdArguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArguments[0];

                switch (command)
                {
                    case "Replace":
                        // Replace {currentChar} {newChar}  /Replace a e
                        string chToReplace = cmdArguments[1];
                        string replaceWithNewChar = cmdArguments[2];
                        if (codeText.Contains(chToReplace))
                        {
                            codeText = codeText.Replace(chToReplace, replaceWithNewChar);
                        }
                        Console.WriteLine(codeText);

                        break;
                    case "Cut":
                        //Cut {StartIndex} {EndIndex}  Cut    1  3
                        int startIndex = int.Parse(cmdArguments[1]);
                        int endtIndex = int.Parse(cmdArguments[2]);

                        if (startIndex >= 0 && endtIndex >= 0 && startIndex < codeText.Length && endtIndex < codeText.Length)
                        {
                            codeText = codeText.Remove(startIndex, endtIndex - startIndex+1);
                        Console.WriteLine(codeText);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;

                    case "Make":
                        // Make Upper/Lower а

                        if (cmdArguments[1] == "Upper")
                        {
                            codeText = codeText.ToUpper();
                        }
                        else if (cmdArguments[1] == "Lower")
                        {
                            codeText = codeText.ToLower();
                        }
                        Console.WriteLine(codeText);
                        break;
                    case "Check":
                        //Check {string}  Check SHEREN
                        string stringToCheck = cmdArguments[1];
                        if (codeText.Contains(stringToCheck))
                        {
                            Console.WriteLine($"Message contains {stringToCheck}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {stringToCheck}");
                        }
                        break;
                    case "Sum":

                        int beginIndex = int.Parse(cmdArguments[1]);
                        int endIndex = int.Parse(cmdArguments[2]);

                        if (beginIndex >= 0 && beginIndex < codeText.Length && endIndex >= 0 && endIndex <= codeText.Length)
                        {
                            if (beginIndex >= 0 && endIndex < codeText.Length)
                            {
                                int sum = 0;
                                for (int j = beginIndex; j <= endIndex; j++)
                                {
                                    sum += codeText[j];
                                }
                                Console.WriteLine(sum);
                            }
                            else
                            {
                                Console.WriteLine("Invalid indices!");
                                ;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                }
                        input = Console.ReadLine();

            }
         
        
           
           

        }
    }
}
