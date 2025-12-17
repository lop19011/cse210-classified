using System;
using Foundation4;

class Program
{
    static void Main(string[] args)
    {
        Running running1 = new Running("03 Dec 2024", 30, 3.0);
        Cycling cycling1 = new Cycling("04 Dec 2024", 45, 15.0);
        Swimming swimming1 = new Swimming("05 Dec 2024", 60, 40);


        List<Activity> activities = new List<Activity>();
        activities.Add(running1);
        activities.Add(cycling1);
        activities.Add(swimming1);

        Console.WriteLine("--- Fitness Activity Tracker ---");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}