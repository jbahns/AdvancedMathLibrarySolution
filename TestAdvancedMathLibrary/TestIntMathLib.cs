using Xunit;
using AdvancedMathLibrary;

namespace TestAdvancedMathLibrary
{
    public class TestIntMathLib
    {
        [Theory]
        [InlineData(-3, 3)]
        [InlineData(3, 3)]
        [InlineData(0, 0)]
        public void TestAbsoluteValue(int input, int expected)
        {
            Assert.Equal(expected, Math.AbsoluteValue(input));
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(-10, 15, -25)]
        [InlineData (0, 7, -7)]
        [InlineData(-5, 0, -5)]
        [InlineData (8, 8, 0)]
        [InlineData (25, 12, 13)]
        [InlineData(-17, -8, -9)]
        public void TestAdd(int expected, int inX, int inY)
        {
            Assert.Equal(expected, inX + inY);
        }

        [Theory]
        [InlineData(0,0,0)]
        [InlineData(0, 5, 5)]
        [InlineData(-5, 0, 5)]
        [InlineData(5, 5, 0)]
        [InlineData(0, -5, -5)]
        [InlineData(-5, -10, -5)]
        [InlineData(5, 10, 5)]
        public void TestSub(int expected, int inX, int inY)
        {
            Assert.Equal(expected, inX - inY);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 5, 0)]
        [InlineData(0, 0, -5)]
        [InlineData(25, 5, 5)]
        [InlineData(25, -5, -5)]
        [InlineData(-25, 5, -5)]
        [InlineData(-25, -5, 5)]

        public void TestMult(int expected, int inX, int inY)
        {
            Assert.Equal(expected, inX * inY);
        }

        [Fact]
        public void TestDivideByZero()
        {
            System.Action ZeroDenominator = () => Math.Div(1, 0);
            Assert.Throws<System.DivideByZeroException>(ZeroDenominator);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 0, 5)]
        [InlineData(0, 0, -5)]
        [InlineData(0, 1, 5)]
        [InlineData(0, -2, 5)]
        [InlineData(1, 10, 6)]
        [InlineData(-2, -11, 5)]
        [InlineData(-3, 12, -4)]
        [InlineData(7, -29, -4)]

        public void TestDiv(int expected, int inX, int inY)
        {
            try
            {
                Assert.Equal(expected, inX / inY);
            }
            catch(System.DivideByZeroException)
            {
                throw new System.Exception("Cannot divide by zero.");
            }
        }

        [Fact]
        public void TestAbsoluteValueFacts()
        {
            Assert.Equal(3, Math.AbsoluteValue(-3));
            Assert.Equal(3, Math.AbsoluteValue(3));
            Assert.Equal(0, Math.AbsoluteValue(0));
        }

        [Fact]
        public void TestZeroConstant()
        {
            Assert.Equal(0, Math.Zero);
        }
        
    }
}
