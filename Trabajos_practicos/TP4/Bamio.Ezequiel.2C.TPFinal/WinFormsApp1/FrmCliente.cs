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
using Entidades;
using IO;
namespace VistaForm
{
    public partial class FrmCliente : Form
    {
        private Fabrica fabrica;

        public FrmCliente(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.RefrescarLista();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Al hacer doble click en el cliente se mostrara las facturas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListaClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StringBuilder recibo = new StringBuilder();
            int i = e.RowIndex;
            int id;

            if (i != -1)
            {
                try
                {
                    id = (int)dgvListaClientes.Rows[i].Cells[0].Value;
                    Cliente cliente1 = Cliente.BuscarPorId(this.fabrica.Clientes, id);
                    foreach(Factura factura in this.fabrica.Facturas)
                    {
                        if (cliente1 == factura) 
                        {
                            recibo.AppendLine(factura.Recibo()); 
                        }
                    }

                    MessageBox.Show(recibo.ToString(), "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (ClienteInvalidoException ex) 
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Crea un nuevo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "" && txtSexo.Text != "")
            {
                try
                {
                    Cliente cliente = new Cliente(int.Parse(txtId.Text), txtNombre.Text, txtApellido.Text, txtSexo.Text, txtDireccion.Text, int.Parse(txtTelefono.Text));
                    this.fabrica += cliente;
                    this.RefrescarLista();
                }
                catch (ClienteInvalidoException ex) 
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Debe completar todos los campos para crear un cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Elimina un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtClienteEliminar.Text != "")
            {
                try
                {

                    Cliente cliente = Cliente.BuscarPorId(fabrica.Clientes, int.Parse(txtClienteEliminar.Text));

                    this.fabrica.EliminarFacturasCliente(cliente);
                    this.fabrica -= cliente;
                    this.RefrescarLista();
                    
                }
                catch (ClienteInvalidoException ex) 
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Valida que en textbox solo se permitan numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarSoloNumeros(e);
        }

        private void txtClienteEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarSoloNumeros(e);
        }

        /// <summary>
        /// Actualiza el DataGridView
        /// </summary>
        private void RefrescarLista()
        {
            dgvListaClientes.Rows.Clear();
            fabrica.Clientes.Sort(fabrica.OrdenarPorId);
            txtId.Text = this.fabrica.GenerarId().ToString();
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtSexo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtClienteEliminar.Text = "";
            dgvListaClientes.InsertarCliente(this.fabrica);
        }
        private void ValidarSoloNumeros(KeyPressEventArgs e) 
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
    }
}
