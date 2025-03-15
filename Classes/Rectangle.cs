using Task8.AbstractClasses;

namespace Task8.Classes

{
    public class Rectangle : Shape
    {
        private double _length;
        private double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public override double GetArea() => _length * _width;
    }
}