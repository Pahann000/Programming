class Rectangle
{
    private double _rectangleWidth;
    private double _rectangleLenght;
    readonly int _id;
    static int _allRectanglesCount;

    public double RectangleLength
    {
        get { return _rectangleLenght; }
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException();
            _rectangleLenght = value;
        }
    }
    public double RectangleWidth
    {
        get { return _rectangleWidth; }
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException();
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
        _id = ++_allRectanglesCount;
    }
    public Rectangle(int lenght, int width, Colors color)
    {
        RectangleLength = lenght;
        RectangleWidth = width;
        RectangleColor = color;
        _id = ++_allRectanglesCount;
    }
}