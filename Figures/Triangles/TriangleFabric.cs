using System;

namespace FigureAreaCalculator.Figures.Triangles
{
    public class TriangleFabric
    {
        /* Не был уверен как будет использоваться информация о том, что треугольник
         * прямоугольный. Поэтому было принято решение сделать фабрику, которая будет по
         * известным сторонам определять, какие из ребер являются катетами и создавать 
         * соответсвующий подкласс для каждой возможной пары катетов. Такое решение позволяет
         * не проводить определение "прямоугольности" треугольника при каждом просчете площади,
         * а сразу знать что треугольник прямоугольный, какие стороны являются катетами
         * и считать площадь по частной формуле, а не по формуле Герона.*/

        public Triangle CreateTriangle(double a, double b, double c)
        {
            if (a + b > c & b + c > a & c + a > b)
            {
                double cos_alpha = (a * a + c * c - b * b) / (2 * a * c);
                double cos_beta = (a * a + b * b - c * c) / (2 * a * b);
                double cos_gamma = (b * b + c * c - a * a) / (2 * b * c);

                double alpha = Math.Acos(cos_alpha) / Math.PI * 180;
                double beta = Math.Acos(cos_beta) / Math.PI * 180;
                double gamma = Math.Acos(cos_gamma) / Math.PI * 180;

                if (alpha == 90)
                    return new RightTriangleAC(a, b, c);
                if (beta == 90)
                    return new RightTriangleAB(a, b, c);
                if (gamma == 90)
                    return new RightTriangleBC(a, b, c);
                else
                    return new Triangle(a, b, c);
            }
            else
                throw new Exception("Сумма длин двух любых сторон треугольника должна быть больше длины оставшейся стороны!");
        }
    }
}
