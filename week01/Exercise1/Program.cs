using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine($"Your name is,  {first} {last}");
        
    }
}