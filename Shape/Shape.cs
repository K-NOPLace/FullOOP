using System;
using System.Collections.Generic;

namespace Shape
{
    public abstract class Shape
    {
        public abstract string Name { get; set; }
        public abstract void DisplayInfo();
        public abstract double Volume();
    }
}
