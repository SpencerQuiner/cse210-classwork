using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int numberGuessed = 0;
            int i = 0;

            /*Console.Write("What is the magic number? ");
            string answer = Console.ReadLine();
            magicNumber = int.Parse(answer);*/

            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                numberGuessed = int.Parse(guess);
                i = i++;
                Console.Write($"{i}");
                if (numberGuessed > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (numberGuessed < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"you made {i} Guesses.");
                }
            } while (numberGuessed != magicNumber);

            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine();
        }

    }
}