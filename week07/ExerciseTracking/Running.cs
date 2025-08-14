using System;

public class Running : Activity
{
    private double _distance; // in kilometers

    public Running(DateTime date, int minutes, double distanceKm)
        : base(date, minutes)
    {
        _distance = distanceKm;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (GetDistance() / Minutes) * 60;

    public override double GetPace() => Minutes / GetDistance();
}
