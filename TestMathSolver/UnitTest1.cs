using Xunit;
using MathSolver;

namespace TestMathSolver
{
    public class UnitTest1
    {
        [Fact]
        public void TestIsOnePrimeNumber()
        {
            // Arrange
            CMath cm = new CMath();

            // Act
            bool result = cm.IsPrimeNumber(1);

            // assert
            Assert.False(result);
        }
    }
}