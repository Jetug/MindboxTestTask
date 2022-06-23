
using FiguresLibrary;

namespace TestProject
{
    [TestClass]
    public class TriangleTest
    {
        const double a = 3;
        const double b = 4;
        const double c = 5;

        [TestMethod]
        public void TestTriangle()
        {
            Triangle triangle = new(a, b, c);
            Assert.AreEqual(6, triangle.Area);
        }

        [TestMethod]
        public void TestIsRight()
        {
            Triangle triangle = new(a, b, c);
            Assert.IsTrue(triangle.IsRightTriange);
        }

        [TestMethod]
        public void TestExeption()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-a, -b, -c));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-a, b, c));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(a, -b, c));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(a, b, -c));
        }
    }
}