using TriangleSolver;

namespace triangleTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void AnalyzeTriangleTest1_InputSides555_ReturnsEquilateralTriangle()
        {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 5;

            string expected = "Equilateral triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void AnalyzeTriangleTest2_InputSides557_ReturnsIsoscelesTriangle()
        {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 7;

            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangleTest3_InputSides575_ReturnsIsoscelesTriangle()
        {
            // Arrange
            int side1 = 5;
            int side2 = 7;
            int side3 = 5;

            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangleTest4_InputSides755_ReturnsIsoscelesTriangle()
        {
            // Arrange
            int side1 = 7;
            int side2 = 5;
            int side3 = 5;

            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}