using System;
using System.Data;
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
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Messaging;

namespace Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double temp;
        double result;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            ResultTB.Text += str;
        }

        private void EqualsBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (HelperTB.Text.Contains("+"))
                {
                    result = Convert.ToDouble(temp) + Convert.ToDouble(ResultTB.Text);
                }
                else if (HelperTB.Text.Contains("-"))
                {
                    result = Convert.ToDouble(temp) - Convert.ToDouble(ResultTB.Text);
                }
                else if (HelperTB.Text.Contains("*"))
                {
                    result = Convert.ToDouble(temp) * Convert.ToDouble(ResultTB.Text);
                }
                else if (HelperTB.Text.Contains("^"))
                {
                    result =Math.Pow(Convert.ToDouble(temp),Convert.ToDouble(ResultTB.Text));
                }
                else if (HelperTB.Text.Contains("√"))
                {
                    result =Math.Sqrt(Convert.ToDouble(ResultTB.Text));
                }
                else if (HelperTB.Text.Contains("!"))
                {
                    result = Convert.ToInt64(ResultTB.Text);
                    long factorial = 1;
                    for (int i = 1; i <= result; i++)
                    {
                        factorial *= i;
                    }
                    result = factorial;
                }
                else if (HelperTB.Text.Contains("Sin"))
                {
                    result = Math.Sin(Convert.ToDouble(ResultTB.Text));
                }
                else if (HelperTB.Text.Contains("Cos"))
                {
                    result = Math.Cos(Convert.ToDouble(ResultTB.Text));
                }
                else if (HelperTB.Text.Contains("Tg"))
                {
                    result = Math.Tan(Convert.ToDouble(ResultTB.Text));
                }
                else if (HelperTB.Text.Contains("Ctg"))
                {
                    result = 1/Math.Tan(Convert.ToDouble(ResultTB.Text));
                }
                else if (HelperTB.Text.Contains("Log"))
                {
                    result = Math.Log10(Convert.ToDouble(ResultTB.Text));
                }
                else if (HelperTB.Text.Contains("Ln"))
                {
                    result = Math.Log(Convert.ToDouble(ResultTB.Text));
                }
                else if (HelperTB.Text.Contains("1/x"))
                {
                    result = 1/(Convert.ToDouble(ResultTB.Text));
                }
                else if (HelperTB.Text.Contains("%"))
                {
                    result = Convert.ToDouble(temp) * Convert.ToDouble(ResultTB.Text) / 100;
                }
                else if (HelperTB.Text.Contains("DegToRBT"))
                {
                    result = Convert.ToDouble(ResultTB.Text) * Math.PI/180;
                }
                else if (HelperTB.Text.Contains("RadToDBT"))
                {
                    result = Convert.ToDouble(ResultTB.Text) * 180/Math.PI ;
                }
                
                else if (HelperTB.Text.Contains("eX"))
                {
                    result = Math.Exp(Convert.ToDouble(ResultTB.Text));
                }
                ResultTB.Text = Convert.ToString(result);
            }
            catch { }
        }

        private void ClearBT_Click(object sender, RoutedEventArgs e)
        {
            ResultTB.Text = "";
            HelperTB.Text = "";
        }

        void SecondNumber()
        {
            temp = Convert.ToDouble(ResultTB.Text);
            ResultTB.Text = "";
        }


        private void SeparationBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "/";
                SecondNumber();
        }

        private void MultiplicationBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "*";
                SecondNumber();
        }

        private void MinusBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "-";
                SecondNumber();
        }

        private void PlusBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "+";
                SecondNumber();
        }

        private void PowBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "^";
                SecondNumber();
        }

        private void SqrtBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "√";
        }

        private void FactorialBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "!";
        }

        private void SinBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "Sin";
        }

        private void CosBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "Cos";
        }

        private void TgBT_Click(object sender, RoutedEventArgs e)
        {
            HelperTB.Text = "Tg";
        }

        private void CtgBT_Click(object sender, RoutedEventArgs e)
        {
            HelperTB.Text = "Ctg";
        }

        private void LogBT_Click(object sender, RoutedEventArgs e)
        {
            HelperTB.Text = "Log";
        }

        private void LnBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "Ln";
        }

        private void xBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "1/x";
        }

        private void ProcBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "%";
                SecondNumber();
        }

        private void eXBT_Click(object sender, RoutedEventArgs e)
        {
             HelperTB.Text = "eX";
        }

        private void RadToDBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "RadToDBT";
        }

        private void DegToRBT_Click(object sender, RoutedEventArgs e)
        {
                HelperTB.Text = "DegToRBT";
        }    

    }
}
