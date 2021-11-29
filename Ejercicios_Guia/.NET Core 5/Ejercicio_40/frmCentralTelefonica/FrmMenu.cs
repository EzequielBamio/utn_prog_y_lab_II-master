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
    public partial class FrmMenu : Form
    {
        private FrmMostrar frmMostrar;
        private FrmLlamador frmLlamador;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            frmLlamador = new FrmLlamador(new Centralita("CentralitaCenter"));
            frmLlamador.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar(this.frmLlamador.Centralita);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar(this.frmLlamador.Centralita);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Local;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar(this.frmLlamador.Centralita);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Provincial;
            frmMostrar.ShowDialog();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
