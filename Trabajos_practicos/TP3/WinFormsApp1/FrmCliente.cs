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
        private Serializacion<List<Cliente>> serializacionCliente;
        private string nombreArchivo;

        public FrmCliente(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            this.nombreArchivo = string.Empty;
            this.serializacionCliente = new Serializacion<List<Cliente>>();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.RefrescarLista();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.nombreArchivo))
            {
                this.serializacionCliente.Escribir(this.nombreArchivo, this.fabrica.Clientes, false);
                MessageBox.Show("Archivo guardado exitosamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                saveFileDialog = new SaveFileDialog();

                saveFileDialog.Title = "Clientes";
                saveFileDialog.Filter = "json files (*.json)|*.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = $"{saveFileDialog.FileName}";
                    if (Path.GetExtension(path) == ".json")
                    {
                        this.serializacionCliente.Escribir(path, this.fabrica.Clientes, false);
                        MessageBox.Show("Archivo guardado exitosamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

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
                        this.fabrica.Clientes = this.serializacionCliente.Leer(archivoNombre);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListaClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StringBuilder facturas = new StringBuilder();
            int i = e.RowIndex;
            int id;

            if (i != -1)
            {
                try
                {
                    id = (int)dgvListaClientes.Rows[i].Cells[0].Value;
                    Cliente cliente1 = Cliente.BuscarPorId(this.fabrica.Clientes, id);

                    MessageBox.Show(cliente1.Recibo(), "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(ClienteInvalidoException ex) 
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "")
            {
                try
                {
                    Cliente cliente = new Cliente(int.Parse(txtId.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, int.Parse(txtTelefono.Text));
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            if (txtClienteEliminar.Text != "")
            {
                try
                {

                    Cliente cliente = Cliente.BuscarPorId(fabrica.Clientes, int.Parse(txtClienteEliminar.Text));
                    archivo.Escribir("DatosFabrica/ClientesBaja.txt", cliente.Datos(), true);
                    fabrica -= cliente;
                    this.RefrescarLista();
                    
                }
                catch (ClienteInvalidoException ex) 
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarSoloNumeros(e);
        }

        private void txtClienteEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarSoloNumeros(e);
        }

        private void RefrescarLista()
        {
            dgvListaClientes.Rows.Clear();
            fabrica.Clientes.Sort(fabrica.OrdenarPorId);
            txtId.Text = this.fabrica.GenerarId().ToString();
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtClienteEliminar.Text = "";
            this.InsertarClientes();
        }

        private void InsertarClientes()
        {
            int i = dgvListaClientes.Rows.Count;

            foreach (Cliente cliente in this.fabrica.Clientes)
            {

                dgvListaClientes.Rows.Insert(i, cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Direccion, cliente.Telefono);
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
    }
}
