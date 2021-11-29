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
namespace VistaForm
{
    public partial class FrmEstadisticas : Form
    {
        private Fabrica fabrica;
        public FrmEstadisticas(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            if (fabrica.Productos.Count > 0)
            {
                lblTotalVentas.Text = fabrica.TotalVentas().ToString();
                lblTotalEnMercaderia.Text = fabrica.TotalEnMercaderia().ToString();
                lblGaseosas.Text = fabrica.TotalGaseosas().ToString();
                lblCervezas.Text = fabrica.TotalCervezas().ToString();
                lblCantidadGaseosas.Text = fabrica.CantidadGaseosas().ToString();
                lblCantidadCervezas.Text = fabrica.CantidadCervezas().ToString();
                lblCantidadLatas.Text = fabrica.CantidadLatas().ToString();
                lblCantidadBotellas.Text = fabrica.CantidadBotellas().ToString();
                try
                {
                    Cliente cliente = fabrica.MejorCliente();
                    lblTotalComprado.Text = cliente.CalcularGastosTotal().ToString();
                    lblTotalProductos.Text = cliente.Productos.Count.ToString();
                    lblID.Text = cliente.Id.ToString();
                    lblNombre.Text = cliente.Nombre;
                    lblApellido.Text = cliente.Apellido;
                }
                catch (ClienteInvalidoException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("No hay productos cargados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
