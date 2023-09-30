using System;
using System.Net;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("John", 3, 16);

        Scripture scrip1 = new Scripture(ref1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        //program ends when user types quit or all the words are hidden. do while loop?
        //another option is to set a list of scriptures and let the user choose one to work on at the begining need to figure out how to set up a library of scriptures
        string response = " ";


        //Console.WriteLine(scrip1.GetDisplayText());
        do
        {
            Console.Clear();
            Console.WriteLine(scrip1.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type \"quit\" to finish: ");
            response = Console.ReadLine();
            scrip1.HideRandomWords(3);
            if (scrip1.IsCompletelyHidden() == true)
            {
                response = "quit";
            }


        } while (response != "quit");

    }
}