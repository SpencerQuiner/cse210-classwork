using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activityList = new List<Activity>();

        Running running1 = new Running(4.82, 30.0);
        _activityList.Add(running1);

        Swimming swimming1 = new Swimming(0.0, 45.0, 25);
        _activityList.Add(swimming1);

        StationaryBike bike1 = new StationaryBike(10.5, 40);
        _activityList.Add(bike1);

        foreach (Activity Exercise in _activityList)
        {
            Console.WriteLine(Exercise.Summary());
        }
    }
}