using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculadora calc = new Calculadora();

        string tempx = "";
        string tempy = "";
        string operador = "";

        private void sum_Click(object sender, EventArgs e)
        {
            sum.Text = "+";
            operador = sum.Text;
            resultbox.Text = "";

        }

        private void sub_Click(object sender, EventArgs e)
        {
            sub.Text = "-";
            operador = sub.Text;
            resultbox.Text = "";
        }

        private void div_Click(object sender, EventArgs e)
        {
            div.Text = "/";
            operador = div.Text;
            resultbox.Text = "";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            mult.Text = "*";
            operador = mult.Text;
            resultbox.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = "1";

            if (operador == "")
            {
             tempx = btn1.Text;
            }
            else
            {
             tempy = btn1.Text;
            }
            
            resultbox.Text = resultbox.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Text = "2";
           
            if (operador == "")
            {
                tempx = btn2.Text;
            }
            else
            {
                tempy = btn2.Text;
            }
            resultbox.Text = resultbox.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Text = "3";

            if (operador == "")
            {
                tempx = btn3.Text;
            }
            else
            {
                tempy = btn3.Text;
            }

            resultbox.Text = resultbox.Text + btn3.Text;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Text = "4";
            if (operador == "")
            {
                tempx = btn4.Text;
            }
            else
            {
                tempy = btn4.Text;
            }
            resultbox.Text = resultbox.Text + btn4.Text;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Text = "5";
            if (operador == "")
            {
                tempx = btn5.Text;
            }
            else
            {
                tempy = btn5.Text;
            }
            resultbox.Text = resultbox.Text + btn5.Text;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Text = "6";
            if (operador == "")
            {
                tempx = btn6.Text;
            }
            else
            {
                tempy = btn6.Text;
            }
            resultbox.Text = resultbox.Text + btn6.Text;

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Text = "7";
            if (operador == "")
            {
                tempx = btn7.Text;
            }
            else
            {
                tempy = btn7.Text;
            }
            resultbox.Text = resultbox.Text + btn7.Text;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Text = "8";
            if (operador == "")
            {
                tempx = btn8.Text;
            }
            else
            {
                tempy = btn8.Text;
            }
            resultbox.Text = resultbox.Text + btn8.Text;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Text = "9";
            if (operador == "")
            {
                tempx = btn9.Text;
            }
            else
            {
                tempy = btn9.Text;
            }
            resultbox.Text = resultbox.Text + btn9.Text;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            btn0.Text = "0";
            if (operador == "")
            {
                tempx = btn0.Text;
            }
            else
            {
                tempy = btn0.Text;
            }
            resultbox.Text = resultbox.Text + btn0.Text;

        }

        private void clearC_Click(object sender, EventArgs e)
        {
       
            resultbox.Text = "";
            tempx = "";
            tempy = "";
            operador = "";
        }


        

        private void btnresult_Click(object sender, EventArgs e)
        {

            int n1 = calc.n1(int.Parse(tempx));
            int n2 = calc.n2(int.Parse(tempy));

           if (operador.Contains("+"))
            {
                resultbox.Text = (int.Parse(tempx) + int.Parse(tempy)).ToString();
            }
            else if (operador.Contains("-"))
            {
                resultbox.Text = calc.subtrair().ToString();
            }
            else if (operador.Contains("/"))
            {
                resultbox.Text = calc.dividir().ToString();
            }
            else if (operador.Contains("*"))
            {
                resultbox.Text = calc.multiplicar().ToString();
            }

        }
    }
}
