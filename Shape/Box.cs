using System;
using System.Collections.Generic;

namespace Shape
{
    public class Box : Shape
    {
        private string name;
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double H;
        public List<Shape> Сonteiner;
        public Box(double Height)
        {
            H = Height;
            name = "Коробка";
            Сonteiner = new List<Shape>();
        }
        public override double Volume()
        {
            {
                double result = Math.Pow(H, 3);
                return result;
            }
        }
        private double FilledVolume()
        {
            double v = 0;
            foreach (Shape element in Сonteiner)
            {
                v += element.Volume();
            }
            return v;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"{name} высотой ребра {H} объемом {Volume()}");
        }
        public bool Add(Shape shape)
        {
            if ((this.Volume() - this.FilledVolume()) > shape.Volume())
            {
                Сonteiner.Add(shape);
                Console.WriteLine($"{shape.Name} объемом {shape.Volume()}. Фигура пытается протиснутся в коробку.");
                return true;
            }
            else
            {
                Console.WriteLine($"{shape.Name} объемом {shape.Volume()} слишком большой и не может поместится в коробке.");
                return true;
            }
        }
        public void DisplayConteinerInfo()
        {
            Console.WriteLine($"Коробка объемом {Volume()} заполнен на {FilledVolume()}. Внутри сейчас:");
            foreach (Shape element in Сonteiner)
            {
                element.DisplayInfo();
            }
        }
    }
}

