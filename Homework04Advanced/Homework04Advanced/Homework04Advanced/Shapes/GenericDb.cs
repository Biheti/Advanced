using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04Advanced.Shapes
{
    public class GenericDb<T> where T : Shape
    {
        public List<T> Shapes { get; } = new List<T>();

        public void PrintAreas()
        {
            foreach (var shape in Shapes)
            {
                Console.WriteLine($"Shape {shape.Id} - Area: {shape.GetArea()}");
            }
        }

        public void PrintPerimeters()
        {
            foreach (var shape in Shapes)
            {
                Console.WriteLine($"Shape {shape.Id} - Perimeter: {shape.GetPerimeter()}");
            }
        }
    }

}
