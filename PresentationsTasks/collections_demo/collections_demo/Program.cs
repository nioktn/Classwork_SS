using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myColl = new List<int>() { 1, 23, 32, -10, 4, 5, -10, 61, -10, 7 };
            int count = 0;
            Display(myColl);
            foreach (var item in myColl)
            {
                if (item == -10) Console.WriteLine("myColl[{0}] = {1}", count, item);
                count++;
            }
            Console.WriteLine();
            foreach (var item in myColl.FindAll(x => x > 20))
            {
                myColl.Remove(item);
            }
            Display(myColl);
            Console.WriteLine();
            myColl.Insert(2, 1);
            myColl.Insert(8, -3);
            myColl.Insert(5, -4);

            Display(myColl);
            Console.WriteLine();
            myColl.Sort();
            Display(myColl);
            Console.ReadKey();
        }

        public static void Display(List<int> collection)
        {
            int count = 0;
            foreach (var item in collection)
            {
                Console.WriteLine("myColl[{0}] = {1}", count, item);
                count++;
            }
        }

    }
}
