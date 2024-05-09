using System.Drawing;

internal class CollisionManager
{
    public static bool IsCollision(Ring ring1, Ring ring2)
    {
        double path = Math.Sqrt(
            Math.Pow(Math.Abs(ring1.CenterOfRing.X - ring2.CenterOfRing.X), 2) +
            Math.Pow(Math.Abs(ring1.CenterOfRing.Y - ring2.CenterOfRing.Y), 2));

        if ((ring1.InnerRadius + ring2.InnerRadius) <= path) return false;
        return
            !(ring1.InnerRadius + path < ring2.OuterRadius ||
            ring2.InnerRadius + path < ring1.OuterRadius);
    }
    public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        Point2D region = new Point2D(
            Math.Abs(rectangle2.CenterOfRectangle.X - rectangle1.CenterOfRectangle.X),
            Math.Abs(rectangle2.CenterOfRectangle.Y - rectangle1.CenterOfRectangle.Y));

        Point2D rect1Half = new Point2D(rectangle1.RectangleWidth / 2, rectangle1.RectangleHeight / 2);
        Point2D rect2Half = new Point2D(rectangle2.RectangleWidth / 2, rectangle2.RectangleHeight / 2);

        Point2D minRegion = rect1Half + rect2Half;

        return region.X < minRegion.X && region.Y < minRegion.Y;
    }
}

