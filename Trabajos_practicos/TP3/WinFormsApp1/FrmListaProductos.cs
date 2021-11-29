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
        private string nombreArchivo;
        private Serializacion<List<Producto>> serializacionProducto;

        public FrmListaProductos(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            this.nombreArchivo = string.Empty;
            this.serializacionProducto = new Serializacion<List<Producto>>();
        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {
            this.RefrescarLista();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string archivoNombre = string.Empty;

            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "json files (*.json)|*.json";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivoNombre = openFileDialog.FileName;
                try
                {
                    if (Path.GetExtension(archivoNombre) == ".json")
                    {
                        this.fabrica.Productos = this.serializacionProducto.Leer(archivoNombre);
                        this.RefrescarLista();
                        MessageBox.Show($"Se cargo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    this.nombreArchivo = archivoNombre;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Excepcion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.nombreArchivo))
            {
                this.serializacionProducto.Escribir(this.nombreArchivo, this.fabrica.Productos, false);
                MessageBox.Show("Archivo guardado exitosamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                saveFileDialog = new SaveFileDialog();

                saveFileDialog.Title = "Productos";
                saveFileDialog.Filter = "json files (*.json)|*.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = $"{saveFileDialog.FileName}";
                    if (Path.GetExtension(path) == ".json")
                    {
                        this.serializacionProducto.Escribir(path, this.fabrica.Productos, false);
                        MessageBox.Show("Archivo guardado exitosamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
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
            int i = dgvListaProductos.Rows.Count;
            foreach (Producto producto in this.fabrica.Productos)
            {
                this.Insertar(dgvListaProductos, producto, i);
            }
        }

        private void Insertar(DataGridView dataGridView, Producto producto, int index)
        {
            dataGridView.Rows.Insert(index, producto.Codigo, producto.TipoProducto, producto.Nombre, producto.Precio, producto.TamanioEnvase, producto.TipoEnvase);
        }

    }
}
