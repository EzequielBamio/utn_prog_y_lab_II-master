using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Billetes;

namespace Ejercicio_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBloqued_Click(object sender, EventArgs e)
        {

            if (btnBloqued.ImageIndex.Equals(0))
            {
                this.btnBloqued.ImageIndex = 1;
                this.txtCotizacionEuro.Enabled = true;
                this.txtCotizacionPesos.Enabled = true;
            }
            else 
            {
                this.btnBloqued.ImageIndex = 0;
                this.txtCotizacionEuro.Enabled = false;
                this.txtCotizacionPesos.Enabled = false;
            }
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            double cantidad;
            double.TryParse(this.txtEuro.Text, out cantidad);
            Euro euro = new Euro(cantidad);

            txtEuroDolar.Text = ((Dolar)euro).GetCantidad().ToString();
            txtEuroPesos.Text = ((Pesos)euro).GetCantidad().ToString();
            txtCantidadEuro.Text = euro.GetCantidad().ToString();

        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            double cantidad;
            double.TryParse(this.txtDolar.Text, out cantidad);
            Dolar dolar = new Dolar(cantidad);

            txtDolarEuro.Text = ((Euro)dolar).GetCantidad().ToString();
            txtDolarPesos.Text = ((Pesos)dolar).GetCantidad().ToString();
            txtCantidadDolar.Text = dolar.GetCantidad().ToString();
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            double cantidad;
            double.TryParse(this.txtPesos.Text, out cantidad);
            Pesos pesos = new Pesos(cantidad);

            txtPesosEuro.Text = ((Euro)pesos).GetCantidad().ToString();
            txtPesosDolar.Text = ((Dolar)pesos).GetCantidad().ToString();
            txtCantidadPesos.Text = pesos.GetCantidad().ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            this.txtCotizacionPesos.Text = Pesos.GetCotizacion().ToString();
            this.txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();

        }

        private void txtCotizacionEuro_TextChanged(object sender, EventArgs e)
        {
            double cotizacion;
            double.TryParse(this.txtCotizacionEuro.Text, out cotizacion);
            Euro.SetCotizacion(cotizacion);
        }

        private void txtCotizacionPesos_TextChanged(object sender, EventArgs e)
        {
            double cotizacion;
            double.TryParse(this.txtCotizacionPesos.Text, out cotizacion);
            Pesos.SetCotizacion(cotizacion);
        }

        private void txtCotizacionEuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo ingrese numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCotizacionPesos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo ingrese numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo ingrese numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo ingrese numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo ingrese numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
