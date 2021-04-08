using System;
using System.Collections.Generic;

namespace Shape
{
    public class Ball : Shape
    {
        private string name;
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double R;
        public Ball(double Radius)
        {
            R = Radius;
            name = "Шар";
        }
        public override double Volume()
        {
            {
                double result = 4 * Math.PI * Math.Pow(R, 3) / 3;
                return result;
            }
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"{name} радиусом {R} объемом {Volume()}");
        }
    }
}
