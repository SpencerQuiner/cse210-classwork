using System;

class Program
{
    //I have added a logging feature to the program. Each activity is automatically logged and the user can load that log to view past activity.
    static void Main(string[] args)
    {
        int userSelection = 0;
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activitiy.");
            Console.WriteLine("2. Start Reflection Activity.");
            Console.WriteLine("3. Start Listing Activity.");
            Console.WriteLine("4. Load activity log.");
            Console.WriteLine("5. Quit.");
            Console.Write("Select a choice from the menu. ");
            userSelection = int.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case 1:
                    {
                        BreathingActivity NewActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                        NewActivity.DisplayStartingMessage();
                        NewActivity.Run();
                        NewActivity.DisplayEndingMessage();
                        NewActivity.SaveToLog();
                        Console.Clear();
                        break;
                    }
                case 2:
                    {
                        ReflectionActivity NewActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resiliance. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                        NewActivity.DisplayStartingMessage();
                        NewActivity.Run();
                        NewActivity.DisplayEndingMessage();
                        NewActivity.SaveToLog();
                        Console.Clear();
                        break;
                    }
                case 3:
                    {
                        ListingActivity NewActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, 0);
                        NewActivity.DisplayStartingMessage();
                        NewActivity.Run();
                        Console.WriteLine($"You listed {NewActivity.GetCount()} items.");
                        NewActivity.DisplayEndingMessage();
                        NewActivity.SaveToLog();
                        Console.Clear();
                        break;
                    }
                case 4:
                    {
                        Activity NewActivity = new Activity("activity", "load activity log", 0);
                        NewActivity.LoadActivityLog();
                        break;
                    }
            }


        } while (userSelection != 5);

    }
}