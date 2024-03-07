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
        [Test]
        public void AnalyzeTriangleTest5_InputSides345_ReturnsScaleneTriangle()
        {
            // Arrange
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangleTest6_InputSides_5_12_13_ReturnsScaleneTriangle()
        {
            // Arrange
            int side1 = 5;
            int side2 = 12;
            int side3 = 13;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangleTest7_InputSides_8_15_17_ReturnsScaleneTriangle()
        {
            // Arrange
            int side1 = 8;
            int side2 = 15;
            int side3 = 17;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangleTest8_InputSides_6_8_10_ReturnsScaleneTriangle()
        {
            // Arrange
            int side1 = 6;
            int side2 = 8;
            int side3 = 10;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangleTest9_InputSides_9_12_15_ReturnsScaleneTriangle()
        {
            // Arrange
            int side1 = 9;
            int side2 = 12;
            int side3 = 15;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void AnalyzeTriangleTest10_ZeroLengthSide045_ReturnsZeroInvalid()
        {
            // Arrange
            int side1 = 0;
            int side2 = 4;
            int side3 = 5;

            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangleTest11_ZeroLengthSide005_ReturnsZeroInvalid()
        {
            // Arrange
            int side1 = 0;
            int side2 = 0;
            int side3 = 5;

            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangleTest12_ZeroLengthSide000_ReturnsZeroInvalid()
        {

            // Arrange
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;

            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangleTest13_InvalidResponseSides228_ReturnsInvalidResponse()
        {

            // Arrange
            int side1 = 2;
            int side2 = 2;
            int side3 = 8;

            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangleTest14_InvalidResponseSides124_ReturnsInvalidResponse()
        {

            // Arrange
            int side1 = 1;
            int side2 = 2;
            int side3 = 4;

            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangleTest15_InvalidResponseSides5_10_25_ReturnsInvalidResponse()
        {

            // Arrange
            int side1 = 5;
            int side2 = 10;
            int side3 = 25;

            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}