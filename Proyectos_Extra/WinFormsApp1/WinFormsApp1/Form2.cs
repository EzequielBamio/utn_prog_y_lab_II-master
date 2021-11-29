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
    public partial class Form2 : Form
    {
        Fabrica fabrica;
        public Form2()
        {
            InitializeComponent();
            this.fabrica = new Fabrica("Test");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.fabrica.Productos.Add(new Producto("CocaCola", 23, ETamanioEnvase.Grande, ETipoEnvase.Lata, EProducto.Gaseosa, 3));
            this.fabrica.Productos.Add(new Producto("Pepsi", 55, ETamanioEnvase.Grande, ETipoEnvase.Lata, EProducto.Gaseosa, 6));

            foreach (Producto p in this.fabrica.Productos) 
            {
                comboBox1.Items.Add(p.Datos());
                comboBox2.Items.Add(p.Datos());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto1 = (Producto)comboBox1.SelectedItem;
            Producto producto2 = (Producto)comboBox1.SelectedItem;

            richTextBox1.Text += $"Producto seleccionado: {producto1.Datos()}";
            richTextBox1.Text += $"Producto2 seleccionado: {producto2.Datos()}";

            //richTextBox1.Text += $"{producto1.Nombre} tiene ";


        }
    }
}
