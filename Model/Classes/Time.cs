﻿class Time
{
    private int _hours;
    private int _minutes;
    private int _seconds;

    public int Hours
    {
        get { return _hours; }
        set
        {
            Validator.AssertValueInRange(value, 0, 23);
            _hours = value;
        }
    }
    public int Minutes
    {
        get { return _minutes; }
        set
        {
            Validator.AssertValueInRange(value, 0, 59);
            _minutes = value;
        }
    }
    public int Seconds
    {
        get { return _seconds; }
        set
        {
            Validator.AssertValueInRange(value, 0, 59);
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