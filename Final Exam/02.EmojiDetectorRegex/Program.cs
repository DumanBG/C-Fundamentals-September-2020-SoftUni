using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.EmojiDetectorRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            // valid :::Joy::, **Banana**, ::Wink:: InValid:::Joy**, ::fox:es:, **Monk3ys**, :Snak::Es::
            string emojiPattern = @"(?<separator>\*|:){2}(?<emoji>[A-Z][a-z]{2,})\k<separator>{2}";

            string numbersPattern = @"[0-9]";

            Dictionary<string, int> EmojiDictionary = new Dictionary<string, int>();
            BigInteger coolThreshHold = 1;

            MatchCollection mathesEmoji = Regex.Matches(text, emojiPattern);
            MatchCollection mathesNumbers = Regex.Matches(text, numbersPattern);

            foreach (Match match in mathesNumbers)
            {
                coolThreshHold *= int.Parse(match.ToString());

            }
            Console.WriteLine($"Cool threshold: { coolThreshHold}");
            foreach (Match match in mathesEmoji)
            {
                string emojiName = match.ToString();
                EmojiDictionary.Add(emojiName, 0);
                int emojiPower = 0;

                for (int i = 2; i < emojiName.Length - 2; i++)
                {

                    emojiPower += (int)emojiName[i];
                }

                EmojiDictionary[emojiName] = emojiPower;
                //  Console.WriteLine($"{emojiName} \n {emojiPower}");
                // Console.WriteLine(EmojiList[emojiName]);
            }
            Console.WriteLine($"{mathesEmoji.Count} emojis found in the text. The cool ones are:");
            //EmojiDictionary = EmojiDictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value); няма нужда да са по ред
            foreach (var emoji in EmojiDictionary)
            {
                if (emoji.Value >= coolThreshHold)
                {
                    Console.WriteLine(emoji.Key);
                }

            }
        }

    }
}

