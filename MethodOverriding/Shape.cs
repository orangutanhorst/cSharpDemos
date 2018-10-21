using System;

namespace MethodOverriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle");

        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");

        }
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle");
        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //  public Position Position { get; set; }
        //  public ShapeType Type { get; set; }


        public virtual void Draw()
        {

        }
    }
}