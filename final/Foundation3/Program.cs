using System;

class Program
{
    static void Main(string[] args)
    {
        Address venue1 = new Address("4126 SE Block St.", "Albaquerque", "NM");
        Address venue2 = new Address("80379 Broadway St. Suite 47B", "New York", "NY");
        Address venue3 = new Address("123 Magic Ave.", "Portland", "OR");

        Lecture event1 = new Lecture("Polymorphism and C#", "An indepth discussion of the coding principle of polymorphism.", "11/5/2023", "6:30 PM", venue2, "C.M.O.T. Dibbler", 150);
        Reception event2 = new Reception("New Year Charity Fundraiser and roast pig dinner", "Charity fundraiser event sponsered by local Fire and Policemans unions.", "12/31/2023", "11 PM", venue3, "flamingpigs@policfire.org", 200);
        OutdoorGathering event3 = new OutdoorGathering("Albaquerque Ornamental Tortise Garden Party", "Annual garden party for the Albaquerque Ornamental Tortise Society. No turtles allowed.", "5/23/2024", "4:30 PM", venue1, "Sunny");

        Console.WriteLine(event1.ShortDescription());
        Console.WriteLine(event1.StandardDetails());
        Console.WriteLine(event1.FullDetails());

        Console.WriteLine(event2.ShortDescription());
        Console.WriteLine(event2.StandardDetails());
        Console.WriteLine(event2.FullDetails());

        Console.WriteLine(event3.ShortDescription());
        Console.WriteLine(event3.StandardDetails());
        Console.WriteLine(event3.FullDetails());

    }
}