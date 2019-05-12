using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleDrawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDrawing.Tests
{
    [TestClass()]
    public class PointTests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            var p1 = new Point(12, 13);
            var p2 = new Point(12, 13);
            Assert.AreEqual(p1, p2);
        }
    }
}
