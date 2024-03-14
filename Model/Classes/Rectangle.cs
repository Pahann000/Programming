using System.ComponentModel.DataAnnotations;

class Rectangle 
{
    private double _rectangleWidth;
    private double _rectangleHeight;
    private string _color;
    readonly int _id;
    static int _allRectanglesCount;

    public double RectangleHeight
    {
        get { return _rectangleHeight; }
        set
        {
            if(value < 0) throw new ArgumentOutOfRangeException();
            _rectangleHeight = value;
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
    public Color Color { get; set; }
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
        RectangleHeight = 10;
        RectangleWidth = 20;
        Color = Color.Red;
        _id = ++_allRectanglesCount;
    }
    public Rectangle(int height, int width, Color color)
    {
        RectangleHeight = height;
        RectangleWidth = width;
        Color = color;
        _id = ++_allRectanglesCount;
    }
}