using System;

namespace _01.SecretChatStringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();

            while(input != "Reveal")
            {
                string[] instructions = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string command = instructions[0];

                switch(command)
                {
                    case "InsertSpace":
                        //InsertSpace:|:5
                        int index = int.Parse(instructions[1]);
                        text = text.Insert(index, " ");
                        Console.WriteLine(text);
                        break;
                    case "Reverse":
                        string toReverse = instructions[1];
                        //Reverse:|:!gnil
                        if(!text.Contains(toReverse))
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            text = text.Remove(text.IndexOf(toReverse), toReverse.Length);

                            char[] charArray = toReverse.ToCharArray();
                            Array.Reverse(charArray);
                            string reversed = new string(charArray);
                            text = text.Insert(text.Length, reversed);
                            Console.WriteLine(text);
                        }
                        break;
                    case "ChangeAll":
                        //ChangeAll:|:V:|:l
                        string substring = instructions[1];
                        string replacement = instructions[2];
                        text = text.Replace(substring, replacement);

                     
                        Console.WriteLine(text);
                        break;

                }
                        input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {text}");
        }
    }
}
