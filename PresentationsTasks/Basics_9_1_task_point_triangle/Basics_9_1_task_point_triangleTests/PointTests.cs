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
    public class PointTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Points.xml", "PointRow", DataAccessMethod.Sequential)]

        [TestMethod()]
        public void DistanceTestDataDriven()
        {
            double X1 = Convert.ToDouble(TestContext.DataRow["X1"]);
            double Y1 = Convert.ToDouble(TestContext.DataRow["Y1"]);
            double X2 = Convert.ToDouble(TestContext.DataRow["X2"]);
            double Y2 = Convert.ToDouble(TestContext.DataRow["Y2"]);
            Point pt1 = new Point(X1, Y1);
            Point pt2 = new Point(X2, Y2);
            double expectedResult = Convert.ToDouble(TestContext.DataRow["Length"]);
            double actualResult = Point.Distance(pt1, pt2);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod()]
        public void CloneTest()
        {
            Point expectedResult = new Point(3, 4);
            Point actualResult = new Point(3, 4).Clone() as Point;
            Assert.ReferenceEquals(expectedResult, actualResult);
        }
    }
}