using System;

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

    public abstract double GetDistance(); // km or miles depending on activity
    public abstract double GetSpeed();    // kph or mph
    public abstract double GetPace();     // min per km or min per mile

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_minutes} min) - " +
               $"Distance: {GetDistance():0.00}, Speed: {GetSpeed():0.00}, Pace: {GetPace():0.00}";
    }
}
