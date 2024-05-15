/// <summary>
/// Класс проверяет целостность данных.
/// </summary>
internal class Validator
{
    /// <summary>
    /// Проверяет ввод целого числа на отрицательное значение.
    /// </summary>
    /// <param name="value">Проверяемое число.</param>
    /// <exception cref="ArgumentException"></exception>
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

    /// <summary>
    /// Проверяет ввод числа с плавающей точкой на отрицательное значение.
    /// </summary>
    /// <param name="value">Проверяемое число.</param>
    /// <exception cref="ArgumentException"></exception>
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

    /// <summary>
    /// Проверяет, находится ли целочисленное число в указанном диапазоне.
    /// </summary>
    /// <param name="value">Проверяемое число.</param>
    /// <param name="min">Целочисленный минимум.</param>
    /// <param name="max">Целочисленный максимум.</param>
    /// <exception cref="ArgumentException"></exception>
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

    /// <summary>
    /// Проверяет, находится ли дробное число в указанном диапазоне.
    /// </summary>
    /// <param name="value">Проверяемое число.</param>
    /// <param name="min">Минимум, представляющей из себя число с плавающей точкой.</param>
    /// <param name="max">Максимум, представляющей из себя число с плавающей точкой.</param>
    /// <exception cref="ArgumentException"></exception>
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

