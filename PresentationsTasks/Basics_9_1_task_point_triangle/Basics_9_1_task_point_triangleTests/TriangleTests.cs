using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basics_9_1_task_point_triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_9_1_task_point_triangleTests
{ 
    [TestClass()]
    public class TriangleTests
    {
        Triangle tr;
        [TestInitialize]
        public void TriangleInitialize()
        {
            Point pt1 = new Point(3, 5);
            Point pt2 = new Point(2, 6);
            Point pt3 = new Point(1, 3);
            tr = new Triangle(pt1, pt2, pt3);
        }

        [TestMethod()]
        public void PerimeterTest()
        {
            double expectedResult = 7.405;
            double actualResult = tr.Perimeter();
            Assert.AreEqual(expectedResult, actualResult, 0.1);
        }

        [TestMethod()]
        public void SquareTest()
        {
            double expectedResult = 2;
            double actualResult = tr.Square();
            Assert.AreEqual(expectedResult, actualResult, 0.1);
        }
    }
}