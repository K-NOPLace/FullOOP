using System;
using System.Collections.Generic;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5);

            Shape ball = new Ball(5);

            Shape cylinder = new Cylinder(2, 5);

            Shape piramid = new Pyramid(5, 10);

            Console.WriteLine("Четыре фигуры:");

            box.DisplayInfo();

            ball.DisplayInfo();

            cylinder.DisplayInfo();

            piramid.DisplayInfo();

            if (box.Add(ball)) { box.DisplayConteinerInfo(); }

            if (box.Add(cylinder)) { box.DisplayConteinerInfo(); }

            if (box.Add(piramid)) { box.DisplayConteinerInfo(); }
        }
    }
}