internal class Point2D
{
    public double _x;
    public double _y;

    public double X
    {
        get { return _x; }
        private set
        {
            Validator.AssertValueInRange(value, 0, 800);
            _x = value;
        }
    }

    public double Y
    {
        get { return _y; }
        private set
        {
            Validator.AssertValueInRange(value, 0, 800);
            _y = value;
        }
    }
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return $"X = {X}; Y = {Y};";
    }

    public static Point2D operator +(Point2D point1, Point2D point2)
    {
        return new Point2D(point1.X + point2.X, point1.Y + point2.Y);
    }

    public static Point2D operator -(Point2D point1, Point2D point2)
    {
        return new Point2D(point1.X - point2.X, point1.Y - point2.Y);
    }

}

