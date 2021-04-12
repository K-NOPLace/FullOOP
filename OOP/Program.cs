using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointandPolygon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Точка и Полигон");

            Console.WriteLine();

            var A = new Point("A", 1, 5);

            var B = new Point("B", 2, 4);

            var C = new Point("C", 3, 3);

            var D = new Point("D", 4, 2);

            var E = new Point("E", 5, 1);

            Console.WriteLine("Точки: ");

            A.DisplayInfo();

            B.DisplayInfo();

            C.DisplayInfo();

            D.DisplayInfo();

            E.DisplayInfo();

            var triangle = new Polygon(A, B, C);

            var quadrangle = new Polygon(A, B, C, D);

            var pentagon = new Polygon(A, B, C, D, E);

            Console.WriteLine("Многоугольники:");

            triangle.DisplayInfo();

            quadrangle.DisplayInfo();

            pentagon.DisplayInfo();

            Console.WriteLine($"Треугольника: {triangle.Perimeter()}");

            Console.WriteLine($"Четырехугольник: {quadrangle.Perimeter()}");

            Console.WriteLine($"Пятиугольника: {pentagon.Perimeter()}");

            Console.WriteLine();

            Console.WriteLine("Векторы");

            Console.WriteLine();

            var vectorA = new Vector("A", -2, 2, 3);

            var vectorB = new Vector("B", -3, -1, 0);

            Console.WriteLine("Два вектора:");

            vectorA.DisplayInfo();

            vectorB.DisplayInfo();

            Console.WriteLine($"Длина {vectorA.VectorName} = {vectorA.VectorLength()}");

            Console.WriteLine($"Длина {vectorB.VectorName} = {vectorB.VectorLength()}");

            Console.WriteLine($"Скалярное произведение = {Vector.VectorsScalar(vectorA, vectorB)}");

            var vectorC = Vector.VectorsProduct(vectorA, vectorB, "C");

            Console.WriteLine($"Векторное произведение {vectorA.VectorName} и {vectorB.VectorName} => вектор {vectorC.VectorName} ");

            vectorC.DisplayInfo();

            Console.WriteLine($"Угол между {vectorA.VectorName} и {vectorB.VectorName} = {Vector.VectorsAngle(vectorA, vectorB)} ");

            var vectorD = Vector.VectorsSum(vectorA, vectorB, "D");

            Console.WriteLine($"Суммой {vectorA.VectorName} и {vectorB.VectorName} => вектор {vectorD.VectorName} ");

            vectorD.DisplayInfo();

            var vectorE = Vector.VectorsSubtraction(vectorA, vectorB, "E");

            Console.WriteLine($"Разность {vectorA.VectorName} и {vectorB.VectorName} => вектор {vectorE.VectorName} ");

            vectorE.DisplayInfo();
        }
    }
}
