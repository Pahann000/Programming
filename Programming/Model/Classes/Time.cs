/// <summary>
/// Хранит данные о времени в часах, минутах, секундах.
/// </summary>
class Time
{
    /// <summary>
    /// Хранит данные о кол-ве часов.
    /// </summary>
    private int _hours;

    /// <summary>
    /// Хранит данные о кол-ве минут.
    /// </summary>
    private int _minutes;

    /// <summary>
    /// Хранит данные о кол-ве секунд.
    /// </summary>
    private int _seconds;

    /// <summary>
    /// Возращает и задает кол-во часов.
    /// Задает через проверку при помощи класса <see cref="Validator"/>. Кол-во часов должно находитьсф в промежутке от 0 до 23.
    /// </summary>
    public int Hours
    {
        get { return _hours; }
        set
        {
            Validator.AssertValueInRange(value, 0, 23);
            _hours = value;
        }
    }

    /// <summary>
    /// Возращает и задает кол-во минут.
    /// Задает через проверку при помощи класса <see cref="Validator"/>. Кол-во минут должно находитьсф в промежутке от 0 до 59.
    /// </summary>
    public int Minutes
    {
        get { return _minutes; }
        set
        {
            Validator.AssertValueInRange(value, 0, 59);
            _minutes = value;
        }
    }

    /// <summary>
    /// Возращает и задает кол-во секунд.
    /// Задает через проверку при помощи класса <see cref="Validator"/>. Кол-во секунд должно находитьсф в промежутке от 0 до 59.
    /// </summary>
    public int Seconds
    {
        get { return _seconds; }
        set
        {
            Validator.AssertValueInRange(value, 0, 59);
            _seconds = value;
        }
    }

    /// <summary>
    /// Экземпляр класса <see cref="Time"/>
    /// </summary>
    public Time()
    {
        Hours = 20;
        Minutes = 23;
        Seconds = 47;
    }

    /// <summary>
    /// Экземпляр класса <see cref="Time"/>
    /// </summary>
    /// <param name="hours">Часы.</param>
    /// <param name="minutes">Минуты.</param>
    /// <param name="seconds">Секунды.</param>
    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
}