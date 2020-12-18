using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isTrue = ValidateLenght(password) && 
                ValidateLettersAndDigits(password) && 
                ValidateTwoDigits(password);

            if(isTrue)
            {
                Console.WriteLine("Password is valid");
            }
            if (!ValidateLenght(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if(!ValidateLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if(!ValidateTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");

            }
        }

        private static bool ValidateTwoDigits(string password)
        {
            int count = 0;
            foreach (char charche in password)
            {
                if (char.IsDigit(charche))
                {
                    count++;
                }
            }
            if(count >= 2)
            {
                return true;
            }
     
            return false;
        }


        private static bool ValidateLettersAndDigits(string password)
        {
           
            foreach(char charche in password)
            {
                if(!char.IsLetterOrDigit(charche))
                {
              
                    return false;
                }

            }
                return true;
        }

        private static bool ValidateLenght(string password)
        {
            if (password.Length>=6 && password.Length<=10)
            {
                bool isTrue = true;
                return true;
            }
          
            return false;
        }
    }
}
