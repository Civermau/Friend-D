using System;
using System.Collections.Generic;

public class Structure
{
    string name;
    List<string> activities;
    int openTime;
    int closeTime;
    bool allDay;

    public Structure(string name, int openTime, int closeTime, bool allDay)
    {
        this.name = name;
        this.activities = new List<string>();
        this.openTime = openTime;
        this.closeTime = closeTime;
        this.allDay = allDay;
    }

    public void AddActivity(string activity)
    {
        activities.Add(activity);
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Place: " + name);
        Console.WriteLine("Opening Time: " + openTime);
        Console.WriteLine("Closing Time: " + closeTime);
        Console.WriteLine("Open All Day: " + allDay);
        Console.WriteLine("Activities available:");
        foreach (var activity in activities)
        {
            Console.WriteLine("- " + activity);
        }
    }
}
