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
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private Llamada.TipoLlamada tipoLlamada;

        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        public Llamada.TipoLlamada TipoLlamada 
        {
            set 
            {
                this.tipoLlamada = value;
            }
        }

        private void FrmMostrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro desea salir?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Dispose();
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            foreach (Llamada item in this.centralita.Llamadas)
            {
                if (item is Local && this.tipoLlamada == Llamada.TipoLlamada.Local)
                {
                    rtbDatosCentralita.Text += item.ToString();
                }
                else
                {
                    if (item is Provincial && this.tipoLlamada == Llamada.TipoLlamada.Provincial)
                    {
                        rtbDatosCentralita.Text += item.ToString();
                    }
                    else
                    {
                        if (this.tipoLlamada == Llamada.TipoLlamada.Todas)
                        {
                            rtbDatosCentralita.Text += item.ToString();
                        }
                    }
                }

            }

            if (this.tipoLlamada == Llamada.TipoLlamada.Todas)
            {
                rtbDatosCentralita.Text += $"Ganancia por todas las llamadas {this.centralita.GananciasPorTotal}";
            }
            else
            {
                if (this.tipoLlamada == Llamada.TipoLlamada.Local)
                {
                    rtbDatosCentralita.Text += $"Ganancia por llamadas Locales {this.centralita.GananciasPorLocal}";
                }
                else
                {
                    if (this.tipoLlamada == Llamada.TipoLlamada.Provincial)
                    {
                        rtbDatosCentralita.Text += $"Ganancia por llamadas Provinciales {this.centralita.GananciasPorProvincial}";
                    }
                }
            }
        }
    }
}
