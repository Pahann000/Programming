class Rectangle
{
    private double _rectangleWidth;
    private double _rectangleLenght;
    readonly int _id;
    private static int _allRectanglesCount;
    public Point2D CenterOfRectangle;

    public double RectangleLength
    {
        get { return _rectangleLenght; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _rectangleLenght = value;
        }
    }
    public double RectangleWidth
    {
        get { return _rectangleWidth; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _rectangleWidth = value;
        }
    }

    public Colors RectangleColor { get; set; }
    public static int AllRectanglesCount
    {
        get { return _allRectanglesCount; }
    }
    public int Id
    {
        get { return _id; }
    }
    public Rectangle()
    {
        RectangleLength = 10;
        RectangleWidth = 20;
        RectangleColor = Colors.White;
        CenterOfRectangle = new Point2D(7, 8);
        _id = ++_allRectanglesCount;
    }
    public Rectangle(double lenght, double width, Colors color, double _x, double _y)
    {
        RectangleLength = lenght;
        RectangleWidth = width;
        RectangleColor = color;
        CenterOfRectangle = new Point2D(_x + RectangleWidth/2, _y + RectangleLength/2);
        _id = ++_allRectanglesCount;
    }
}