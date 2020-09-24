using WPFcalculatorUI.Services;
using Xunit;

namespace WPFcalculator.Tests
{
    public class CalculationServiceTests
    {
        private readonly ICalculationService _calculationService;

        public CalculationServiceTests()
        {
            _calculationService = new CalculationService();
        }

        [Theory]
        [InlineData("+")]
        [InlineData("-")]
        [InlineData("/")]
        [InlineData("*")]
        public void GivenValidEquation_PerformCalculation_ReturnResult(string passedInSymbol)
        {
            float firstNum = 10;
            float secondNum = 2;
            string symbol = passedInSymbol;
            float expected = 0;

            if(symbol == "+"){ expected = firstNum + secondNum; }
            else if(symbol == "-") { expected = firstNum - secondNum; }
            else if (symbol == "/") { expected = firstNum / secondNum; }
            else if (symbol == "*") { expected = firstNum * secondNum; }

            float actual = _calculationService.PerformCalculation(firstNum, secondNum, symbol);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("8")]
        [InlineData(".")]
        [InlineData("0")]
        [InlineData("/")]
        public void GivenValidSymbol_ReturnStringResult(object input)
        {
            string expected = input.ToString();

            string actual = _calculationService.ReceiveInput(input);

            Assert.Equal(expected, actual);
        }
    }
}
