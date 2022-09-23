using FigureAreaCalculator.Figures;
using FigureAreaCalculator.Figures.Triangles;
using System;

namespace FigureAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure circle = new Circle(10);
            TriangleFabric triangleFabric = new TriangleFabric();
            IFigure triangle = triangleFabric.CreateTriangle(3, 4, 5);
            Console.WriteLine(circle.GetArea());
            Console.WriteLine(triangle.GetArea());
        }
    }
}
