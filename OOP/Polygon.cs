using System;
using System.Collections.Generic;

namespace Point_and_Polygon
{
    public class Polygon
    {
        public string Type = "полигон";
        public List<Point> Points;

        public Polygon(Point A, Point B, Point C)
        {
            Type = "треугольник";
            Points = new List<Point>() { A, B, C };
        }
        public Polygon(Point A, Point B, Point C, Point D)
        {
            Type = "четырехугольник";
            Points = new List<Point>() { A, B, C, D };
        }
        public Polygon(Point A, Point B, Point C, Point D, Point E)
        {
            Type = "пятиугольник";
            Points = new List<Point>() { A, B, C, D, E };
        }
        public int Perimeter()
        {
            int perimeter = 0;
            for (int i = 0; i < Points.Count - 1; i++)
            {
                perimeter += Length(Points[i], Points[i + 1]);
            }
            perimeter += Length(Points[^1], Points[0]);
            return perimeter;
        }
        private static int Length(Point A, Point B)
        {
            int result = (int)Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
            return result;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Type} состоит из точек: ");
            foreach (var point in Points)
            {
                Console.WriteLine($"{point.Pointname} ({point.X};{point.Y})");
            }
        }
    }
}
