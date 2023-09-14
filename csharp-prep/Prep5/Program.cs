using System;

class Program
{

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int sqrNumber = SquareNumber(favNumber);
        DisplayResult(userName, sqrNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name. ");
        string userName = Console.ReadLine();
        //Console.WriteLine($"{userName}");
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number. ");
        string number = Console.ReadLine();
        int favNumber = int.Parse(number);
        //Console.WriteLine($"{favNumber}");
        return favNumber;
    }

    static int SquareNumber(int favNumber)
    {
        int sqrNumber = favNumber * favNumber;
        return sqrNumber;
    }

    static void DisplayResult(string userName, int sqrNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {sqrNumber}.");
    }
}