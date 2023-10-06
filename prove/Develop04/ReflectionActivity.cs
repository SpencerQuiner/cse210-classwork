public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<string> _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };

    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {


    }
    public void Run()
    {
        Console.WriteLine("Get Ready. . . .");
        ShowSpinner(5);
        Console.WriteLine("Consider the following Prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind press enter to continue. ");
        Console.ReadKey(true);
        Console.WriteLine("Now ponder on each of the following as they relate to this experience.");
        Console.Write("You may begin in. . .");
        ShowCountDown(5);
        Console.Clear();
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(GetDuration());
        while (DateTime.Now < _endTime)
        {
            DisplayQuestion();
            ShowSpinner(20);
        }


    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptIndex = random.Next(0, _prompts.Count);
        return _prompts[promptIndex];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int questionIndex = random.Next(0, _questions.Count);
        return _questions[questionIndex];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"----- {GetRandomPrompt()} -----");
    }
    public void DisplayQuestion()
    {
        Console.WriteLine($" > {GetRandomQuestion()}");
    }
}

