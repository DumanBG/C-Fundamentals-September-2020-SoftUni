using System;

namespace _25Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();


            string password = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }

            int count = 0;
            while (count < 4)
            {
                string input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    return;
                }
                else if (count < 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                count++;
            }
            if (count == 4)
            {
                Console.WriteLine($"User {userName} blocked!");
            }


        }



    }
}

