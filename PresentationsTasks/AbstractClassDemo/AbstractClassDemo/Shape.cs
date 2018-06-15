using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    abstract class Shape : IComparable<Shape>
    {
        private String name;
        public String Name
        {
            get => name;
            set => name = value;
        }
        public Shape(String name)
        {
            Name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            return this.Area().CompareTo(other.Area());
        }

    }
}
