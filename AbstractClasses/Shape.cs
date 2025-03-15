using System;

namespace Task8.AbstractClasses
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public void Display() => Console.WriteLine($"Area: {GetArea()}");
    }
}
