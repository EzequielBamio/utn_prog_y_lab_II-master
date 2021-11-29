using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace Ejercicio_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinADec_Click(object sender, EventArgs e)
        {
            string binario;
            binario = txtBinario.Text;
            NumeroBinario numero = (NumeroBinario)binario;

            txtBinADec.Text = ((NumeroDecimal)numero).GetNumero().ToString();
        }

        private void btnDecABin_Click(object sender, EventArgs e)
        {
            double numero;
            double.TryParse(txtDecimal.Text, out numero);
            NumeroDecimal numeroDecimal = (NumeroDecimal)numero;

            txtDecABin.Text = ((NumeroBinario)numeroDecimal).GetNumero();

        }

        private void txtBinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) 
            {
                e.Handled = true;
                MessageBox.Show("Solo se pueden ingresar numeros.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se pueden ingresar numeros.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
