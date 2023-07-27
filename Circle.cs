using System;


namespace ConAppAssignment17
{
    // Derived class Circle
    public class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            ShapeType = "Circle";
            Radius = radius;
        }

        public override double Area => Math.PI * Math.Pow(Radius, 2);

        public override double Perimeter => 2 * Math.PI * Radius;

        public void PrintInfo()
        {
            Console.WriteLine($"Shape: {ShapeType}, Radius: {Radius}, Area: {Area}, Perimeter: {Perimeter}");
        }
    }
}
