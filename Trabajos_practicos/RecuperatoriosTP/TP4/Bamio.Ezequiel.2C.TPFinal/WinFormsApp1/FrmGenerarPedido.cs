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
            this.RefrescarLista(dgvListaProductos);
            foreach (Cliente cliente in this.fabrica.Clientes)
            {
                cmbListaClientes.Items.Add(cliente.Direccion);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int codigo;
            if (txtCodigoCargar.Text != "" && nudCantidadCargar.Value > 0)
            {
                if (int.TryParse(txtCodigoCargar.Text, out codigo))
                {
                    int cantidad = (int)nudCantidadCargar.Value;
                    this.MoverProducto(this.fabrica.Productos, this.productosPedidos, codigo, cantidad);
                }
                else 
                {
                    MessageBox.Show("No es un codigo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No puede dejar campos vacios & la cantidad no debe ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MoverProducto(List<Producto> listaPrincipal, List<Producto> listaAsignar, int codigo, int cantidad)
        {
            try
            {
                Producto producto = Producto.BuscarPorId(listaPrincipal, codigo);

                Producto productoNew = new Producto();
                if (producto.Stock > 0 && producto.Stock >= cantidad)
                {
                    producto.Stock -= cantidad;

                    try
                    {
                        productoNew = Producto.BuscarPorId(listaAsignar, producto.Codigo);

                    }
                    catch (ProductoInvalidoException)
                    {
                        productoNew = new Producto(producto.Codigo, producto.Nombre, producto.Precio, producto.TamanioEnvase, producto.TipoEnvase, producto.TipoProducto, 0);

                        listaAsignar.Add(productoNew);
                    }
                    productoNew.Stock += cantidad;

                }
                if (producto.Stock < 1)
                {
                    listaPrincipal.Remove(producto);
                }

                RefrescarLista(dgvListaProductos);
                RefrescarListaCargada(dgvProductosCargados);

            }
            catch (ProductoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo;
            if (txtCodigoEliminar.Text != "" && nudCantidadEliminar.Value > 0)
            {
                if (int.TryParse(txtCodigoEliminar.Text, out codigo))
                {
                    int cantidad = (int)nudCantidadEliminar.Value;
                    this.MoverProducto(this.productosPedidos, this.fabrica.Productos, codigo, cantidad);
                }
                else 
                {
                    MessageBox.Show("No es un codigo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No puede dejar campos vacios & la cantidad no debe ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            Factura factura = new Factura(cliente.Id);
                            foreach (Producto producto in this.productosPedidos) 
                            {
                                factura += producto; 
                            }

                            this.fabrica += factura;
                            cliente.Estado = EEstado.Deudor;
                            this.Reniciar();
                            MessageBox.Show("El pedido fue generador exitosamente! el cliente ya tiene los productos cargados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvProductosCargados.Rows.Count > 0)
            {
                if (MessageBox.Show("No se confirmo el pedido, seguro quieres salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvProductosCargados.Rows.Count; i++)
                    {
                        try
                        {
                            this.fabrica += this.BuscarProducto(dgvProductosCargados, this.productosPedidos, i);
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
        private void Reniciar() 
        {
            this.productosPedidos = new List<Producto>();
            RefrescarLista(dgvListaProductos);
            RefrescarListaCargada(dgvProductosCargados);
        }
        private void RefrescarLista(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            int i = dataGridView.Rows.Count;

            foreach (Producto p in fabrica.Productos)
            {
                dataGridView.Rows.Insert(i, p.Codigo, p.TipoProducto, p.Nombre, p.Precio, p.TamanioEnvase, p.TipoEnvase, p.Stock);
            }

        }
        private void RefrescarListaCargada(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            int i = dataGridView.Rows.Count;

            foreach (Producto p in this.productosPedidos)
            {
                dataGridView.Rows.Insert(i, p.Codigo, p.TipoProducto, p.Nombre, p.Precio, p.Stock, p.CalcularPrecioTotal());
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

        private void txtCodigoCargar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarSoloNumeros(e);
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

        private void txtCodigoEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarSoloNumeros(e);
        }
    }
}
