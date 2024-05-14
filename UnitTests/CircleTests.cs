using GeometryLibrary.Model.Figures;

namespace UnitTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        [DataRow(1, Math.PI)]
        [DataRow(2, 4 * Math.PI)]
        [DataRow(3, 9 * Math.PI)]
        public void GetArea(double radius, double expectedResult)
        {
            //Arrange
            var circle = new Circle(radius);
            //Act
            var result = circle.GetArea();
            //Assert
            Assert.AreEqual(expectedResult, result, "Msg");
        }
    }
}
