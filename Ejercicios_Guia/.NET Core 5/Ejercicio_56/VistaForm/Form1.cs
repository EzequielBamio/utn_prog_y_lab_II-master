using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO;
namespace VistaForm
{
    public partial class frmBlocNotas : Form
    {
        private string nombreFile;
        private PuntoDat puntoDat;
        private PuntoTxt puntoTxt;
        public frmBlocNotas()
        {
            InitializeComponent();

            this.puntoTxt = new PuntoTxt();
            this.puntoDat = new PuntoDat();

        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = rtbText.TextLength.ToString();

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileNombre = string.Empty;

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat|All files (*.*)|*.*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                fileNombre = openFileDialog1.FileName;
                try
                {
                    if (Path.GetExtension(fileNombre) == ".txt")
                    {
                        rtbText.Text = this.puntoTxt.Leer(fileNombre);
                    }
                    else 
                    {
                        if (Path.GetExtension(fileNombre) == ".dat")
                        {
                            this.puntoDat = this.puntoDat.Leer(fileNombre);
                            rtbText.Text = this.puntoDat.Contenido;
                        }
                    }
                    this.nombreFile = fileNombre;

                }
                catch (ArchivoIncorrectoException ex)
                {
                    MessageBox.Show($"Excepcion: {ex.Message}");
                }

            }
            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.nombreFile))
            {
                if (this.GuardarArchivo(this.nombreFile))
                {
                    MessageBox.Show("Archivo guardado exitosamente!");
                }
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
            
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Title = "Documento";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = $"{saveFileDialog1.FileName}";
                if (GuardarArchivo(path))
                {
                    MessageBox.Show("Archivo guardado exitosamente!");
                }
            }
            
        }

        private bool GuardarArchivo(string ruta)
        {
            try
            {
                if (Path.GetExtension(ruta) == ".txt")
                {
                    return this.puntoTxt.GuardarComo(ruta, rtbText.Text);
                }
                else
                {
                    if (Path.GetExtension(ruta) == ".dat")
                    {
                        puntoDat.Contenido = rtbText.Text;
                        return this.puntoDat.GuardarComo(ruta, this.puntoDat);
                    }
                }
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
    }
}
