using GeometryLibrary.Model.Figures;

namespace UnitTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        [DataRow(4, 3, 5, true)]
        [DataRow(5, 5, 6, false)]
        [DataRow(15, 13, 4, false)]
        [DataRow(15, 12, 9, true)]
        public void IsRectangular(double firstSide, double secondSide, double thirdSide, bool expectedResult)
        {
            //Arrange
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            //Act
            var result = triangle.IsRectangular();
            //Assert
            Assert.AreEqual(expectedResult, result, "msg");
        }

        [TestMethod]
        [DataRow(3, 4, 5, 6)]
        [DataRow(5, 5, 6, 12)]
        [DataRow(15, 13, 4, 24)]
        public void GetArea(double firstSide, double secondSide, double thirdSide, double expectedResult)
        {
            //Arrange
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            //Act
            var result = triangle.GetArea();
            //Assert
            Assert.AreEqual(expectedResult, result, "Some message");
        }
    }
}
