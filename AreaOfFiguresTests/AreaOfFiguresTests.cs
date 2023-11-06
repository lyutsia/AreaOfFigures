using AreaOfFigures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaOfFiguresTests
{
    [TestClass]
    public class FigureCreateExceptionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailSetRadiusCircle()
        {
            Assert.Equals(typeof(ArgumentException), new Circle(-1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailSetSideATriangle()
        {
            Assert.Equals(typeof(ArgumentException), new Triangle(-1, 8, 9));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailSetSideBTriangle()
        {
            Assert.Equals(typeof(ArgumentException), new Triangle(1, -8, 9));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailSetSideCTriangle()
        {
            Assert.Equals(typeof(ArgumentException), new Triangle(1, 8, -9));
        }
    }

    [TestClass]
    public class CalculateAreaFigureTests
    {
        [TestMethod]
        public void CalculateAreaCircle()
        {
            var circle = new Circle(5);
            Assert.AreEqual(78.5398, Math.Round(CalculateAreaFigure(circle), 4));
        }

        [TestMethod]
        public void CalculateAreaTriangle()
        {
            var triangle = new Triangle(5, 4, 3);
            Assert.AreEqual(6, CalculateAreaFigure(triangle));
        }

        public double CalculateAreaFigure(IFigureArea figure) => figure.GetArea();
    }

    [TestClass]
    public class TriangleTests
    {

        [TestMethod]
        public void IsRectangularTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRectangular());
        }

    }
}