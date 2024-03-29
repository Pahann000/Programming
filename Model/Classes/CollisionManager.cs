internal class CollisionManager
{
    public bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        if (Math.Abs(rectangle1.CenterOfRectangle.X - rectangle2.CenterOfRectangle.X)
            < Math.Abs(rectangle1.RectangleWidth - rectangle2.RectangleWidth) && Math.Abs(rectangle1.CenterOfRectangle.Y - rectangle2.CenterOfRectangle.Y)
            < Math.Abs(rectangle1.RectangleLength - rectangle2.RectangleLength))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsCollision(Ring ring1, Ring ring2)
    {
        if (Math.Sqrt(Math.Abs(Math.Pow(ring1.CenterOfRing.X - ring2.CenterOfRing.X, 2) 
            + Math.Pow(ring1.CenterOfRing.Y -  ring2.CenterOfRing.Y, 2))) < Math.Abs(ring1.InnerRadius + ring2.InnerRadius))
           
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

