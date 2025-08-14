using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 8, 13), 30, 5.0),
            new Cycling(new DateTime(2025, 8, 14), 45, 20.0),
            new Swimming(new DateTime(2025, 8, 15), 25, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
