using System;

namespace Task8.Classes
{
    public class SortableShape : IComparable<SortableShape>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public SortableShape(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public int CompareTo(SortableShape other) => Area.CompareTo(other.Area);
    }
}
