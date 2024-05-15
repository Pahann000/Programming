/// <summary>
/// Хранит данные о прямоугольниках.
/// </summary>
class Rectangle
{
    /// <summary>
    /// Хранит данные о ширине прямоугольника.
    /// </summary>
    private double _rectangleWidth;

    /// <summary>
    /// Хранит данные о высоте прямоугольника.
    /// </summary>
    private double _rectangleHeight;

    /// <summary>
    /// Хранит данные о уникальном номере прямоугольника id.
    /// </summary>
    readonly int _id;

    /// <summary>
    /// Хранит данные о количестве прямоугольников.
    /// </summary>
    private static int _allRectanglesCount;

    /// <summary>
    /// Хранит данные о координатах центра прямоугольника.
    /// </summary>
    public Point2D CenterOfRectangle;

    /// <summary>
    /// Возвращает и задает высоту прямоугольника.
    /// Задает через проверку при помощи класса <see cref="Validator"/>. Значение должно быть положительным числом.
    /// </summary>
    public double RectangleHeight
    {
        get { return _rectangleHeight; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _rectangleHeight = value;
        }
    }

    /// <summary>
    /// Возвращает и задает ширину прямоугольника.
    /// Задает через проверку при помощи класса <see cref="Validator"/>. Значение должно быть положительным числом.
    /// </summary>
    public double RectangleWidth
    {
        get { return _rectangleWidth; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _rectangleWidth = value;
        }
    }

    /// <summary>
    /// Возращает и задает цвет прямоугольника.
    /// </summary>
    public Colors RectangleColor { get; set; }

    /// <summary>
    /// Возвращает номер прямоугольника.
    /// </summary>
    public static int AllRectanglesCount
    {
        get { return _allRectanglesCount; }
    }

    /// <summary>
    /// Возращает уникальный номер прямоугольника.
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Rectangle"/>
    /// </summary>
    public Rectangle()
    {
        RectangleHeight = 10;
        RectangleWidth = 20;
        RectangleColor = Colors.White;
        CenterOfRectangle = new Point2D(7, 8);
        _id = ++_allRectanglesCount;
    }
    /// <summary>
    /// Создает экземпляр класса <see cref="Rectangle"/>
    /// </summary>
    /// <param name="height">Высота прямоугольника. Должна быть числом.</param>
    /// <param name="width">Ширина прямоугольника. Должна быть числом.</param>
    /// <param name="color">Цвет прямоугольника, должен быть строкой.</param>
    /// <param name="_x">Х-координата центра прямоугольника. Должна быть числом.</param>
    /// <param name="_y">Y-координата центра прямоугольника. Должна быть числом.</param>
    public Rectangle(double height, double width, Colors color, double _x, double _y)
    {
        RectangleHeight = height;
        RectangleWidth = width;
        RectangleColor = Colors.Yellow;
        CenterOfRectangle = new Point2D(_x + RectangleWidth/2, _y + RectangleHeight/2);
        _id = ++_allRectanglesCount;
    }
}