internal class Validator
{
    public static int AssertOnPositiveValue(int value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException($"{value} is not true");
        }
        else
        {
            return value;
        }
    }
    public static double AssertOnPositiveValue(double value)
    {
        if (value < 0) 
        {
            throw new ArgumentOutOfRangeException($"{value} is not in the range");
        }
        else
        {
            return value;
        }
    }
    public static int AssertValueInRange(int value, int min, int max)
    {
        if ((value < min) || (value > max))
        {
            throw new ArgumentOutOfRangeException($"{value} is not in the range");
        }
        else
        {
            return value;
        }
    }
    public static double AssertValueInRange(double value, double min, double max)
    {
        if ((value < min) || (value > max))
        {
            throw new ArgumentOutOfRangeException($"{value} is not in the range");
        }
        else
        {
            return value;
        }
    }
}

