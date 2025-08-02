using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            elapsed += 4;

            if (elapsed >= _duration) break;

            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
            elapsed += 6;
        }

        DisplayEndingMessage();
    }
}
