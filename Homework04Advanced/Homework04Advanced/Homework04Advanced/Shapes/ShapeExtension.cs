using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04Advanced.Shapes
{
    public static class ShapeExtension
    {
        public static void PrintInfo(this Circle circle)
        {
            Console.WriteLine($"Circle with Radius {circle.Radius}");
            Console.WriteLine($"Area: {circle.GetArea()}");
            Console.WriteLine($"Perimeter: {circle.GetPerimeter()}");
        }

        public static void PrintInfo(this Rectangle rectangle)
        {
            Console.WriteLine($"Rectangle with Sides {rectangle.SideA} and {rectangle.SideB}");
            Console.WriteLine($"Area: {rectangle.GetArea()}");
            Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");
        }
    }
}
