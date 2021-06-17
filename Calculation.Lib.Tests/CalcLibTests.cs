using NUnit.Framework;

namespace Calculation.Lib.Tests
{
        [TestFixture]
        public class CalcLibTests
        {
            [Test]
            public void Sum_20and30_Returned50()
            {
                int x = 20;
                int y = 30;
                int expected = 50;

                CalcLib c = new CalcLib();
                int actual = c.Sum(x, y);

                Assert.AreEqual(expected, actual);

            }
            [Test]
            public void Dif_40and50_Returned_10()
            {
                int x = 40;
                int y = 50;
                int expected = -10;

                CalcLib c = new CalcLib();
                int actual = c.Dif(x, y);

                Assert.AreEqual(expected, actual);

            }
            [Test]
            public void Div_40and20_Returned2()
            {
                int x = 40;
                int y = 20;
                int expected = 2;

                CalcLib c = new CalcLib();
                int actual = c.Div(x, y);

                Assert.AreEqual(expected, actual);

            }
            [Test]
            public void Mult_2and20_Returned40()
            {
                int x = 2;
                int y = 20;
                int expected = 40;

                CalcLib c = new CalcLib();
                int actual = c.Mult(x, y);

                Assert.AreEqual(expected, actual);

            }

        }
    
}