using System;

namespace Point_and_Polygon
{
    public class Point
    {
        public string Pointname { get; }
        public int X { get; }
        public int Y { get; }
        public Point(string name, int x, int y)
        {
            Pointname = name;
            X = x;
            Y = y;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{Pointname} ({X};{Y})");
        }
    }
}