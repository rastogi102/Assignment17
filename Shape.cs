using System;


namespace ConAppAssignment17
{
    public class Shape
    {
        public string ShapeType { get; set; }

        public virtual double Area { get; }

        public virtual double Perimeter { get; }
    }
}
