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

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private double NumberOk(string text)
        {
            text = text.Replace(".", ",");

            try
            {
                return double.Parse(text);
            }
            catch (Exception errorMsg)
            {
               throw new Exception($"This {text} does not have the correct format, try again");
            }
        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            AddNumbers();
        }
        private void btnSubstract_Click(object sender, RoutedEventArgs e)
        {
            SubstractNumbers();
        }
        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            MultiplyNumbers();
        }
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            DivideNumbers();
        }
        private void AddNumbers()
        {
            
            var num1Text = txtFirst.Text; // get the first number
            var num1 = 0.0;

            try
            {
                num1 = NumberOk(num1Text); // verify that is a double
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

            var num2Text = txtSecond.Text; // get the second number
            var num2 = 0.0;

            try
            {
                num2 = NumberOk(num2Text);// verify that is a double
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

            var suma = num1 + num2; // make the operation

            MessageBox.Show($"The result of the add is: {suma.ToString()}", "Calculator");
        }

        
        private void SubstractNumbers()
        {

            var num1Text = txtFirst.Text; // get the first number
            var num1 = 0.0;

            try
            {
                num1 = NumberOk(num1Text); // verify that is a double
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

            var num2Text = txtSecond.Text; // get the second number
            var num2 = 0.0;

            try
            {
                num2 = NumberOk(num2Text);// verify that is a double
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

            var substract = num1 - num2; // make the operation

            MessageBox.Show($"The result of the substract is: {substract.ToString()}", "Calculator");
        }
        private void MultiplyNumbers()
        {

            var num1Text = txtFirst.Text; // get the first number
            var num1 = 0.0;

            try
            {
                num1 = NumberOk(num1Text); // verify that is a double
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

            var num2Text = txtSecond.Text; // get the second number
            var num2 = 0.0;

            try
            {
                num2 = NumberOk(num2Text);// verify that is a double
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

            var multiply = num1 * num2; // make the operation

            MessageBox.Show($"The result of the multiply is: {multiply.ToString()}", "Calculator");
        }
        private void DivideNumbers()
        {

            var num1Text = txtFirst.Text; // get the first number
            var num1 = 0.0;

            try
            {
                num1 = NumberOk(num1Text); // verify that is a double
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

            var num2Text = txtSecond.Text; // get the second number
            var num2 = 0.0;

            try
            {
                num2 = NumberOk(num2Text);// verify that is a double

                if (num2 == 0)
                {
                    MessageBox.Show($"A number cannot be divided by 0");
                    txtSecond.Clear();
                    
                }
                else
                {
                    var divide = num1 / num2; // make the operation

                    MessageBox.Show($"The result of the divide is: {divide.ToString()}", "Calculator");
                }
                
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

           
        }

       
    }
}
