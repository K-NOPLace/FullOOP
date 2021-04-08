using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_and_Polygon
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("Периметры:");

            Console.WriteLine($"Треугольника: {triangle.Perimeter()}");

            Console.WriteLine($"Четырехугольник: {quadrangle.Perimeter()}");

            Console.WriteLine($"Пятиугольника: {pentagon.Perimeter()}");
        }
    }
}
