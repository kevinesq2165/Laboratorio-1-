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
                lblFecha.Text = "La fecha es: " + txtDia.Text + " " + txtMes.Text + " " + txtAnio.Text;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La ventana está por cerrar");
            MessageBox.Show("Cerrando","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information); 
            this.Close();
        }
    }
}
