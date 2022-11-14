using Xunit;
using MathSolver;
using System.Collections.Generic;

namespace TestMathSolver
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void TestIsOnePrimeNumber(int value)
        {
            // Arrange
            CMath cm = new CMath();

            // Act
            bool result = cm.IsPrimeNumber(value);

            // assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(1, 3, 2, -1, -2)]
        public void TestSolveQuadraticEquation(double a, double b, double c, double xans1, double xans2)
        {
            //Arrange
            CMath cm = new CMath();

            // Act
            double xout1;
            double xout2;

            cm.SolveQuadraticEquation(a, b, c, out xout1, out xout2);


            // Assert
            Assert.True((xout1 == xans1) || (xout2 == xans2));
            Assert.True((xout2 == xans2) || (xout2 == xans2));

        }
    }
}