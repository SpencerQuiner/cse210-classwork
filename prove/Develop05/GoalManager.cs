using System.Diagnostics;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public int GetScore()
    {
        return _score;
    }
    public void SetScore(int points)
    {
        _score = _score + points;
    }
    public void Start()
    {
        int selection = 0;
        do
        {
            Console.WriteLine($"You have {_score} points. \n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    {
                        Console.Clear();
                        CreateGoal();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        ListGoalDetails();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        SaveGoals();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        LoadGoals();
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        RecordEvent();
                        break;
                    }

            }

        } while (selection != 6);
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. A Simple Goal");
        Console.WriteLine("2. An Eternal Goal");
        Console.WriteLine("3. A Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        int goalSelect = int.Parse(Console.ReadLine());
        switch (goalSelect)
        {
            case 1:
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    bool completed = false;
                    _goals.Add(new SimpleGoal(name, description, points, completed));
                    break;
                }
            case 2:
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                }
            case 3:
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    int amountComplete = 0;
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountComplete));
                    break;
                }
        }
    }
    public void ListGoalDetails()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }
    public void ListGoalNames()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetName()}");
            index++;
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine($"The goals are. ");
        ListGoalNames();
        Console.WriteLine($"Which Goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine());
        int points = _goals[goalIndex - 1].RecordEvent();
        SetScore(points);

    }
    public void SaveGoals()
    {
        DateTime _date = DateTime.Now;
        _date.ToShortDateString();
        Console.WriteLine("What is the filename or the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outPutFile = new StreamWriter(fileName))
        {
            outPutFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                string goalinfo = goal.GetStringRepresentation();
                outPutFile.WriteLine($"{goalinfo}");
                Console.WriteLine(goalinfo);
            }
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename or the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamReader inputfile = new StreamReader(fileName))
        {
            _score = int.Parse(inputfile.ReadLine());
        }
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines.Skip<string>(1))
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string goalData = parts[1];

            if (goalType == "Simple Goal")
            {
                string[] section = goalData.Split(";");
                string name = section[0];
                string description = section[1];
                string points = section[2];
                string completed = section[3];

                _goals.Add(new SimpleGoal(name, description, int.Parse(points), bool.Parse(completed)));
            }
            else if (goalType == "Eternal Goal")
            {
                string[] section = goalData.Split(";");
                string name = section[0];
                string description = section[1];
                string points = section[2];
                _goals.Add(new EternalGoal(name, description, int.Parse(points)));
            }
            else if (goalType == "Checklist Goal")
            {
                string[] section = goalData.Split(";");
                string name = section[0];
                string description = section[1];
                string points = section[2];
                string bonus = section[3];
                string target = section[4];
                string amountComplete = section[5];
                _goals.Add(new ChecklistGoal(name, description, int.Parse(points), int.Parse(bonus), int.Parse(target), int.Parse(amountComplete)));
            }
            else
            {

            }
        }
    }

}