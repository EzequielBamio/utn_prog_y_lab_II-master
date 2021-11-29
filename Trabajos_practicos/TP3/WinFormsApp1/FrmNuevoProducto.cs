using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace VistaForm
{
    public partial class FrmNuevoProducto : Form
    {
        private Fabrica fabrica;
        public FrmNuevoProducto(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
        }

        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {
            cmbTamanio.DataSource = Enum.GetValues(typeof(Entidades.ETamanioEnvase));
            cmbTipo.DataSource = Enum.GetValues(typeof(Entidades.ETipoEnvase));
            cmbProducto.DataSource = Enum.GetValues(typeof(Entidades.EProducto));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ETamanioEnvase tamanio;
            ETipoEnvase tipo;
            EProducto eProducto;
            Enum.TryParse(cmbTamanio.SelectedValue.ToString(), out tamanio);
            Enum.TryParse(cmbTipo.SelectedValue.ToString(), out tipo);
            Enum.TryParse(cmbProducto.SelectedValue.ToString(), out eProducto);

            if (txtNombre.Text != "" && txtPrecio.Text != "")
            {
                try
                {
                    Producto producto = new Producto(txtNombre.Text, int.Parse(txtPrecio.Text), tamanio, tipo, eProducto);
                    this.fabrica += producto;
                    this.Close();
                }
                catch (ProductoInvalidoException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Debe llenar todos los espacios para crear un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else 
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
    }
}
