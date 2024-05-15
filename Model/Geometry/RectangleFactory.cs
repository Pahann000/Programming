using System.Drawing;

/// <summary>
/// Класс, 
/// </summary>
internal class RectangleFactory
{
    /// <summary>
    /// Создает новый прямоугольник. 
    /// </summary>
    /// <param name="size">Количество прямоугольников.</param>
    /// <param name="width">Ширина прямоугольника.</param>
    /// <param name="height">Высота прямоугольника.</param>
    /// <returns>Возращает новый прямоугольник со случайными параметрами.</returns>
    public static Rectangle[] Randomize(int size, int width, int height)
    {
        Rectangle[] myRectangles = new Rectangle[size];
        Random ran = new Random();

        for (int i = 0; i < size; i++)
        {
            myRectangles[i] = new Rectangle();
            myRectangles[i].RectangleWidth = ran.Next(10, 200);
            myRectangles[i].RectangleHeight = ran.Next(10, 200);
            myRectangles[i].CenterOfRectangle = new Point2D(ran.Next(0, width), ran.Next(0, height));
        }

        return myRectangles;
    }
}

