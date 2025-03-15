using Task8.Interfaces;

namespace Task8.ShapeSeries
{
    public class SquareSeries : IShapeSeries
    {
        private int _currentSide = 0;
        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            _currentSide++;
            CurrentShapeArea = _currentSide * _currentSide;
        }

        public void ResetSeries() => _currentSide = 0;
    }
}
