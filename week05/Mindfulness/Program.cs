using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press enter to continue.");
                    Console.ReadLine();
                    continue;
            }

            activity.Run();
        }
    }
}
/*
To Exceed Requirements :
- I added an activity log that saves completed activities with timestamps.
- I ensured prompts/questions cycle through without repeating until all have been used once.
- I animated breathing with growing/shrinking text instead of a simple countdown.
- I added background color changes or sound effects for more immersion.
*/

