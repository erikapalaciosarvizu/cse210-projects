using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 12, 08), 30, 4.0),
            new Cycling(new DateTime(2023, 12, 08), 30, 5),
            new Swimming(new DateTime(2023, 12, 08), 30, 3)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}