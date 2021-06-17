using NUnit.Framework;

namespace Calculation.Lib.Tests
{
    [TestFixture]
    public static class CalcLibTests
    {
        [Test]
        public static void Sum_20_and_30_Result_50()
        {
            // Arrange
            const int expected = 50;
            // Act
            var actual = CalcLib.Addition(20, 30);
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public static void Difference_40_and_50_Result_minus_10()
        {
            // Arrange
            const int expected = -10;
            // Act
            var actual = CalcLib.Substraction(40, 50);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public static void Division_3_to_2_Result_1_point_5()
        {
            //Arrange
            const double expected = 1.5;
            //Act
            var actual = CalcLib.Division(3, 2);
            
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public static void Division_40and20_Returned2()
        {
            //Arrange
            const int expected = 2;
            //Act
            var actual = CalcLib.Division(40, 20);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public static void Multiplication_2and20_Returned40()
        {
            //Arrange
            const int expected = 40;
            //Act
            int actual = CalcLib.Multiplication(2, 20);
            //Assert
            Assert.AreEqual(expected, actual);

        }

    }

}