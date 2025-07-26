using System;

class Program
{
    static void Main(string[] args)
    {
        // Base assignment test
        Assignment basic = new Assignment("Samuel Esik", "Multiplication");
        Console.WriteLine(basic.GetSummary());
        Console.WriteLine();

        // Math assignment test
        MathAssignment math = new MathAssignment("Emmanuel Effiong", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        // Writing assignment test
        WritingAssignment writing = new WritingAssignment("Jesuina Emmanuel", "Latter-Day Saint History", "Joseph Smith's First Vision");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
