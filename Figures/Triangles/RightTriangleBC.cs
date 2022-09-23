namespace FigureAreaCalculator.Figures.Triangles
{
    public class RightTriangleBC : Triangle
    {
        public RightTriangleBC(double a, double b, double c)
            : base(a, b, c)
        {

        }

        public override double GetArea()
        {
            return b * c / 2;
        }
    }
}
