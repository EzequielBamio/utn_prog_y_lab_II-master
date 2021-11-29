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
using Entidades;
using BD;
namespace VistaForm
{
    public partial class FrmEntregarPedidos : Form
    {
        private Fabrica fabrica;
        private Camion camion;
        private Point positionInitial;
        private CancellationTokenSource cancellationSource;
        private CancellationToken cancellationToken;
        private GestorBaseDeDatos gestorBD;
        private bool ejecutando;
        private int cantidadPedidos;
        private int totalNoPagos;
        private int totalPagos;
        private int recaudado;

        public FrmEntregarPedidos(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            this.positionInitial = this.picCamion.Location;
            this.cancellationSource = new CancellationTokenSource();
            this.gestorBD = new GestorBaseDeDatos();
            this.cantidadPedidos = this.fabrica.Facturas.Count;
        }
        /// <summary>
        /// Estancia un nuevo camion
        /// </summary>
        private void InitializeCamion()
        {
            this.camion = new Camion("SDA322", this.fabrica.Facturas, this.Size.Width, this.picCamion.Location.X);
        }

        /// <summary>
        /// Simula el movimiento del camion, cuando pasa el tamaño del formulario vuelve a la posicion inicial
        /// El progressBar simula el tiempo que tarda en entregar los pedidos
        /// </summary>
        private void MoveCamion()
        {
            if (this.camion.Ubicacion > this.camion.Kms)
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)(() =>
                    {
                        this.picCamion.Location = this.positionInitial;
                        this.camion.Ubicacion = this.picCamion.Location.X;
                    }));
                }
                else
                {
                    this.picCamion.Location = this.positionInitial;
                    this.camion.Ubicacion = this.picCamion.Location.X;
                }
            }
            else
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)(() => this.picCamion.Location = new Point(this.camion.Ubicacion, this.picCamion.Location.Y)));
                }
                else
                {
                    this.picCamion.Location = new Point(this.camion.Ubicacion, this.picCamion.Location.Y);
                }

            }
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)(() => 
                {
                    if (this.camion.Recorrido < 400) 
                    {
                        this.pgbEntregas.Value = this.camion.Recorrido;
                    }
                }));
            }
            else
            {
                if (this.camion.Recorrido < 400)
                {
                    this.pgbEntregas.Value = this.camion.Recorrido;
                }
            }
        }
        /// <summary>
        /// Metodo que se va a llamar cuando se invoque el evento CobrarPedido. Si el cliente pago la factura se elimina de la lista -Facturas-
        /// </summary>
        /// <param name="factura"></param>
        public void Cobrar(Factura factura)
        {
            foreach (Cliente cliente in this.fabrica.Clientes)
            {
                if (factura.IdCliente == cliente.Id)
                {
                    if (cliente.Pagar())
                    {
                        this.recaudado += factura.CalcularGastosTotal();
                        this.fabrica -= factura;
                        this.totalPagos++;
                        if(!Factura.ValidarClienteFactura(this.fabrica.Facturas, cliente.Id))
                        {
                            cliente.Estado = EEstado.AlDia;
                        }
                        break;
                    }
                    else 
                    {
                        this.totalNoPagos++;
                        break;
                    }
                }
            } 
        }
        /// <summary>
        /// Metodo que se va a llamar cuando se invoque el evento InformarEntrega. Se crea el nuevo reporte y lo guarda en la base de datos.
        /// </summary>
        /// <param name="mensaje"></param>
        private void ShowMessage(string mensaje)
        {
            Reporte reporte = new Reporte(this.cantidadPedidos, this.totalPagos, this.totalNoPagos, this.recaudado);
            this.fabrica.DineroCaja = this.recaudado;
            try
            {
                this.gestorBD.Guardar(reporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)(() =>
                {
                    MessageBox.Show(reporte.ToString(), mensaje);
                    this.MostrarFacturas();
                    btnReniciar.Enabled = true;
                }));
            }
            else
            {
                MessageBox.Show(reporte.ToString(), mensaje); this.MostrarFacturas();
                btnReniciar.Enabled = true;
            }

            this.FinalizarTask();
        }

        /// <summary>
        /// Cancela todas las tareas
        /// </summary>
        public void FinalizarTask()
        {
            if (this.ejecutando)
            {
                this.cancellationSource.Cancel();
                this.cancellationSource = new CancellationTokenSource();
                this.ejecutando = false;
            }
        }
        /// <summary>
        /// Estancia un nuevo formulario de Entregar Pedidos y cierra el actual.
        /// </summary>
        private void Reniciar()
        {
            if (this.fabrica.Facturas.Count > 0)
            {
                FrmEntregarPedidos frmEntregar = new FrmEntregarPedidos(this.fabrica);
                frmEntregar.Show();
            }
            else 
            {
                MessageBox.Show("No hay pedidos para entregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        /// <summary>
        /// Boton que va iniciar el hilo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (this.fabrica.Facturas.Count > 0)
            {
                this.cancellationToken = cancellationSource.Token;
                if (!this.ejecutando)
                {
                    Task task = Task.Run(() =>
                    {
                        this.ejecutando = true;
                        this.camion.InitializeDeliveries(this.cancellationToken);
                    });
                    btnEstado.Text = "Entregando pedidos...";
                    btnEstado.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("No hay pedidos para entregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReniciar_Click(object sender, EventArgs e)
        {
            this.Reniciar();
        }

        private void FrmEntregarPedidos_Load(object sender, EventArgs e)
        {
            this.InitializeCamion();
            this.MostrarFacturas();
            this.camion.InformarAvance += this.MoveCamion;
            this.camion.InformarEntrega += this.ShowMessage;
            this.camion.CobraPedido += this.Cobrar; 
        }

        private void MostrarFacturas() 
        {
            lstFacturas.Items.Clear();
            foreach (Factura f in this.fabrica.Facturas) 
            {
                lstFacturas.Items.Add(f.ToString());
            }
        }
    }
}
