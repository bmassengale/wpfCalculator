namespace WPFcalculatorUI.Services
{
    public interface ICalculationService
    {
        public string ReceiveInput(object sender);
        public float PerformCalculation(object sender, float firstNum, float secondNum, string symbol);
    }
}
