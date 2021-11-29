using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
namespace frmCentralTelefonica
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;

        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }
        private void CargarNumero(string numero) 
        {
            if (this.txtNroDestino.Text == "Nro Destino")
            {
                this.txtNroDestino.Text = string.Empty;
            }
            this.txtNroDestino.Text += numero;
        }
        #region Panel Numeros
        private void btnNumUno_Click(object sender, EventArgs e)
        {
            this.CargarNumero("1");
        }

        private void btnNumDos_Click(object sender, EventArgs e)
        {
            this.CargarNumero("2");
        }

        private void btnNumTres_Click(object sender, EventArgs e)
        {
            this.CargarNumero("3");
        }

        private void btnNumCuatro_Click(object sender, EventArgs e)
        {
            this.CargarNumero("4");
        }

        private void btnNumCinco_Click(object sender, EventArgs e)
        {
            this.CargarNumero("5");
        }

        private void btnNumSeis_Click(object sender, EventArgs e)
        {
            this.CargarNumero("6");
        }

        private void btnNumSiete_Click(object sender, EventArgs e)
        {
            this.CargarNumero("7");
        }

        private void btnNumOcho_Click(object sender, EventArgs e)
        {
            this.CargarNumero("8");
        }

        private void btnNumNueve_Click(object sender, EventArgs e)
        {
            this.CargarNumero("9");
        }
        private void btnNumCero_Click(object sender, EventArgs e)
        {
            this.CargarNumero("0");
        }
        private void btnAsterico_Click(object sender, EventArgs e)
        {
            this.CargarNumero("*");
        }
        private void btnNumeral_Click(object sender, EventArgs e)
        {
            this.CargarNumero("#");
        }
        #endregion

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.cmbFranja.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroOrigen.Text = "Nro Origen";
        }

        private void FrmLlamador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro desea salir?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            this.cmbFranja.Enabled = false;

            if (this.txtNroDestino.Text.StartsWith("#"))
            {
                this.cmbFranja.Enabled = true;
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Llamada llamada;
            float duracion = random.Next(1,51);

            if (this.cmbFranja.Enabled == true)
            {
                llamada = new Provincial(this.txtNroOrigen.Text, (Provincial.Franja)this.cmbFranja.SelectedItem, duracion, this.txtNroDestino.Text);
            }
            else 
            {
                float costo = random.Next(0, 56) / 10;
                llamada = new Local(this.txtNroOrigen.Text, duracion, this.txtNroDestino.Text, costo);
            }

            this.centralita += llamada;

            MessageBox.Show("La llamada fue registrada con exito!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
