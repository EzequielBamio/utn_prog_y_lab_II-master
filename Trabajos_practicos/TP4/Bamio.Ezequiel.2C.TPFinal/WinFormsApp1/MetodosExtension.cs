using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public static class MetodosExtension
    {

        public static void InsertarCliente(this DataGridView dataGridView, Fabrica fabrica)
        {
            int i = dataGridView.Rows.Count;

            foreach (Cliente cliente in fabrica.Clientes)
            {
                dataGridView.Rows.Insert(i, cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Sexo, cliente.Direccion, cliente.Telefono, cliente.Estado);
            }
        }
        public static void InsertarProducto(this DataGridView dataGridView, List<Producto> productos)
        {
            int i = dataGridView.Rows.Count;

            foreach (Producto p in productos)
            {
                dataGridView.Rows.Insert(i, p.Codigo, p.TipoProducto, p.Nombre, p.Precio, p.TamanioEnvase, p.TipoEnvase);
            }
        }
    }
}
