using Homework04Advanced.Shapes;

namespace Homework04Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circle circle1 = new Circle { Id = 1, Radius = 5.0 };
            Rectangle rectangle1 = new Rectangle { Id = 2, SideA = 3.0, SideB = 4.0 };

            GenericDb<Circle> circleDb = new GenericDb<Circle>();
            circleDb.Shapes.Add(circle1);

            GenericDb<Rectangle> rectangleDb = new GenericDb<Rectangle>();
            rectangleDb.Shapes.Add(rectangle1);

            Console.WriteLine("Circle Info:");
            circle1.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Rectangle Info:");
            rectangle1.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Circle DB Areas:");
            circleDb.PrintAreas();
            Console.WriteLine();

            Console.WriteLine("Rectangle DB Perimeters:");
            rectangleDb.PrintPerimeters();
        }
    }
}