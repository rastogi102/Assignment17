using System;


namespace ConAppAssignment17
{
    //Derived Class Rectangle
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            ShapeType = "Rectangle";
            Width = width;
            Height = height;
        }

        public override double Area => Width * Height;

        public override double Perimeter => 2 * (Width + Height);

        public void PrintInfo()
        {
            Console.WriteLine($"Shape: {ShapeType}, Width: {Width}, Height: {Height}, Area: {Area}, Perimeter: {Perimeter}");
        }
    }
}
