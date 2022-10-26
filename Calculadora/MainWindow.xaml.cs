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
/// <summary>
/// Projeto Calculadora
/// </summary>
namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string conta;
        double resultadoTotal;
        double numUm;
        double numDois;
        string resultado;
        bool SinalJaFoi = false;
        bool IgualJaFoi = false;
        string operador;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Click_Num1(object sender, RoutedEventArgs e)
        {
            if(IgualJaFoi == false)
            {
                if (Conta.Text == "0")
                {
                    Conta.Text = "";
                }
                Conta.Text += "1";
                conta = Conta.Text;
            }
            else
            {
                SinalJaFoi = false;
                IgualJaFoi = false;
                Conta.Text = "";
                Conta.Text += "1";
            }
            
        }

        private void Click_Num2(object sender, RoutedEventArgs e)
        {
            if (IgualJaFoi == false)
            {
                if (Conta.Text == "0")
                {
                    Conta.Text = "";
                }
                Conta.Text += "2";
                conta = Conta.Text;
            }
            else
            {
                SinalJaFoi = false;
                IgualJaFoi = false;
                Conta.Text = "";
                Conta.Text += "2";
            }
        }

        private void Click_Num3(object sender, RoutedEventArgs e)
        {
            if (IgualJaFoi == false)
            {
                if (Conta.Text == "0")
                {
                    Conta.Text = "";
                }
                Conta.Text += "3";
                conta = Conta.Text;
            }
            else
            {
                SinalJaFoi = false;
                IgualJaFoi = false;
                Conta.Text = "";
                Conta.Text += "3";
            }
        }

        private void Click_Num4(object sender, RoutedEventArgs e)
        {
            if (IgualJaFoi == false)
            {
                if (Conta.Text == "0")
                {
                    Conta.Text = "";
                }
                Conta.Text += "4";
                conta = Conta.Text;
            }
            else
            {
                SinalJaFoi = false;
                IgualJaFoi = false;
                Conta.Text = "";
                Conta.Text += "4";

            }
        }

        private void Click_Num5(object sender, RoutedEventArgs e)
        {
            if (IgualJaFoi == false)
            {
                if (Conta.Text == "0")
                {
                    Conta.Text = "";
                }
                Conta.Text += "5";
                conta = Conta.Text;
            }
            else
            {
                SinalJaFoi = false;
                IgualJaFoi = false;
                Conta.Text = "";
                Conta.Text += "5";

            }
        }

        private void Click_Num6(object sender, RoutedEventArgs e)
        {
            if (IgualJaFoi == false)
            {
                if (Conta.Text == "0")
                {
                    Conta.Text = "";
                }
                Conta.Text += "6";
                conta = Conta.Text;
            }
            else
            {
                SinalJaFoi = false;
                IgualJaFoi = false;
                Conta.Text = "";
                Conta.Text += "6";

            }
        }

        private void Click_Num7(object sender, RoutedEventArgs e)
        {
            if (IgualJaFoi == false)
            {
                if (Conta.Text == "0")
                {
                    Conta.Text = "";
                }
                Conta.Text += "7";
                conta = Conta.Text;
            }
            else
            {
                SinalJaFoi = false;
                IgualJaFoi = false;
                Conta.Text = "";
                Conta.Text += "7";

            }
        }

        private void Click_Num8(object sender, RoutedEventArgs e)
        {
            if (IgualJaFoi == false)
            {
                if (Conta.Text == "0")
                {
                    Conta.Text = "";
                }
                Conta.Text += "8";
                conta = Conta.Text;
            }
            else
            {
                SinalJaFoi = false;
                IgualJaFoi = false;
                Conta.Text = "";
                Conta.Text += "8";

            }
        }

        private void Click_Num9(object sender, RoutedEventArgs e)
        {
            if (IgualJaFoi == false)
            {
                if (Conta.Text == "0")
                {
                    Conta.Text = "";
                }
                Conta.Text += "9";
                conta = Conta.Text;
            }
            else
            {
                SinalJaFoi = false;
                IgualJaFoi = false;
                Conta.Text = "";
                Conta.Text += "9";

            }
        }

        private void Click_Num0(object sender, RoutedEventArgs e)
        {
            if (IgualJaFoi == false)
            {
                if (Conta.Text == "0")
                {
                    Conta.Text = "";
                }
                Conta.Text += "0";
                conta = Conta.Text;
            }
            else
            {
                SinalJaFoi = false;
                IgualJaFoi = false;
                Conta.Text = "";
                Conta.Text += "0";
            }
        }

        private void btnVírgula_Click(object sender, RoutedEventArgs e)
        {
            Conta.Text += ".";
            conta = Conta.Text;
        }

        private void btnMais_Click(object sender, RoutedEventArgs e)
        {
            if (SinalJaFoi == false)
            {
                if (Visor.Text != "")
                {
                    if (operador != "+")
                    {
                        numDois = Convert.ToDouble(Conta.Text);
                        switch (operador)
                        {
                            case "*":
                                resultado = $"{numUm * numDois}";
                                break;
                            case "-":
                                resultado = $"{numUm - numDois}";
                                break;
                            case "/":
                                resultado = $"{numUm / numDois}";
                                break;
                        }

                        resultadoTotal = Convert.ToDouble(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "+";
                    }
                    else
                    {
                        operador = "+";
                        numDois = Convert.ToDouble(Conta.Text);
                        resultado = $"{numUm + numDois}";
                        numUm = Convert.ToDouble(resultado);
                        Visor.Text = $"{numUm}";
                        numUm = 0;
                    }
                    numUm = Convert.ToDouble(Visor.Text);
                    Visor.Text += "+";
                    Conta.Text = $"";
                    SinalJaFoi = true;
                }
                else
                {

                    operador = "+";
                    numUm = Convert.ToDouble(Conta.Text);
                    conta = Conta.Text;
                    Conta.Text = "";
                    Visor.Text = conta;
                    Visor.Text += "+";

                }


            }
            else
            {
                if (Conta.Text == "")
                {
                    Visor.Text = Visor.Text;
                }
                else
                {
                    if (operador != "+")
                    {
                        numDois = Convert.ToDouble(Conta.Text);
                        switch (operador)
                        {
                            case "*":
                                resultado = $"{numUm * numDois}";
                                break;
                            case "-":
                                resultado = $"{numUm - numDois}";
                                break;
                            case "/":
                                resultado = $"{numUm / numDois}";
                                break;
                        }

                        resultadoTotal = Convert.ToDouble(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "+";
                    }
                    else
                    {
                        operador = "+";
                        numDois = Convert.ToDouble(Conta.Text);
                        numDois = 0;
                        resultado = $"{numUm + numDois}";
                        numUm = Convert.ToDouble(resultado);
                        Visor.Text = $"{numUm}";
                    }
                    numUm = Convert.ToDouble(Visor.Text);
                    Visor.Text += "+";
                    Conta.Text = "";
                    SinalJaFoi = false;
                }

            }
        }

        private void btnDivisao_Click(object sender, RoutedEventArgs e)
        {
            if (SinalJaFoi == false)
            {
                if (Visor.Text != "")
                {
                    if (operador != "/")
                    {
                        numDois = Convert.ToDouble(Conta.Text);
                        switch (operador)
                        {
                            case "+":
                                resultado = $"{numUm + numDois}";
                                break;
                            case "-":
                                resultado = $"{numUm - numDois}";
                                break;
                            case "*":
                                resultado = $"{numUm * numDois}";
                                break;
                        }

                        resultadoTotal = Convert.ToDouble(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "/";
                    }
                    else
                    {
                        operador = "/";
                        numDois = Convert.ToDouble(Conta.Text);
                        resultado = $"{numUm / numDois}";
                        numUm = Convert.ToDouble(resultado);
                        Visor.Text = $"{numUm}";
                        numUm = 0;
                    }
                    numUm = Convert.ToDouble(Visor.Text);
                    Visor.Text += "/";
                    Conta.Text = $"";
                    SinalJaFoi = true;

                }
                else
                {

                    operador = "/";
                    numUm = Convert.ToDouble(Conta.Text);
                    conta = Conta.Text;
                    Conta.Text = "";
                    Visor.Text = conta;
                    Visor.Text += "/";
                }


            }
            else
            {
                if (Conta.Text == "")
                {
                    Visor.Text = Visor.Text;
                }
                else
                {
                    if (operador != "/")
                    {
                        numDois = Convert.ToDouble(Conta.Text);
                        switch (operador)
                        {
                            case "+":
                                resultado = $"{numUm + numDois}";
                                break;
                            case "-":
                                resultado = $"{numUm - numDois}";
                                break;
                            case "*":
                                resultado = $"{numUm * numDois}";
                                break;
                        }

                        resultadoTotal = Convert.ToDouble(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "/";
                    }
                    else
                    {
                        operador = "/";
                        numDois = Convert.ToDouble(Conta.Text);
                        numDois = 1;
                        resultado = $"{numUm / numDois}";
                        numUm = Convert.ToDouble(resultado);
                        Visor.Text = $"{numUm}";
                    }
                    numUm = Convert.ToDouble(Visor.Text);
                    Visor.Text += "/";
                    SinalJaFoi = false;
                }

            }
        }

        private void btnMenos_Click(object sender, RoutedEventArgs e)
        {
            if (SinalJaFoi == false)
            {
                if (Visor.Text != "")
                {
                    if (operador != "-")
                    {
                        numDois = Convert.ToDouble(Conta.Text);
                        switch (operador)
                        {
                            case "+":
                                resultado = $"{numUm + numDois}";
                                break;
                            case "*":
                                resultado = $"{numUm * numDois}";
                                break;
                            case "/":
                                resultado = $"{numUm / numDois}";
                                break;
                        }
                        resultadoTotal = Convert.ToDouble(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "-";
                    }
                    else
                    {
                        operador = "-";
                        numDois = Convert.ToDouble(Conta.Text);
                        resultado = $"{numUm - numDois}";
                        numUm = Convert.ToDouble(resultado);
                        Visor.Text = $"{numUm}";
                        numUm = 0;
                    }
                    numUm = Convert.ToDouble(Visor.Text);
                    Visor.Text += "-";
                    Conta.Text = $"";
                    SinalJaFoi = true;

                }
                else
                {

                    operador = "-";
                    numUm = Convert.ToDouble(Conta.Text);
                    conta = Conta.Text;
                    Conta.Text = "";
                    Visor.Text = conta;
                    Visor.Text += "-";
                }


            }
            else
            {
                if (Conta.Text == "")
                {
                    Visor.Text = Visor.Text;
                }
                else
                {
                    if (operador != "-")
                    {
                        numDois = Convert.ToDouble(Conta.Text);
                        switch (operador)
                        {
                            case "+":
                                resultado = $"{numUm + numDois}";
                                break;
                            case "*":
                                resultado = $"{numUm * numDois}";
                                break;
                            case "/":
                                resultado = $"{numUm / numDois}";
                                break;
                        }

                        resultadoTotal = Convert.ToDouble(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "-";
                    }
                    else
                    {
                        operador = "-";
                        numDois = Convert.ToDouble(Conta.Text);
                        numDois = 0;
                        resultado = $"{numUm - numDois}";
                        numUm = Convert.ToDouble(resultado);
                        Visor.Text = $"{numUm}";
                    }
                    numUm = Convert.ToDouble(Visor.Text);
                    Visor.Text += "-";
                    SinalJaFoi = false;
                }

            }
        }

        private void btnVezes_Click(object sender, RoutedEventArgs e)
        {
            if (SinalJaFoi == false)
            {
                if (Visor.Text != "")
                {
                    if (operador != "*")
                    {
                        numDois = Convert.ToDouble(Conta.Text);
                        switch (operador)
                        {
                            case "+":
                                resultado = $"{numUm + numDois}";
                                break;
                            case "-":
                                resultado = $"{numUm - numDois}";
                                break;
                            case "/":
                                resultado = $"{numUm / numDois}";
                                break;
                        }

                        resultadoTotal = Convert.ToDouble(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "*";
                    }
                    else
                    {

                        operador = "*";
                        numDois = Convert.ToDouble(Conta.Text);
                        resultado = $"{numUm * numDois}";
                        numUm = Convert.ToDouble(resultado);
                        Visor.Text = $"{numUm}";
                        numUm = 0;
                    }
                    numUm = Convert.ToDouble(Visor.Text);
                    Visor.Text += "*";
                    Conta.Text = $"";
                    SinalJaFoi = true;

                }
                else
                {

                    operador = "*";
                    numUm = Convert.ToDouble(Conta.Text);
                    conta = Conta.Text;
                    Conta.Text = "";
                    Visor.Text = conta;
                    Visor.Text += "*";
                }


            }
            else
            {
                if (Conta.Text == "")
                {
                    Visor.Text = Visor.Text;
                }
                else
                {
                    if (operador != "*")
                    {
                        numDois = Convert.ToDouble(Conta.Text);
                        switch (operador)
                        {
                            case "+":
                                resultado = $"{numUm + numDois}";
                                break;
                            case "-":
                                resultado = $"{numUm - numDois}";
                                break;
                            case "/":
                                resultado = $"{numUm / numDois}";
                                break;
                        }

                        resultadoTotal = Convert.ToInt32(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "*";
                    }
                    else
                    {
                        operador = "*";
                        numDois = Convert.ToDouble(Conta.Text);
                        numDois = 1;
                        resultado = $"{numUm * numDois}";
                        numUm = Convert.ToDouble(resultado);
                        Visor.Text = $"{numUm}";
                    }
                    numUm = Convert.ToDouble(Visor.Text);
                    Visor.Text += "*";
                    SinalJaFoi = false;
                }

            }
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            numDois = Convert.ToDouble(Conta.Text);
            switch (operador)
            {
                case "+":
                    resultado = $"{numUm + numDois}";
                    break;
                case "-":
                    resultado = $"{numUm - numDois}";
                    break;
                case "/":
                    resultado = $"{numUm / numDois}";
                    break;
                case "*":
                    resultado = $"{numUm * numDois}";
                    break;
            }
            Visor.Text = $"{numUm}{operador}{numDois} =";
            numUm = Convert.ToDouble(resultado);
            Conta.Text = resultado;
            IgualJaFoi = true;
            SinalJaFoi = true;
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            Conta.Text = "0";
            SinalJaFoi = false;
            numUm = 0;
            numDois = 0;
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            SinalJaFoi = false;
            Visor.Text = "";
            Conta.Text = "0";
            numUm = 0;
            numDois = 0;
        }

        private void btnApaga_Click(object sender, RoutedEventArgs e)
        {
            if(Conta.Text.Length > 0)
            {
                Conta.Text = Conta.Text[..^1];
            }
            else
            {
                Conta.Text = Conta.Text;
            }
        }
    }
}