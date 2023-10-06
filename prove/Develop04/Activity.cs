public class Activity
{
    //derived classes BreathingActivity, ReflectionActivity, and ListingActivity
    private string _actName;
    private string _actdescrip;
    private int _duration;
    public Activity(string name, string description, int duration)
    {
        _actName = name;
        _actdescrip = description;
        _duration = duration;
    }
    public void SetDuration()
    {
        Console.WriteLine("How long in seconds would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_actName}");
        Console.WriteLine(" ");
        Console.WriteLine(_actdescrip);
        SetDuration();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {GetDuration()} seconds of {_actName}.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("|");
        animation.Add("\\");
        animation.Add("-");
        int i = 0;
        DateTime startspin = DateTime.Now;
        DateTime endspin = startspin.AddSeconds(seconds);
        while (DateTime.Now < endspin)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    public void SaveToLog()
    {
        DateTime _date = DateTime.Now;
        _date.ToShortDateString();
        using (StreamWriter outPutFile = new StreamWriter("ActivityLog.csv", true))
        {
            outPutFile.WriteLine($"{_date},{_actName},{_duration}");
            Console.WriteLine("Saving activity to Log . . . .");
            ShowSpinner(5);
        }
    }
    public void LoadActivityLog()
    {
        string filename = "ActivityLog.csv";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string date = parts[0];
            string activity = parts[1];
            string duration = parts[2];
            Console.WriteLine($"{date} --- {activity} --- {duration}");
        }
    }

}