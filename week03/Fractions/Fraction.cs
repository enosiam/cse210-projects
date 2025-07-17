public int GetNumerator()
{
    return numerator;
}

public void SetNumerator(int value)
{
    numerator = value;
}

public int GetDenominator()
{
    return denominator;
}

public void SetDenominator(int value)
{
    if (value != 0)
    {
        denominator = value;
    }
    else
    {
        Console.WriteLine("Denominator cannot be zero. Setting to 1.");
        denominator = 1;
    }
}
