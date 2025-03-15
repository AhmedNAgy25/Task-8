namespace Task8.AbstractClasses
{
    public abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }
        public abstract double CalculateArea();
        public abstract double Perimeter { get; }
    }
}
