using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._jobTitle = "Software Engineer";
        Job1._company = "Microsoft";
        Job1._startYear = 2015;
        Job1._endYear = 2018;

        Job Job2 = new Job();
        Job2._jobTitle = "Software Engineer";
        Job2._company = "Apple";
        Job2._startYear = 2019;
        Job2._endYear = 2020;

        //Job1.DisplayJobDetails();
        //Job2.DisplayJobDetails();

        Resume Resume1 = new Resume();
        Resume1._fullName = "Spencer Quiner";
        Resume1._jobs.Add(Job1);
        Resume1._jobs.Add(Job2);

        Resume1.DisplayResume();

    }
}