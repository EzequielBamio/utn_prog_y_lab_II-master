using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace TP1_From
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Limpiar() 
        {
            lblResultado.Text = "0";
            txtNumero1.Text = "0";
            txtNumero2.Text = "0";
            cmbOperador.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultadoBinario;
            resultadoBinario = Operando.DecimalBinario(lblResultado.Text);

            lblResultado.Text = resultadoBinario;
            lstOperaciones.Items.Add(resultadoBinario);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultadoDecimal;
            resultadoDecimal = Operando.BinarioDecimal(lblResultado.Text);

            lblResultado.Text = resultadoDecimal;
            lstOperaciones.Items.Add(resultadoDecimal);
        }

        private static double Operar(string numero1, string numero2, string operador) 
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);

            return Calculadora.Operar(operando1, operando2, char.Parse(operador));
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string resultado;
            string operador = cmbOperador.Text;
            if (operador == "")
            {
                operador = "+";
            }
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, operador).ToString();

            lblResultado.Text = resultado;
            lstOperaciones.Items.Add($"{txtNumero1.Text} {operador} {txtNumero2.Text} = {resultado}");

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
            

        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(e);
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(e);
        }

        private void ValidarSoloNumeros(KeyPressEventArgs e) 
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
