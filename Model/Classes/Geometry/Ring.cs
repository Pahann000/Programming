internal class Ring
{
    private double _outerRadius;
    private double _innerRadius;
    public Point2D CenterOfRing;
    private double AreaOfRing;

    public double OuterRadius
    {
        get { return _outerRadius; } 
        set 
        {
            Validator.AssertValueInRange(value, 0, _innerRadius);
            _outerRadius = value;
        }
    }
    public double InnerRadius
    {
        get { return _innerRadius; }
        set
        {
            Validator.AssertValueInRange(value, _outerRadius, 20);
            _innerRadius = value;
        }
    }
    public Ring(double outerRadius, double innerRadius, Point2D centerOfRing, double area)
    {
        OuterRadius = outerRadius;
        InnerRadius = innerRadius;
        CenterOfRing = centerOfRing;
        AreaOfRing = (Math.PI*Math.Pow(_innerRadius, 2) - (Math.PI*Math.Pow(_outerRadius, 2)));
    }
}
