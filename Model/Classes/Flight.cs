class Flight 
{
    private string _departurePoint;
    private string _destination;
    private int _flightTimeInMinutes;
    public string DeparturePoint
    {
        get { return _departurePoint; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _departurePoint = value;
        }
    }
    public string Destination
    {
        get { return _destination; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _destination = value;
        }
    }
    public int FlightTimeInMinutes
    {
        get { return _flightTimeInMinutes; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _flightTimeInMinutes = value;
        }
    }

    public Flight()
    {
        DeparturePoint = "Tomsk";
        Destination = "Moscow";
        FlightTimeInMinutes = 265;
    }

    public Flight(string departurePoint, string destination, int flightTimeInMinutes)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        FlightTimeInMinutes = flightTimeInMinutes;
    }
}