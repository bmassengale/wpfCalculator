namespace WPFcalculatorUI.Services
{
    public interface ICalculationService
    {
        public string ReceiveInput(object buttonContent);
        public float PerformCalculation(float firstNum, float secondNum, string symbol);
    }
}
