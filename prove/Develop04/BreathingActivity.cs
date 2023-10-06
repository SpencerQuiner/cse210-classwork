public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public void Run()
    {
        Console.WriteLine("Get Ready. . . .");
        ShowSpinner(5);
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(GetDuration());

        while (DateTime.Now < _endTime)
        {
            Console.WriteLine("\r\n");
            Console.Write("Breath in. . . .");
            ShowCountDown(5);
            Console.WriteLine("");
            Console.Write("Now breath out. . .");
            ShowCountDown(5);
            Console.WriteLine("\n");
        }

    }
}