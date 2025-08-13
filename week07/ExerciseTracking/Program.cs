using System;
using System.Collections.Generic;

// ===== Base Class =====
public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date => _date;
    public int Minutes => _minutes;

    // Abstract methods for calculations
    public abstract double GetDistance(); // km or miles depending on activity
    public abstract double GetSpeed();    // kph or mph
    public abstract double GetPace();     // min per km or min per mile

    // Common summary method
    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_minutes} min) - " +
               $"Distance: {GetDistance():0.00}, Speed: {GetSpeed():0.00}, Pace: {GetPace():0.00}";
    }
}

// ===== Derived Class: Running =====
public class Running : Activity
{
    private double _distance; // in kilometers

    public Running(DateTime date, int minutes, double distanceKm) : base(date, minutes)
    {
        _distance = distanceKm;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (GetDistance() / Minutes) * 60;

    public override double GetPace() => Minutes / GetDistance();
}

// ===== Derived Class: Cycling =====
public class Cycling : Activity
{
    private double _speed; // in kph

    public Cycling(DateTime date, int minutes, double speedKph) : base(date, minutes)
    {
        _speed = speedKph;
    }

    public override double GetDistance() => (_speed * Minutes) / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}

// ===== Derived Class: Swimming =====
public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Convert laps to kilometers
        return (_laps * 50) / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
}

// ===== Program Entry Point =====
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
// This code defines a base class `Activity` and three derived classes: `Running`, `Cycling`, and `Swimming`.
// Each derived class implements methods to calculate distance, speed, and pace, and provides a summary