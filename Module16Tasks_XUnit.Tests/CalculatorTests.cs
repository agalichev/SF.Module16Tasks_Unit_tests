using Module16Tasks;
using Xunit;

namespace Module16Tasks_XUnit.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Subtraction(300, 10) == 290);
        }

        [Fact]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Division(300, 10) == 30);
        }

        [Fact]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(300, 0));
        }
        
    }
}