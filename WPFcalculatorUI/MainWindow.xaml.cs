using System;
using System.ComponentModel;
using System.Windows;
using WPFcalculatorUI.Services;

namespace WPFcalculatorUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private float result = 0;
        private string _currentInput;
        public string CurrentInput {
            get
            {
                return _currentInput;
            }
            set
            {
                _currentInput = value;
                Notify("CurrentInput");
            }
        }
        private string previousInput =  "";
        private string symbol = "";
        private readonly ICalculationService _calculationService;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow(ICalculationService calculationService)
        {
            InitializeComponent();
            this.DataContext = this;
            _calculationService = calculationService;
        }

        protected void Notify(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void OnClick_Number(object sender, EventArgs e)
        {
            CurrentInput += _calculationService.ReceiveInput(sender);
        }

        public void OnClick_Symbol(object sender, EventArgs e)
        {
            if (CurrentInput == "")
            {
                CurrentInput = "";
                return;
            }
            if (previousInput != "")
            {
                OnClick_Compute(sender, e);
            }
            previousInput = CurrentInput;
            CurrentInput = "";
            symbol = _calculationService.ReceiveInput(sender);
        }

        public void OnClick_Clear(object sender, EventArgs e)
        {
            previousInput = "";
            CurrentInput = "";
            symbol = "";
        }

        public void OnClick_Compute(object sender, EventArgs e)
        {
            result = _calculationService.PerformCalculation(sender, float.Parse(previousInput), float.Parse(CurrentInput), symbol);
            CurrentInput = result.ToString();
        }
    }
}