using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment Assign1 = new Assignment("John Smith", "Spanish");

        string summary = Assign1.GetSummary();
        Console.WriteLine($"{summary}");

        MathAssignment Assign2 = new MathAssignment("Bob Sagan", "Calculus", "7.2", "1-35");
        string summary2 = Assign2.GetSummary();
        string homework = Assign2.GetHomeworkList();
        Console.WriteLine($"{summary2}");
        Console.WriteLine($"{homework}");

        WritingAssignment Assign3 = new WritingAssignment("Jaime Wok", "English", "Down the rabbit hole");
        Console.WriteLine(Assign3.GetSummary());
        Console.WriteLine(Assign3.GetWrittingInformation());

    }
}