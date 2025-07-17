using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a fraction using default constructor (1/1)
        Fraction myFraction = new Fraction();
        Console.WriteLine("Initial Fraction: " + myFraction.GetFractionString());

        // Step 2: Change the numerator and denominator
        myFraction.SetNumerator(4);
        myFraction.SetDenominator(5);

        // Step 3: Retrieve updated values
        int top = myFraction.GetNumerator();
        int bottom = myFraction.GetDenominator();

        // Step 4: Display the new values and fraction
        Console.WriteLine("Updated Numerator: " + top);
        Console.WriteLine("Updated Denominator: " + bottom);
        Console.WriteLine("Updated Fraction: " + myFraction.GetFractionString());
        Console.WriteLine("Decimal Value: " + myFraction.GetDecimalValue());
    }
}
