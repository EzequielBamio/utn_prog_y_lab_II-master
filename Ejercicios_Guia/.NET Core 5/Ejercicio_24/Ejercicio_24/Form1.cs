using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Grados;

namespace Ejercicio_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            double grados;
            double.TryParse(txtF.Text, out grados);//guardo los grados del textbox
            Fahrenheit fahrenheit = new Fahrenheit(grados);

            txtFaAFa.Text = fahrenheit.GetGrados().ToString();
            txtFaACe.Text = ((Celsius)fahrenheit).GetGrados().ToString();
            txtFaAKe.Text = ((Kelvin)fahrenheit).GetGrados().ToString();
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            double grados;
            double.TryParse(txtK.Text, out grados);
            Kelvin kelvin = new Kelvin(grados);

            txtKeAKe.Text = kelvin.GetGrados().ToString();
            txtKeAFa.Text = ((Fahrenheit)kelvin).GetGrados().ToString();
            txtKeACe.Text = ((Celsius)kelvin).GetGrados().ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            double grados;
            double.TryParse(txtC.Text, out grados);
            Celsius celsius = new Celsius(grados);

            txtCeACe.Text = celsius.GetGrados().ToString();
            txtCeAFa.Text = ((Fahrenheit)celsius).GetGrados().ToString();
            txtCeAKe.Text = ((Kelvin)celsius).GetGrados().ToString();
        }

        private void txtF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) 
            {
                e.Handled = true;
                MessageBox.Show("Solo se pueden ingresar numeros.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se pueden ingresar numeros.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se pueden ingresar numeros.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
