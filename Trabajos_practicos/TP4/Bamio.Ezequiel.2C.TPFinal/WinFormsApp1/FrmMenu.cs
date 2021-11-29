using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using IO;
namespace VistaForm
{
    public partial class FrmMenu : Form
    {
        private Fabrica fabrica;
        private Serializacion<Fabrica> serializacionFabrica;
        private Serializacion<List<Factura>> serializacionFacturas;
        private bool guardado;

        public FrmMenu()
        {
            InitializeComponent();
            this.serializacionFabrica = new Serializacion<Fabrica>();
            this.serializacionFacturas = new Serializacion<List<Factura>>();

            this.fabrica = new Fabrica("BAMIO COMPANY");
        }
        
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (!this.guardado)
            {
                if (MessageBox.Show("Seguro quiere salir? \n*Los datos no fueron guardados.", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else 
            {
                Application.Exit();
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblNombreCompania.Text = fabrica.Nombre;
            
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmListaProductos frmProductos = new FrmListaProductos(this.fabrica);
            AbrirFormEnPanel(frmProductos);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(this.fabrica);
            AbrirFormEnPanel(frmCliente);

        }
        private void btnPedido_Click(object sender, EventArgs e)
        {
            FrmGenerarPedido frmGenerarPedido = new FrmGenerarPedido(this.fabrica);
            AbrirFormEnPanel(frmGenerarPedido);
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas(fabrica);
            AbrirFormEnPanel(frmEstadisticas);
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            FrmEntregarPedidos frmEntregarPedidos = new FrmEntregarPedidos(this.fabrica);
            frmEntregarPedidos.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frmReportes = new FrmReportes();
            AbrirFormEnPanel(frmReportes);
        }
        private void lblTitulo_Click(object sender, EventArgs e)
        {
            try
            {
                this.fabrica = this.serializacionFabrica.Leer("Hardcodeo/Fabrica.xml");
                this.fabrica.HistorialFacturas = this.serializacionFacturas.LeerJson("Hardcodeo/historialFacturas.json");
                MessageBox.Show("Se cargaron los datos correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                serializacionFabrica.Escribir("Fabrica.xml", this.fabrica, false);
                serializacionFacturas.EscribirJson("historialFacturas.json", this.fabrica.HistorialFacturas, false);

                MessageBox.Show("Archivo guardado exitosamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.guardado = true;
            }
            catch (ArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO PARA ARRASTRAR EL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //METODO PARA ABRIR FORM DENTRO DE PANEL
        private void AbrirFormEnPanel(object formHijo)
        {
            try
            {
                if (this.pnlContenedorForm.Controls.Count > 0)
                    this.pnlContenedorForm.Controls.RemoveAt(0);
                Form fh = formHijo as Form;
                fh.TopLevel = false;
                fh.FormBorderStyle = FormBorderStyle.None;
                fh.Dock = DockStyle.Fill;
                this.pnlContenedorForm.Controls.Add(fh);
                this.pnlContenedorForm.Tag = fh;
                this.guardado = false;
                fh.Show();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Algo fallo.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
