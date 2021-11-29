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
    public partial class FrmListaProductos : Form
    {
        private Fabrica fabrica;
        public FrmListaProductos(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {
            this.RefrescarLista();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto(this.fabrica);
            frmNuevoProducto.ShowDialog();
            this.RefrescarLista();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoEliminar.Text != "")
            {
                try
                {
                    Producto producto = Producto.BuscarPorId(this.fabrica.Productos, int.Parse(txtCodigoEliminar.Text));

                    this.fabrica -= producto;
                    this.RefrescarLista();
                }
                catch (ProductoInvalidoException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error, vuelta a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCodigoEliminar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void RefrescarLista()
        {
            dgvListaProductos.Rows.Clear();
            dgvListaProductos.InsertarProducto(this.fabrica.Productos);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            int codigo;
            if (txtCodigoStock.Text != "" && int.TryParse(txtCodigoStock.Text, out codigo))
            {
                if (nudStock.Value > 0)
                {
                    try 
                    { 
                        Producto producto = Producto.BuscarPorId(this.fabrica.Productos, codigo);
                        producto.Stock += (int)nudStock.Value;
                        this.RefrescarLista();
                    }
                    catch (ProductoInvalidoException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrio un error, vuelta a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El stock no puede ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Lo ingresado no es un codigo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtCodigoStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(e);
        }
    }
}
