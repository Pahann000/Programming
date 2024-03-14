class Time
{
    private int _hours;
    private int _minutes;
    private int _seconds;

    public int Hours
    {
        get { return _hours; }
        set
        {
            if (value < 0 && value > 23) throw new ArgumentOutOfRangeException();
            _hours = value;
        }
    }
    public int Minutes
    {
        get { return _minutes; }
        set
        {
            if (value < 0 && value > 59) throw new ArgumentOutOfRangeException();
            _minutes = value;
        }
    }
    public int Seconds
    {
        get { return _seconds; }
        set
        {
            if (value < 0 && value > 59) throw new ArgumentOutOfRangeException();
            _seconds = value;
        }
    }
    public Time()
    {
        Hours = 20;
        Minutes = 23;
        Seconds = 47;
    }
    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
}