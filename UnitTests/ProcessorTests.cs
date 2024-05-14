using GeometryLibrary.Model.Figures.Base;
using GeometryLibrary.Model.Figures;
using GeometryLibrary.Model;

namespace UnitTests
{
    [TestClass]
    public class ProcessorTests
    {
        [TestMethod]
        [DataRow(3, 4, 5, 6)]
        [DataRow(5, 5, 6, 12)]
        [DataRow(15, 13, 4, 24)]
        public void SingleTriangle(double firstSide, double secondSide, double thirdSide, double expectedResult)
        {
            //Arrange
            var processor = new Processor();
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var triangleList = new List<IFigure>
            {
                triangle
            };
            //Act
            var result = processor.SumArea(triangleList);
            //Assert
            Assert.AreEqual(expectedResult, result, "msg");
        }

        [TestMethod]
        [DataRow(1, Math.PI)]
        [DataRow(2, 4 * Math.PI)]
        [DataRow(3, 9 * Math.PI)]
        public void SingleCircle(double radius, double expectedResult)
        {
            //Arrange
            var processor = new Processor();
            var circle = new Circle(radius);
            var circleList = new List<IFigure>
            {
                circle
            };
            //Act
            var result = processor.SumArea(circleList);
            //Assert
            Assert.AreEqual(expectedResult, result, "msg");
        }

        [TestMethod]
        public void Triangles()
        {
            //Arrange
            var processor = new Processor();
            var triangle1 = new Triangle(3, 4, 5);
            var triangle2 = new Triangle(5, 5, 6);
            var triangle3 = new Triangle(15, 13, 4);
            var triangleList = new List<IFigure>
            {
                triangle1,
                triangle2,
                triangle3
            };
            //Act
            var result = processor.SumArea(triangleList);
            //Assert
            Assert.AreEqual(42, result, "msg");
        }

        [TestMethod]
        public void Circles()
        {
            //Arrange
            var processor = new Processor();
            var circle1 = new Circle(1);
            var circle2 = new Circle(2);
            var circle3 = new Circle(3);
            var circleList = new List<IFigure>
            {
                circle1,
                circle2,
                circle3
            };
            //Act
            var result = processor.SumArea(circleList);
            //Assert
            Assert.AreEqual(14 * Math.PI, result, "msg");
        }

        [TestMethod]
        public void MixedFigures()
        {
            //Arrange
            var processor = new Processor();
            var triangle1 = new Triangle(3, 4, 5);
            var triangle2 = new Triangle(5, 5, 6);
            var triangle3 = new Triangle(15, 13, 4);
            var circle1 = new Circle(1);
            var circle2 = new Circle(2);
            var circle3 = new Circle(3);
            var figureList = new List<IFigure>
            {
                triangle1,
                triangle2,
                triangle3,
                circle1,
                circle2,
                circle3
            };
            //Act
            var result = processor.SumArea(figureList);
            //Assert
            Assert.AreEqual(14 * Math.PI + 42.0, result, 0.0000000000001, "msg");
        }
    }
}
