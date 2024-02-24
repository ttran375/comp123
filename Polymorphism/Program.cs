class DrawingObject
{
    public virtual void Draw()
    {
        Console.WriteLine("I am just a generic drawing object.");
    }
}

class Line : DrawingObject
{
    public override void Draw()
    {
        Console.WriteLine("I am a line.");
    }
}

class Circle : DrawingObject
{
    public override void Draw()
    {
        Console.WriteLine("I am a circle.");
    }
}

class Square : DrawingObject
{
    public override void Draw()
    {
        Console.WriteLine("I am a square.");
    }
}

class Program
{
    static void Main()
    {
        List<DrawingObject> objs = new List<DrawingObject>()
        {
            new Line(), new Circle(), new Square(), new DrawingObject()
        };

        foreach (DrawingObject obj in objs)
        {
            obj.Draw();
        }
    }
}
