using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(String name, double Radius) : base(name)
        {
            this.Radius = Radius;
        }

        public override double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
        public override double Perimeter()
        {
            return Math.PI * Radius;
        }
    }
}
