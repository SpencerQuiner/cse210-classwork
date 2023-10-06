public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration)
    {

    }
    public void Run()
    {
        Console.WriteLine("Get Ready. . . .");
        ShowSpinner(5);
        Console.WriteLine("List as many responses to the following prompt:");
        DisplayPrompt();
        Console.Write("You may being in: ");
        ShowCountDown(5);
        Console.WriteLine("\n");
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(GetDuration());
        while (DateTime.Now < _endTime)
        {
            GetFromUser();
        }

    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptIndex = random.Next(0, _prompts.Count);
        return _prompts[promptIndex];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"----- {GetRandomPrompt()}-----");
    }
    public void GetFromUser()
    {
        Console.Write("> ");
        _count++;
        while (Console.ReadKey().Key != ConsoleKey.Enter)
        {
        }
        Console.WriteLine("");
    }
    public int GetCount()
    {
        return _count;
    }
}

