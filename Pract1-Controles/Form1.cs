using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1_Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDia.Text) || string.IsNullOrWhiteSpace(txtMes.Text) || string.IsNullOrWhiteSpace(txtAnio.Text))
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                int dia;
                int mes;

                if (!int.TryParse(txtDia.Text, out dia) || dia < 1 || dia > 31)
                {
                    MessageBox.Show("El día debe ser un número entre 1 y 31");
                }
                else if (!int.TryParse(txtMes.Text, out mes) || mes < 1 || mes > 12)
                {
                    MessageBox.Show("El mes debe ser un número entre 1 y 12");
                }
                else
                {
                    lblFecha.Text = "La fecha es: " + txtDia.Text + " " + txtMes.Text + " " + txtAnio.Text;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La ventana está por cerrar");
            MessageBox.Show("Cerrando", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

