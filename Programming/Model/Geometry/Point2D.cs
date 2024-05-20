/// <summary>
/// Хранит данные об точке в двумерном пространстве.
/// </summary>
internal class Point2D
{
    /// <summary>
    /// Координата X объекта.
    /// </summary>
    public double _x;

    /// <summary>
    /// Координата Y объекта.
    /// </summary>
    public double _y;

    /// <summary>
    /// Возращает и задает координату X.
    /// </summary>
    public double X
    {
        get { return _x; }
        private set
        {
            Validator.AssertValueInRange(value, 0, 800);
            _x = value;
        }
    }

    /// <summary>
    /// Возращает и задает координату Y.
    /// </summary>
    public double Y
    {
        get { return _y; }
        private set
        {
            Validator.AssertValueInRange(value, 0, 800);
            _y = value;
        }
    }

    /// <summary>
    /// Экземпляр класса <see cref="Point2D"/>
    /// </summary>
    /// <param name="x">Координата X</param>
    /// <param name="y">Координата Y</param>
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Запись данных в строку
    /// </summary>
    /// <returns> Возращает строку с координатами X и Y.</returns>
    public override string ToString()
    {
        return $"X = {X}; Y = {Y};";
    }

    /// <summary>
    /// Перегруженный оператор сложения для точек.
    /// </summary>
    /// <param name="point1">Первая точка.</param>
    /// <param name="point2">Вторая точка.</param>
    /// <returns></returns>
    public static Point2D operator +(Point2D point1, Point2D point2)
    {
        return new Point2D(point1.X + point2.X, point1.Y + point2.Y);
    }

    /// <summary>
    /// Перегруженный оператор сложения для точек.
    /// </summary>
    /// <param name="point1">Первая точка.</param>
    /// <param name="point2">Вторая точка.</param>
    /// <returns></returns>
    public static Point2D operator -(Point2D point1, Point2D point2)
    {
        return new Point2D(point1.X - point2.X, point1.Y - point2.Y);
    }

}

