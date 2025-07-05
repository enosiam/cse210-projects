using System;

class Program
{
    // Function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to prompt and return user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt and return user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to return the square of a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the final result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }

    // Main function
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squared = SquareNumber(favoriteNumber);

        DisplayResult(userName, squared);
    }
}
