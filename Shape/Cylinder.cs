using System;
using System.Collections.Generic;

namespace Shape
{
    public class Cylinder : Shape
    {
        private string name;
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double R;
        public double H;
        public Cylinder(double BaseRadius, double Height)
        {
            R = BaseRadius;
            H = Height;
            name = "Цилиндр";
        }
        public override double Volume()
        {
            {
                double result = Math.PI * Math.Pow(R, 2) * H;
                return result;
            }
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"{name} радиусом основания {R} высотой {H} объемом {Volume()}");
        }
    }
}
