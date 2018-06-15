using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Square : Shape
    {
        public double Side { get; set; }
        public Square(String name, double Side) : base (name)
        {
            this.Side = Side;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return Side * 4;
        }
    }
}
