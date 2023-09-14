using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int entryNumber = 0;
        int sum = 0;

        do
        {
            Console.Write("Enter number: ");
            string entry = Console.ReadLine();
            entryNumber = int.Parse(entry);
            if (entryNumber != 0)
            {
                numbers.Add(entryNumber);
            }
        } while (entryNumber != 0);
        numbers.Sort();

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
            sum += numbers[i];
        }

        Console.WriteLine($"The sum is: {sum}");
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");
        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");

    }
}