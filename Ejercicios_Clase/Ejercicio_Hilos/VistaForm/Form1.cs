using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Mozo mozo = new Mozo();
            lblInicioPedido.Text = DateTime.Now.ToString();
            Task<Cerveza> tarea = ServirCerveza("Corona");
            //Cerveza cerveza2 = await mozo.ServirCerveza("Corona");

            tarea.Start();

            //esperando la cerveza

            Cerveza cerveza = await tarea;
            lblEstado.Text = "Entregado.";
            lblPedidoEntregado.Text = DateTime.Now.ToString();
            MessageBox.Show($"*Le entrega la cerveza de la marca {cerveza.ToString()}.*");

        }
        public Task<Cerveza> ServirCerveza(string nombre)
        {
            return new Task<Cerveza>(() =>
            {
                Thread.Sleep(7000);
                if (lblEstado.InvokeRequired)
                {
                    lblEstado.BeginInvoke((MethodInvoker)( () => lblEstado.Text = "En marcha..."));
                }
                else 
                { 
                    lblEstado.Text = "En marcha...";
                }
                return new Cerveza(nombre);
            });
        }
    }
}
