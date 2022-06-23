
using FiguresLibrary;

namespace TestProject
{
    [TestClass]
    public class FiguresTest
    {
        [TestMethod]
        public void TestRound()
        {
            Round round = new Round(1);
            Assert.AreEqual(Math.PI, round.Area);
        }

        [TestMethod]
        public void TestTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.Area);
            Assert.IsTrue(triangle.IsRightTriange);
        }
    }
}