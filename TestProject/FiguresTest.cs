using System.Text;
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
            Triangle triangle1 = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle1.Area);

            var hypotenuse = Math.Sqrt(3 * 3 + 2 * 2);
            Triangle triangle2 = new Triangle(3, 2, hypotenuse);
            Assert.IsTrue(triangle2.IsRightTriange);
        }
    }
}