using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract2_Descuentos
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
            decimal ValorVentas;
            decimal DescuentoPorcentaje;
            decimal DescuentoVentas;
            decimal VentasTotales;

            if (!decimal.TryParse(txtValorVenta.Text, out ValorVentas))
            {
                MessageBox.Show("El texbox está vacío");
            }
            else
            {
                if (ValorVentas >= 500)
                {
                    DescuentoPorcentaje = 0.30m;
                }
                else if (ValorVentas >= 300 && ValorVentas <= 499)
                {
                    DescuentoPorcentaje = 0.20m;
                }
                else if (ValorVentas > 100 && ValorVentas <= 299)
                {
                    DescuentoPorcentaje = 0.10m;
                }
                else
                {
                    DescuentoPorcentaje = 0;
                }

                DescuentoVentas = ValorVentas * DescuentoPorcentaje;
                VentasTotales = ValorVentas - DescuentoVentas;

                txtVentaFinal.Text = VentasTotales.ToString();
                txtDescuentoPorcentaje.Text = DescuentoPorcentaje.ToString();
                txtDescuento.Text = DescuentoVentas.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorVenta.Text = "";
            txtDescuento.Text = "";
            txtDescuentoPorcentaje.Text = "";
            txtVentaFinal.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El programa está por cerrar", "Cerrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
