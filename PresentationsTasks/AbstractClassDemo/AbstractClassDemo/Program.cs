using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            for (; ; )
            {
                Console.Write("1. New Square\n2. New Circle\n3. Output\n5. Sort list\n4. Print shape with the biggest perimeter\n0. Exit\nChoose option: \n >> ");
                try
                {
                    int option = Int32.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case (1):
                            Console.WriteLine("Enter name of a square:");
                            string name1 = Console.ReadLine();
                            Console.WriteLine("Enter side of a square:");
                            double side1 = double.Parse(Console.ReadLine());
                            shapes.Add(new Square(name1, side1));
                            continue;
                        case (2):
                            Console.WriteLine("Enter name of a circle:");
                            string name2 = Console.ReadLine();
                            Console.WriteLine("Enter radius of a cirsle:");
                            double radius = double.Parse(Console.ReadLine());
                            shapes.Add(new Circle(name2, radius));
                            continue;
                        case (3):
                            Console.WriteLine("List of your shapes");
                            int count = 0;
                            foreach (var item in shapes)
                            {
                                Console.WriteLine("{3}. Name: {0} Perimeter:{1} Area:{2}", item.Name, item.Perimeter(), item.Area(), count);
                                count++;
                            }
                            Console.WriteLine("");
                            continue;
                        case (4):
                            int index = 0, cnt = 0;
                            foreach (var item in shapes)
                            {
                                if (item.Perimeter() > shapes[index].Perimeter()) index = cnt;
                                cnt++;
                            }
                            Console.WriteLine("Name: {0} Perimeter:{1} Area:{2}", shapes[index].Name, shapes[index].Perimeter(), shapes[index].Area());
                            continue;
                        case (5):
                            shapes.Sort();
                            continue;
                        case (0):
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("There are no option like this");
                            continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}
