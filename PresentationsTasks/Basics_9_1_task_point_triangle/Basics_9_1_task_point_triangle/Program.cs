using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_9_1_task_point_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(new Point(0, 1), new Point(2, 3), new Point(1, 2)));
            triangles.Add(new Triangle(new Point(2, 1), new Point(4, 3), new Point(3, 2)));
            triangles.Add(new Triangle(new Point(1, 2), new Point(5, 3), new Point(4, 2)));
            triangles.Add(new Triangle(new Point(4, 1), new Point(3, 1), new Point(3, 2)));
            triangles.Add(new Triangle(new Point(2, 1), new Point(5, 3), new Point(2, 4)));

            foreach (var item in triangles)
            {
                item.Print();
            }


            //Delay
            Console.ReadKey();
        }
    }
}
