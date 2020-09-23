using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;


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

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        protected void Notify(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void OnClick_Decimal(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
        }

        public void OnClick_Zero(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
        }

        public void OnClick_One(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
        }

        public void OnClick_Two(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
        }

        public void OnClick_Three(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
        }

        public void OnClick_Four(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
        }

        public void OnClick_Five(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
        }

        public void OnClick_Six(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
        }

        public void OnClick_Seven(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
        }

        public void OnClick_Eight(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;

        }

        public void OnClick_Nine(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
        }



        public void OnClick_Divide(object sender, EventArgs e)
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
            symbol = "/";
        }

        public void OnClick_Multiply(object sender, EventArgs e)
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
            symbol = "*";
        }

        public void OnClick_Add(object sender, EventArgs e)
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
            symbol = "+";
        }

        public void OnClick_Subtract(object sender, EventArgs e)
        {
            if(CurrentInput == "")
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
            symbol = "-";
        }



        public void OnClick_Clear(object sender, EventArgs e)
        {
            previousInput = "";
            CurrentInput = "";
            symbol = "";
        }

        public void OnClick_Compute(object sender, EventArgs e)
        {
            switch(symbol)
            {
                case "+":
                   result = float.Parse(previousInput) + float.Parse(CurrentInput);
                    break;
                case "-":
                    result = float.Parse(previousInput) - float.Parse(CurrentInput);
                    break;

                case "/":
                    result = float.Parse(previousInput) / float.Parse(CurrentInput);
                    break;
                case "*":
                    result = float.Parse(previousInput) * float.Parse(CurrentInput);
                    break;
                default:
                    result = 9999999999;
                    break;
            }
            CurrentInput = result.ToString();
        }
    }
}