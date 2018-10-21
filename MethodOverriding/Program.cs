using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle1 = new Circle();
            var rectangle = new Rectangle();
            var circle2 = new Circle();

            var listOfShapes = new List<Shape>();
            listOfShapes.Add(circle1);
            listOfShapes.Add(rectangle);
            listOfShapes.Add(circle2);
            listOfShapes.Add(new Triangle());
            var canvas = new Canvas();
            canvas.DrawShapes(listOfShapes);

            Console.ReadKey();
        }
    }
}
