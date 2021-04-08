using System;
using System.Collections.Generic;

namespace Shape
{
    public class Pyramid : Shape
    {
        private string name;
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double S;
        public double H;
        public Pyramid(double BaseSquare, double Height)
        {
            S = BaseSquare;
            H = Height;
            name = "Пирамида";
        }
        public override double Volume()
        {
            {
                double result = S * H / 3;
                return result;
            }

        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"{name} площадью основания {S} высотой {H} объемом {Volume()}");
        }
    }
}
