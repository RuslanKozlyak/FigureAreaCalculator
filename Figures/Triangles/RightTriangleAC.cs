namespace FigureAreaCalculator.Figures.Triangles
{
    public class RightTriangleAC : Triangle
    {
        public RightTriangleAC(double a, double b, double c)
            : base(a, b, c)
        {

        }

        public override double GetArea()
        {
            return a * c / 2;
        }
    }
}
