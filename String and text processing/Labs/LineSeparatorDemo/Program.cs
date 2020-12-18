using System;

namespace LineSeparatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] stringAsCharArr = new char[] { 'a', 'b', 'c' };
            string text = new string(stringAsCharArr);

            string LineSeparator = new string(c: '-', count: 500); //500 pyti ------
            Console.WriteLine(LineSeparator);

            ///////////////////////////INDEXOF lastIndexOf
            string fruits = "banana, apple, kiwi, banana, apple";
            Console.WriteLine(fruits.IndexOf("banana")); // Дава 0-ла първия
            Console.WriteLine(fruits.IndexOf("orange")); // Дава -1, ако няма такова е -1!!!!
            Console.WriteLine(fruits.IndexOf(value:"banana",startIndex: 13)); // Дава 21 но проверява от 13 индекс до края
            Console.WriteLine(fruits.LastIndexOf("banana")); //Dava  index 21 za banana 

            //////////////////////////////////////////// Kolko pati se povtarq edna duma v edin dalag string 
            string word = Console.ReadLine();
            string longText = Console.ReadLine(); // dalag text
            int startIndex = 0;
            int countOfRepeatWord = 0;
            while(longText.IndexOf(word,startIndex) >-1 )
            {
                startIndex = text.IndexOf(word, startIndex) + 1;
                Console.WriteLine($"{word} fout at {startIndex}");
                countOfRepeatWord++;


                //////////////////////////////////// Replace(math,replacement)  реплейсва всички такива кей с нов
                string textBefore = "Hello, john@sftuni.bg, you have been using john@sftuni.bg in you registration";
                string replacedText = text.Replace("john@sftuni.bg", "john@softuni.com"); //Първото е търсено, 2рото с него сменяме
            }
        }
    }
}
