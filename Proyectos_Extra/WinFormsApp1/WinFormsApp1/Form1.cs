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
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Fabrica fabrica;
        List<Producto> productosCargados;
        public Form1()
        {
            InitializeComponent();
            this.productosCargados = new List<Producto>();
            this.fabrica = new Fabrica("Test");
            this.fabrica.Productos.Add(new Producto("CocaCola", 23, ETamanioEnvase.Grande, ETipoEnvase.Lata, EProducto.Gaseosa, 3));
            this.fabrica.Productos.Add(new Producto("Pepsi", 55, ETamanioEnvase.Grande, ETipoEnvase.Lata, EProducto.Gaseosa, 6));
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
                    catch (ProductoInvalidoException ex)
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

                RefrescarLista(dgvProductos);
                RefrescarListaCargada(dgvProductosCargados);

            }
            catch (ProductoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCargar.Text != "" && nudCantidadCargar.Value > 0) 
            {
                int cantidad = (int)nudCantidadCargar.Value;
                int codigo = int.Parse(txtCodigoCargar.Text);
                this.MoverProducto(this.fabrica.Productos, this.productosCargados, codigo, cantidad);
            }
            else
            {
                MessageBox.Show("No puede dejar campos vacios & la cantidad no debe ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigoEliminar.Text != "" && nudCantidadEliminar.Value > 0)
            {
                int cantidad = (int)nudCantidadEliminar.Value;
                int codigo = int.Parse(txtCodigoEliminar.Text);
                this.MoverProducto(this.productosCargados, this.fabrica.Productos, codigo, cantidad);
            }
            else 
            {
                MessageBox.Show("No puede dejar campos vacios & la cantidad no debe ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            foreach (Producto p in this.productosCargados)
            {
                dataGridView.Rows.Insert(i, p.Codigo, p.TipoProducto, p.Nombre, p.Precio, p.Stock, p.CalcularPrecioTotal());
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarLista(dgvProductos);
        }

    }
}
