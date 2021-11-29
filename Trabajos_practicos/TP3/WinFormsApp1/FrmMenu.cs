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
        private Serializacion<List<Producto>> serializacionProducto;
        private Serializacion<List<Cliente>> serializacionCliente;

        public FrmMenu()
        {
            InitializeComponent();
            this.serializacionProducto = new Serializacion<List<Producto>>();
            this.serializacionCliente = new Serializacion<List<Cliente>>();

            this.fabrica = new Fabrica("BAMIO COMPANY");
        }
        
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro quiere salir? \n*Consejo: No se olvide de guardar los datos", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    //backup
                    this.serializacionProducto.Escribir("DatosFabrica/ProductosVendidos.json", this.fabrica.ProductosVendidos, false);
                    this.serializacionProducto.Escribir($"DatosFabrica/Productos-{DateTime.Now.ToString("yyyy-MM-dd--HH-mm")}.json", this.fabrica.Productos, false);
                    this.serializacionCliente.Escribir($"DatosFabrica/Clientes-{DateTime.Now.ToString("yyyy-MM-dd--HH-m")}.json", this.fabrica.Clientes, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Application.Exit();
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblNombreCompania.Text = fabrica.Nombre;
            try
            {
                this.fabrica.ProductosVendidos = this.serializacionProducto.Leer("DatosFabrica/ProductosVendidos.json");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                fh.Show();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Algo fallo.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
