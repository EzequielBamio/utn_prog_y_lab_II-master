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

namespace Testing_Truck_Movement
{
    public partial class Form1 : Form
    {
        private Truck truck;
        private Point positionInitial;
        private CancellationTokenSource cancellationSource;
        private CancellationToken cancellationToken;
        private bool ejecutando;
        private int countDeudores = 0;
        private int countAlDia = 0;
        public Form1()
        {
            InitializeComponent();
            this.positionInitial = this.picTruck.Location;
            this.cancellationSource = new CancellationTokenSource();
        }
        private void InitializeTruck() 
        {
            this.truck = new Truck("SDA322", 5, this.Size.Width, this.picTruck.Location.X);
        }

        private void MoveTruck() 
        {
            

            if (this.truck.Ubicacion > this.truck.Recorrido)
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)(() => {

                        this.picTruck.Location = this.positionInitial;
                        this.truck.Ubicacion = this.picTruck.Location.X;
                    }));
                }
                else
                {
                    this.picTruck.Location = this.positionInitial;
                    this.truck.Ubicacion = this.picTruck.Location.X;
                }
            }
            else
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)(() => this.picTruck.Location = new Point(this.truck.Ubicacion, this.picTruck.Location.Y)));
                }
                else
                {
                    this.picTruck.Location = new Point(this.truck.Ubicacion, this.picTruck.Location.Y);
                }
                
            }
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)(() => this.progressBar1.Value = this.truck.PuntoPartida));
            }
            else
            {
                this.progressBar1.Value = this.truck.PuntoPartida;
            }
        }

        private void ShowMessage(string mensaje, int estadoEntrega) 
        {
            if (!this.ejecutando)
            {
                if (estadoEntrega == 1)
                {
                    this.countAlDia++;
                }
                else
                {
                    this.countDeudores++;
                }

                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)(() =>
                    {
                        btnEstado.Text = "Empezar";
                        btnLimpiar.Enabled = true;
                        this.lblPagos.Text = this.countAlDia.ToString();
                        this.lblNoPagos.Text = this.countDeudores.ToString();
                    }));
                }
                else
                {
                    btnEstado.Text = "Empezar";
                    btnLimpiar.Enabled = true;
                    this.lblPagos.Text = this.countAlDia.ToString();
                    this.lblNoPagos.Text = this.countDeudores.ToString();
                }
                MessageBox.Show($"Facturas pagas: {this.countAlDia} - Facturas no pagas {this.countDeudores}", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.FinalizarTask();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.InitializeTruck();
            lblCantidad.Text = this.truck.CantidadPedidos.ToString();
            this.truck.InformarAvance += this.MoveTruck;
            this.truck.InformarEntrega += this.ShowMessage;
            this.progressBar1.Maximum = 632;

        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            if (this.truck.CantidadPedidos > 0)
            {
                this.cancellationToken = cancellationSource.Token;
                if (!this.ejecutando)
                {
                    Task task = Task.Run(() =>
                    {
                        this.ejecutando = true;
                        this.truck.InitializeDeliveries(this.cancellationToken);
                    });
                    btnEstado.Text = "Entregando pedidos...";
                    btnEstado.Enabled = false;
                }
            }
            else 
            {
                MessageBox.Show("No hay pedidos para entregar.");
            }
        }

        public void FinalizarTask() 
        {
            if (this.ejecutando)
            { 
                this.cancellationSource.Cancel();
                this.cancellationSource = new CancellationTokenSource();
                this.ejecutando = false;
            }
        }

        private void Limpiar() 
        {
            btnEstado.Text = "Empezar";
            btnEstado.Enabled = true;
            this.progressBar1.Value = 0;
            this.lblCantidad.Text = "0";
            this.lblPagos.Text = "0";
            this.lblNoPagos.Text = "0";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
    }
}
