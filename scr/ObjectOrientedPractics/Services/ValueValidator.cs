/// <summary>
/// Содержит методы, проперяющие правильность введенных значений.
/// </summary>
class ValueValidator
{
    /// <summary>
    /// Проверяет строку на длину.
    /// </summary>
    /// <param name="value">Проверяемая строка.</param>
    /// <param name="maxLength">Максимально возможная длина.</param>
    /// <param name="propertyName">Название свойства, где используется метод.</param>
    /// <returns>Строка, прошедшая проверку.</returns>
    /// <exception cref="ArgumentException"></exception>
   public static string AssertStringOnLength(string value, int maxLength, string propertyName)
    {
        if (value.Length > maxLength) 
        {
            throw new ArgumentException($" {propertyName} не должно быть более {maxLength} символов в длину");
        }
        else
        {
            return value;
        }
    }

    /// <summary>
    /// Проверяет вещественное число на правильность.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="minNumber">Минимально возможное значение.</param>
    /// <param name="maxNumber">Максимально возможное значение.</param>
    /// <param name="propertyName">Название свойства, где используется данный метод.</param>
    /// <returns>Значение, если оно проходит проверку</returns>
    /// <exception cref="ArgumentException"></exception>
    public static double AssertNumberInRange(double value, int minNumber, int maxNumber, string propertyName)
    {
        if (value > maxNumber || value < minNumber)
        {
            throw new ArgumentException($" {propertyName} не должно быть более {maxNumber} или менее {minNumber}");
        }
        else
        {
            return value;
        }
    }

    /// <summary>
    /// Проверяет целое число на правильность.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="minNumber">Минимально возможное значение.</param>
    /// <param name="maxNumber">Максимально возможное значение.</param>
    /// <param name="propertyName">Название свойства, где используется данный метод.</param>
    /// <returns>Значение, если оно проходит проверку</returns>
    /// <exception cref="ArgumentException"></exception>
    public static int AssertNumberInRange(int value, int minNumber, int maxNumber, string propertyName)
    {
        if (value > maxNumber || value < minNumber)
        {
            throw new ArgumentException($" {propertyName} не должно быть более {maxNumber} или менее {minNumber}");
        }
        else
        {
            return value;
        }
    }

    /// <summary>
    /// Проверка строки на отсутствие символов или null
    /// </summary>
    /// <param name="str">Строка</param>
    /// <param name="propertyName">Название свойства, которое вызвало метод</param>
    public static void CheckStringOnNullOrEmpty(string str, string propertyName)
    {
        if (String.IsNullOrEmpty(str))
        {
            throw new ArgumentNullException($"свойство {propertyName} не должно быть null или пустым");
        }
    }

    /// <summary>
    /// Проверка строки на отсутствие символов или null
    /// </summary>
    /// <param name="dub">Вещественное число.</param>
    /// <param name="propertyName">Название свойства, которое вызвало метод</param>
    public static void CheckStringOnNullOrEmpty(double dub, string propertyName)
    {
        if (String.IsNullOrEmpty(Convert.ToString(dub)))
        {
            throw new ArgumentNullException($"свойство {propertyName} не должно быть null или пустым");
        }
    }
}