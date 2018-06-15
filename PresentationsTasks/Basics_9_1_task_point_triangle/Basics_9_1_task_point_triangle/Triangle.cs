using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_9_1_task_point_triangle
{

    public class Point : ICloneable
    {
        private double _x, _y;
        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public static double Distance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow((point1.X - point2.X), 2) + Math.Pow((point1.Y - point2.Y), 2));
        }

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }


    public class Triangle
    {
        private Point _vertex1, _vertex2, _vertex3;
        private double side1, side2, side3;
        public Triangle(Point p1, Point p2, Point p3)
        {
            _vertex1 = p1.Clone() as Point;
            _vertex2 = p2.Clone() as Point;
            _vertex3 = p3.Clone() as Point;
            CalcTriangleSides();
            if (!(side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                //throw new Exception("Triangle can`t exist");
                Console.WriteLine("Triangle can't exist");
                Console.ResetColor();
            }
        }

        private void CalcTriangleSides()
        {
            side1 = Point.Distance(_vertex1, _vertex2);
            side2 = Point.Distance(_vertex2, _vertex3);
            side3 = Point.Distance(_vertex1, _vertex3);
        }

        public double Perimeter()
        {
            return side1 + side2 + side3;
        }

        public double Square()
        {
            double Area;
            double p = (side1 + side2 + side3) / 2;
            Area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return Area;
        }

        public void Print()
        {
            Console.WriteLine(" Triangle:\nPoints: {0} {1} {2}, Square: {3} Perimeter: {4}", _vertex1, _vertex2, _vertex3, Square(), Perimeter());
        }
    }
}
