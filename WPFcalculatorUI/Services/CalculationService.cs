using System.Windows.Controls;

namespace WPFcalculatorUI.Services
{
    public class CalculationService : ICalculationService
    {
        public string ReceiveInput(object sender)
        {
            return (string)(sender as Button).Content;
        }

        public float PerformCalculation(object sender, float firstNum, float secondNum, string symbol)
        {
            switch (symbol)
            {
                case "+":
                    return firstNum + secondNum;
                case "-":
                    return firstNum - secondNum;
                case "/":
                    return firstNum / secondNum;
                case "*":
                    return firstNum * secondNum;
                default:
                    return 9999999999;
            }
        }
    }
}
