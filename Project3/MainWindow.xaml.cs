using System;
using System.Collections.Generic;
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

namespace Project3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double number1 = 0;
        private double number2 = 0;
        private string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void clickNum1(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                number1 = 1;
                calcText.Text = number1.ToString();
            }
            else
            {
                number2 = 1;
                calcText.Text = number2.ToString();
            }

        }

        private void clickNum0(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
                calcText.Text = number1.ToString();
            }
            else
            {
                number2 = 0;
                calcText.Text = number2.ToString();
            }
        }

        private void clickNum2(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 2;
                calcText.Text = number1.ToString();
            }
            else
            {
                number2 = 2;
                calcText.Text = number2.ToString();
            }
        }

        private void clickNum3(object sender, RoutedEventArgs e)
        {
          if (operation == "")
          {
                number1 = 3;
                calcText.Text = number1.ToString();
            }
            else
            {
                number2 = 3;
                calcText.Text = number2.ToString();
           }
        }

        private void clickNum4(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 4;
                calcText.Text = number1.ToString();
            }
            else
            {
                number2 = 4;
                calcText.Text = number2.ToString();
            }
        }

        private void clickNum5(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 5;
                calcText.Text = number1.ToString();
            }
            else
            {
                number2 = 5;
                calcText.Text = number2.ToString();
            }
        }

        private void clickNum6(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 6;
                calcText.Text = number1.ToString();
            }
            else
            {
                number2 = 6;
                calcText.Text = number2.ToString();
            }
        }

        private void clickNum7(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 7;
                calcText.Text = number1.ToString();
            }
            else
            {
                number2 = 7;
                calcText.Text = number2.ToString();
            }
        }

        private void clickNum8(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 8;
                calcText.Text = number1.ToString();
            }
            else
            {
                number2 = 8;
                calcText.Text = number2.ToString();
            }
        }

        private void clickNum9(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 9;
                calcText.Text = number1.ToString();
            }
            else
            {
                number2 = 9;
                calcText.Text = number2.ToString();
            }
        }

        private void clickOn(object sender, RoutedEventArgs e)
        {
            num0.IsEnabled = true;
            num1.IsEnabled = true;
            num2.IsEnabled = true;
            num3.IsEnabled = true;
            num4.IsEnabled = true;
            num5.IsEnabled = true;
            num6.IsEnabled = true;
            num7.IsEnabled = true;
            num8.IsEnabled = true;
            num9.IsEnabled = true;
            offButton.IsEnabled = true;
            minusButton.IsEnabled = true;
            multButton.IsEnabled = true;
            plusButton.IsEnabled = true;
            divButton.IsEnabled = true;
            equalsButton.IsEnabled = true;
            onButton.IsEnabled = false;
            clearButton.IsEnabled = true;
            calcText.Text = "";
        }

        private void clickOff(object sender, RoutedEventArgs e)
        {
            num0.IsEnabled = false;
            num1.IsEnabled = false;
            num2.IsEnabled = false;
            num3.IsEnabled = false;
            num4.IsEnabled = false;
            num5.IsEnabled = false;
            num6.IsEnabled = false;
            num7.IsEnabled = false;
            num8.IsEnabled = false;
            num9.IsEnabled = false;
            offButton.IsEnabled = false;
            minusButton.IsEnabled = false;
            multButton.IsEnabled = false;
            plusButton.IsEnabled = false;
            divButton.IsEnabled = false;
            equalsButton.IsEnabled = false;
            onButton.IsEnabled = true;
            clearButton.IsEnabled = false;
            calcText.Text = "Off";
            number1 = 0;
            number2 = 0;
            operation = "";
        }

        private void clickClear(object sender, RoutedEventArgs e)
        {
            calcText.Text = "";
            number1 = 0;
            number2 = 0;
            operation = "";
        }

        private void clickPlus(object sender, RoutedEventArgs e)
        {
            operation = "+";
            calcText.Text = number1.ToString();
        }

        private void clickDiv(object sender, RoutedEventArgs e)
        {
            operation = "/";
            calcText.Text = number1.ToString();
        }

        private void clickMult(object sender, RoutedEventArgs e)
        {
            operation = "*";
            calcText.Text = number1.ToString();
        }

        private void clickMinus(object sender, RoutedEventArgs e)
        {
            operation = "-";
            calcText.Text = number1.ToString();
        }

        private void clickEquals(object sender, RoutedEventArgs e)
        {
            Calculator myCalculator = new Calculator();
            switch (operation)
            {
                case "+":
                    calcText.Text = myCalculator.Add(number1,number2).ToString();
                    operation = "";
                    break;
                case "-":
                    calcText.Text = myCalculator.Subtract(number1,number2).ToString();
                    operation = "";
                    break;
                case "/":
                    calcText.Text = myCalculator.Divide(number1,number2).ToString();
                    operation = "";
                    break;
                case "*":
                    calcText.Text = myCalculator.Multiply(number1,number2).ToString();
                    operation = "";
                    break;
            }
        }

    }
}
