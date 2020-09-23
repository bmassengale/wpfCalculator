using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFcalculatorUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float result = 0;
        public string CurrentInput { get; set; }
        private string previousInput =  "";
        private string symbol = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        public void OnClick_Decimal(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
            currentInputTextBlock.Text = CurrentInput;
        }

        public void OnClick_Zero(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
            currentInputTextBlock.Text = CurrentInput;
        }

        public void OnClick_One(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
            currentInputTextBlock.Text = CurrentInput;
        }

        public void OnClick_Two(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
            currentInputTextBlock.Text = CurrentInput;
        }

        public void OnClick_Three(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
            currentInputTextBlock.Text = CurrentInput;
        }

        public void OnClick_Four(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
            currentInputTextBlock.Text = CurrentInput;

        }

        public void OnClick_Five(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
            currentInputTextBlock.Text = CurrentInput;
        }

        public void OnClick_Six(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
            currentInputTextBlock.Text = CurrentInput;
        }

        public void OnClick_Seven(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
            currentInputTextBlock.Text = CurrentInput;
        }

        public void OnClick_Eight(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
            currentInputTextBlock.Text = CurrentInput;
        }

        public void OnClick_Nine(object sender, EventArgs e)
        {
            CurrentInput += (sender as Button).Content;
            currentInputTextBlock.Text = CurrentInput;
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
            currentInputTextBlock.Text = CurrentInput;
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
            currentInputTextBlock.Text = result.ToString();

        }
    }
}