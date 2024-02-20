using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        List<Activity> activities = new List<Activity>();

        Running running = new Running("03 Nov 2022", "30", "3");
        activities.Add(running);

        Bicycle bicycle = new Bicycle("23 Jul 2023", "60", "8");
        activities.Add(bicycle);

        Swimming swimming = new Swimming("20 Feb 2024", "60", "50");
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}