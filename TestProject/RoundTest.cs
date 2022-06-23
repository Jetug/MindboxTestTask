using FiguresLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class RoundTest
    {
        const double radius = 1;

        [TestMethod]
        public void TestArea()
        {
            Round round = new(radius);
            Assert.AreEqual(Math.PI, round.Area);
            Assert.AreNotEqual(radius, round.Area);
        }

        [TestMethod]
        public void TestExeption()
        {
            Assert.ThrowsException<ArgumentException>(() => new Round(-radius));
        }
    }
}
