/// <summary>
/// Хранит данные о кольцах.
/// </summary>
internal class Ring
{
    /// <summary>
    /// Поле внешнего радиуса кольца. 
    /// </summary>
    private double _outerRadius;

    /// <summary>
    /// Поле внешнего радиуса кольца.
    /// </summary>
    private double _innerRadius;

    /// <summary>
    /// Координаты центра объекта.
    /// </summary>
    public Point2D CenterOfRing;

    /// <summary>
    /// Площадь кольца
    /// </summary>
    private double AreaOfRing;

    /// <summary>
    /// Возращает и задает внутренний радиус кольца. Должно быть не больше внешнего радиуса.
    /// </summary>
    public double OuterRadius
    {
        get { return _outerRadius; } 
        set 
        {
            Validator.AssertValueInRange(value, 0, _innerRadius);
            _outerRadius = value;
        }
    }

    /// <summary>
    /// Возращает и задает внешний радиус кольца. Не должен быть больше 20-ти.
    /// </summary>
    public double InnerRadius
    {
        get { return _innerRadius; }
        set
        {
            Validator.AssertValueInRange(value, _outerRadius, 20);
            _innerRadius = value;
        }
    }

    /// <summary>
    /// Соддает экземпляр класса <see cref="Ring"/>.
    /// </summary>
    /// <param name="outerRadius">Поле внешнего радиуса кольца.</param>
    /// <param name="innerRadius">Поле внешнего радиуса кольца.</param>
    /// <param name="centerOfRing">Координаты центра объекта.</param>
    /// <param name="area">Площадь кольца</param>
    public Ring(double outerRadius, double innerRadius, Point2D centerOfRing, double area)
    {
        OuterRadius = outerRadius;
        InnerRadius = innerRadius;
        CenterOfRing = centerOfRing;
        AreaOfRing = (Math.PI*Math.Pow(_innerRadius, 2) - (Math.PI*Math.Pow(_outerRadius, 2)));
    }
}
