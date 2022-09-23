namespace FigureAreaCalculator.Figures.Triangles
{
    public class RightTriangleAB : Triangle
    {
        public RightTriangleAB(double a, double b, double c)
            : base(a, b, c)
        {

        }

        public override double GetArea()
        {
            return a * b / 2;
        }
    }
}
