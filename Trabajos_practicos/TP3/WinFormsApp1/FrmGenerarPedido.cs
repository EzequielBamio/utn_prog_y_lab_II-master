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
    public partial class FrmGenerarPedido : Form
    {
        private List<Producto> productosPedidos;
        private Fabrica fabrica;
        public FrmGenerarPedido(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            this.productosPedidos = new List<Producto>();
        }

        private void FrmGenerarPedido_Load(object sender, EventArgs e)
        {
            this.RefrescarLista(dgvListaProductos, this.fabrica.Productos);
            foreach (Cliente cliente in this.fabrica.Clientes)
            {
                cmbListaClientes.Items.Add(cliente.Direccion);
            }

        }

        private void RefrescarLista(DataGridView dataGridView, List<Producto> productos)
        {
            dataGridView.Rows.Clear();
            int i = dataGridView.Rows.Count;
            foreach (Producto producto in productos)
            {
                dataGridView.Rows.Insert(i, producto.Codigo, producto.TipoProducto, producto.Nombre, producto.Precio, producto.TamanioEnvase, producto.TipoEnvase);
            }
        }

        private void dgvListaProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i != -1)
            {
                try
                {
                    Producto producto = this.BuscarProducto(dgvListaProductos, this.fabrica.Productos, i);

                    this.fabrica -= producto;
                    this.productosPedidos.Add(producto);
                    this.RefrescarLista(dgvListaProductos, this.fabrica.Productos);
                    this.RefrescarLista(dgvVentasProductos, this.productosPedidos);
                }
                catch (ProductoInvalidoException ex) 
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvVentasProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i != -1)
            {
                try
                {
                    Producto producto = this.BuscarProducto(dgvVentasProductos, this.productosPedidos, i);

                    this.fabrica += producto;
                    this.productosPedidos.Remove(producto);
                    this.RefrescarLista(dgvListaProductos, this.fabrica.Productos);
                    this.RefrescarLista(dgvVentasProductos, this.productosPedidos);
                }
                catch (ProductoInvalidoException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbListaClientes.SelectedItem != null) 
            {
                if (this.productosPedidos.Count > 0)
                {
                    foreach (Cliente cliente in this.fabrica.Clientes) 
                    {
                        if ((string)cmbListaClientes.SelectedItem == cliente.Direccion) 
                        {
                            foreach (Producto producto in this.productosPedidos) 
                            {
                                cliente.Productos.Add(producto);
                                fabrica.ProductosVendidos.Add(producto);
                            }

                            MessageBox.Show("El pedido fue generador exitosamente! el cliente ya tiene los productos cargados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            break;
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Debe cargar productos para realizar el pedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }else
            {
                MessageBox.Show("Debe selecciona un cliente para realizar el pedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (dgvVentasProductos.Rows.Count > 0)
            {
                if (MessageBox.Show("No se confirmo el pedido, seguro quieres salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvVentasProductos.Rows.Count; i++)
                    {
                        try
                        {
                            this.fabrica += this.BuscarProducto(dgvVentasProductos, this.productosPedidos, i);
                        }
                        catch (ProductoInvalidoException ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    this.Close();
                }
            }
            else 
            {
                this.Close();
            }
        }

        private Producto BuscarProducto(DataGridView dataGridView, List<Producto> productos, int index)
        {
            try
            {
                int codigo = (int)dataGridView.Rows[index].Cells[0].Value;
                return Producto.BuscarPorId(productos, codigo);
            }
            catch (ProductoInvalidoException)
            {
                throw;
            }

        }
    }
}
