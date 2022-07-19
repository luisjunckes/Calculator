using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(lbResultado.Text=="0")
            {
                lbResultado.Text = "1";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "1";
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0")
            {
                lbResultado.Text = "2";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "2";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0")
            {
                lbResultado.Text = "0";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "0";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0")
            {
                lbResultado.Text = "3";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0")
            {
                lbResultado.Text = "4";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0")
            {
                lbResultado.Text = "5";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0")
            {
                lbResultado.Text = "6";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0")
            {
                lbResultado.Text = "7";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0")
            {
                lbResultado.Text = "8";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text == "0")
            {
                lbResultado.Text = "9";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "9";
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text != "0")
                lbResultado.Text = lbResultado.Text + "+";

            /*if (lbResultado.Text == "0")
            {
                lbResultado.Text = "+";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "+";
            }*/
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text != "0")
                lbResultado.Text = lbResultado.Text + "-";

            /*if (lbResultado.Text == "0")
            {
                lbResultado.Text = "-";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "-";
            }*/
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (lbResultado.Text != "0")
                lbResultado.Text = lbResultado.Text + "x";

            /*if (lbResultado.Text == "0")
            {
                lbResultado.Text = "x";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "x";
            }*/
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if(lbResultado.Text!="0")
                lbResultado.Text = lbResultado.Text + "/";

            /*if (lbResultado.Text == "0")
            {
                lbResultado.Text = "/";
            }
            else
            {
                lbResultado.Text = lbResultado.Text + "/";
            }*/
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            lbResultado.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal valor1 = 0;
            decimal valor2 = 0;
            decimal resultado = 0;
            string operador = null;

            if (lbResultado.Text != "0")
            {
                string numero = null;
                for(int i=0; i < lbResultado.Text.Length; i++)
                {
                    if(lbResultado.Text[i].ToString()!="+" &&
                        lbResultado.Text[i].ToString()!="-"&&
                        lbResultado.Text[i].ToString()!="x"&&
                        lbResultado.Text[i].ToString()!="/" &&
                        i+1 <lbResultado.Text.Length)
                    {
                        numero = numero + lbResultado.Text[i];
                    }
                    else
                    {
                        if(lbResultado.Text[i].ToString()=="+"||
                           lbResultado.Text[i].ToString() == "-" ||
                           lbResultado.Text[i].ToString() == "x" ||
                           lbResultado.Text[i].ToString() == "/")
                        operador = lbResultado.Text[i].ToString();
                        if(valor1==0)
                        {
                            valor1 = Convert.ToDecimal(numero);
                            numero = null;
                        }
                        else
                        {
                            if (resultado != 0)
                                valor1 = resultado;
                            if(valor2==0)
                            {
                                if (i + 1 == lbResultado.Text.Length)
                                    valor2 = Convert.ToDecimal(numero + lbResultado.Text[i]);
                                else
                                    valor2 = Convert.ToDecimal(numero);

                                //colocar método de cálculo aqui
                                resultado = Calcular(valor1, operador, valor2);

                                valor2 = 0;
                                numero = null;
                            }
                        }
                    }
                }
                lbResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Digitação inválida!");
        }

        private decimal Calcular(decimal valor1, string operador, decimal valor2)
        {
            if (operador.Equals("+"))
                return valor1 + valor2;
            if (operador.Equals("-"))
                return valor1 - valor2;
            if (operador.Equals("x"))
                return valor1 * valor2;
            if (operador.Equals("/"))
                return valor1 / valor2;
            return 0;
        }
    }
}
