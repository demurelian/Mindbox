using GeometryLibrary.Model.Figures.Base;

namespace GeometryLibrary.Model.Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;


        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }

        public Circle(double radius)
        {
            _radius = radius;
            Validate();
        }

        private void Validate()
        {
            if (_radius <= 0)
                throw new ArgumentOutOfRangeException("radius is negative or 0");
        }
    }
}
