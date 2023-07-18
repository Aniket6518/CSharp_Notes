namespace ConsoleApp2;

public class DrawingObject
{
    public virtual void Draw()
    {
        Console.WriteLine("i'm a generic drawing object");
    }
}

public class Circle:DrawingObject
{
    public override void Draw()
    {
        Console.WriteLine("i'm a Circle");
    }
}

public class Square:Circle
{
    public override void Draw()
    {
        Console.WriteLine("i'm a Square");
    }
}

public class Line:Square
{
    public override void Draw()
    {
        Console.WriteLine("i'm a Line");
    }
}

public class Polymorphism
{
    public static int Main()
    {
        DrawingObject[] obj = new DrawingObject[4];
        obj[0] = new Square();
        obj[1] = new Circle();
        obj[2] = new Line();
        obj[3] = new DrawingObject();

        foreach (DrawingObject drawobj in obj)
        {
            drawobj.Draw();
        }
        return 0;
    }
}