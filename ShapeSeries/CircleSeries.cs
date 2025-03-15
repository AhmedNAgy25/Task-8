using System;
using Task8.Interfaces;

namespace Task8.ShapeSeries
{
    public class CircleSeries : IShapeSeries
    {
        private int _currentRadius = 0;
        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            _currentRadius++;
            CurrentShapeArea = (int)(Math.PI * _currentRadius * _currentRadius);
        }

        public void ResetSeries() => _currentRadius = 0;
    }
}
