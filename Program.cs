using System;

namespace codecademy
{
    class Program
    {
        static void MoneyMaker()
        {
            Console.Clear();
            Console.WriteLine("Insert an amount of coins:");
            double coins = (Math.Floor(Double.Parse(Console.ReadLine())));
            
            double goldCoins = Math.Floor(coins/10);
            double silverCoins = Math.Floor((coins%10)/5);
            double bronzeCoins = Math.Floor((coins%10)%5);
            Console.WriteLine("\n"+coins+" coins are equal to:");
            Console.WriteLine("Gold coins: "+goldCoins);
            Console.WriteLine("Silver coins: "+silverCoins);
            Console.WriteLine("Bronze coins: "+bronzeCoins);
        }

        static void PasswordCheck()
        {
            int minLength = 8;
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string symbols = "!@#$%&*()/?;:><.,";
            
            Console.Clear();
            Console.WriteLine("INSIRA SUA SENHA:");
            string userInput = Console.ReadLine();
            int score = 0;
            
            if (userInput.Length >= minLength)
            {
                score++;
            }

            for (int i = 0; i < upper.Length; i++)
            {
                if (userInput.Contains(upper[i]))
                {
                    score++;
                    break;
                }
            }
            for (int i = 0; i < lower.Length; i++)
            {
                if (userInput.Contains(lower[i]))
                {
                    score++;
                    break;
                }
            }
            for (int i = 0; i < digits.Length; i++)
            {
                if (userInput.Contains(digits[i]))
                {
                    score++;
                    break;
                }
            }
            for (int i = 0; i < symbols.Length; i++)
            {
                if (userInput.Contains(symbols[i]))
                {
                    score++;
                    break;
                }
            }
            if (userInput == "password" || userInput == "1234")
            {
                score = 0;
            }
            switch (score)
            {
                case 1:
                    Console.WriteLine("Weak password.");
                    break;
                case 2:
                    Console.WriteLine("Average password.");
                    break;
                case 3:
                    Console.WriteLine("Strong password.");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Very strong password!");
                    break;
                default:
                    Console.WriteLine("Invalid password!");
                    break;
            }
        }

        static void CaesarCipher()
        {
            Console.Clear();
            Console.WriteLine("Type your message:");
            string message = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Type C to Cipher, or D to Decipher:");
            string modeChoice = Console.ReadLine();
            
            string result;
            if (modeChoice == "C")
            {
                result = message.Cipher();
            }
            else if (modeChoice == "D")
            {
                result = message.Decipher();
            }
            else
            {
                result = "ERROR";
            }
            
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            CaesarCipher();
        }
    }
}