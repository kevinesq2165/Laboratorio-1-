using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract3_EstructuraIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal num1;
            decimal num2;

            if (!decimal.TryParse(txtNum1.Text, out num1) || !decimal.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Ingrese valores válidos");
            }
            else
            {
                decimal resultado = 0;

                if (rbSuma.Checked)
                {
                    lblSimbolo.Text = "+";
                    resultado = num1 + num2;
                }
                else if (rbResta.Checked)
                {
                    lblSimbolo.Text = "-";
                    resultado = num1 - num2;
                }
                else if (rbMultiplicacion.Checked)
                {
                    lblSimbolo.Text = "*";
                    resultado = num1 * num2;
                }
                else if (rbDivision.Checked)
                {
                    lblSimbolo.Text = "/";

                    if (num2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero.");
                        return;
                    }

                    resultado = num1 / num2;
                }
                else
                {
                    MessageBox.Show("Selecciona una operación");
                    return;
                }

                txtResultado.Text = resultado.ToString();

            }
        }
    }
}
