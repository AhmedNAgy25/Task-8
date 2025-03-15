using System;
using Task8.AbstractClasses;

namespace Task8.Classes

{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius) => _radius = radius;
        public override double GetArea() => Math.PI * _radius * _radius;
    }
}