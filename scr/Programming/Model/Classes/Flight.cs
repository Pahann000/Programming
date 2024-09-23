/// <summary>
/// Хранит данные о авиарейсе.
/// </summary>
class Flight 
{
    /// <summary>
    /// Хранит данные о месте вылета.
    /// </summary>
    private string _departurePoint;

    /// <summary>
    /// Хранит данные о пункте назначения.
    /// </summary>
    private string _destination;

    /// <summary>
    /// Хранит данные о длительности полета.
    /// </summary>
    private int _flightTimeInMinutes;

    /// <summary>
    /// Возращает и задает место вылета.
    /// </summary>
    public string DeparturePoint
    {
        get { return _departurePoint; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _departurePoint = value;
        }
    }

    /// <summary>
    /// Возращает и задает пункт назначения.
    /// </summary>
    public string Destination
    {
        get { return _destination; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _destination = value;
        }
    }

    /// <summary>
    /// Возращает и задает продолжительность полета.
    /// Задает через проверку при помощи класса <see cref="Validator"/>. Длительность полета должна быть положительным числом.
    /// </summary>
    public int FlightTimeInMinutes
    {
        get { return _flightTimeInMinutes; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _flightTimeInMinutes = value;
        }
    }

    /// <summary>
    /// Экземпляр класса <see cref="Flight"/>
    /// </summary>
    public Flight()
    {
        DeparturePoint = "Tomsk";
        Destination = "Moscow";
        FlightTimeInMinutes = 265;
    }

    /// <summary>
    /// Экземпляр класса <see cref="Flight"/>
    /// </summary>
    /// <param name="departurePoint"></param>
    /// <param name="destination"></param>
    /// <param name="flightTimeInMinutes"></param>
    public Flight(string departurePoint, string destination, int flightTimeInMinutes)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        FlightTimeInMinutes = flightTimeInMinutes;
    }
}