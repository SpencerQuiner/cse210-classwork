using System;
using System.IO;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = 0;
        Console.WriteLine("Welcome to the Journal Program!");
        Journal myJournal = new Journal();
        do
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Type the number of your selection. ");
            userSelection = int.Parse(Console.ReadLine());


            switch (userSelection)
            {
                case 1:
                    {
                        Entry newEntry = new Entry();
                        DateTime theCurrentTime = DateTime.Now;
                        newEntry._date = theCurrentTime.ToShortDateString();
                        Console.WriteLine($"{theCurrentTime.ToShortDateString()}");
                        PromptGenerator prompt = new PromptGenerator();
                        newEntry._promptText = prompt.GetRandomPrompt();
                        Console.WriteLine("Type your entry.");
                        newEntry._entryText = Console.ReadLine();
                        newEntry.Display();
                        myJournal.AddEntry(newEntry);

                        break;
                    }
                case 2:
                    {
                        myJournal.DisplayAll();
                        break;
                    }
                case 3:
                    {
                        Console.Write("Enter the name of the file you want to load: ");
                        string fileName = Console.ReadLine();
                        myJournal.LoadFromFile($"{fileName}.csv");
                        break;
                    }
                case 4:
                    {
                        Console.Write("Enter the file name where you want to save with out a file type extention: ");
                        string fileName = Console.ReadLine();
                        myJournal.SaveToFile($"{fileName}.csv");
                        break;
                    }
            }

        } while (userSelection != 5);
    }
}