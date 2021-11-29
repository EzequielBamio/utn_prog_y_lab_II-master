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
    public partial class FrmEstadisticas : Form
    {
        private Fabrica fabrica;
        private Estadisticas estadisticas;
        public FrmEstadisticas(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            this.estadisticas = new Estadisticas(this.fabrica);
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            this.CargarEstadisticas();
        }
        private void CargarEstadisticas() 
        {

            this.CalcularDias();
            this.CalcularEnvases();
            this.CalcularProductos();
            this.CalcularEstados();
            this.CalcularStock();
            this.CalcularGeneros();
            this.lblDineroRecaudado.Text = $"${estadisticas.DineroRecaudado()}";
            this.lblDineroCaja.Text = $"${this.fabrica.DineroCaja}";
            dgvClientes.Rows.Clear();
            foreach (Cliente cliente in this.fabrica.Clientes)
            {
                dgvClientes.Rows.Insert(dgvClientes.Rows.Count, cliente.Apellido + " " + cliente.Nombre, this.estadisticas.CalcularProductoCliente(cliente), this.estadisticas.CalcularDineroCliente(cliente));
            }
        }
        
        private void CalcularProductos() 
        {
            int cerveza = estadisticas.CantidadProducto(EProducto.Cerveza) ;
            int gaseosa = estadisticas.CantidadProducto(EProducto.Gaseosa);
            int total = gaseosa + cerveza;
            if (total > 0)
            {
                this.lblProductoGaseosa.Text = $"{((gaseosa * 100) / total)}%";
                this.lblProductoCervezas.Text = $"{((cerveza * 100) / total)}%";
            }
        }
        private void CalcularStock()
        {
            this.lblStockGaseosa.Text = estadisticas.CantidadStock(EProducto.Gaseosa).ToString();
            this.lblStockCervezas.Text = estadisticas.CantidadStock(EProducto.Cerveza).ToString();
        }
        private void CalcularEstados()
        {
            int deudor = estadisticas.CantidadEstados(EEstado.Deudor);
            int alDia = estadisticas.CantidadEstados(EEstado.AlDia);
            int total = alDia + deudor;
            if (total > 0)
            {
                this.lblEstadoAldia.Text = $"{((alDia * 100) / total)}%";
                this.lblEstadoDeudores.Text = $"{((deudor * 100) / total)}%";
            }
        }
        private void CalcularEnvases()
        {
            int lata = estadisticas.CantidadEnvase(ETipoEnvase.Lata);
            int botella = estadisticas.CantidadEnvase(ETipoEnvase.Botella);
            int total = lata + botella;
            if (total > 0)
            {
                this.lblEnvaseBotella.Text = $"{((botella * 100) / total)}%";
                this.lblEnvaseLata.Text = $"{((lata * 100) / total)}%";
            }
        }
        private void CalcularDias() 
        {
            int lunes = this.estadisticas.DiaConMayorVentas(DayOfWeek.Monday);
            int martes = this.estadisticas.DiaConMayorVentas(DayOfWeek.Tuesday);
            int miercoles = this.estadisticas.DiaConMayorVentas(DayOfWeek.Wednesday); 
            int jueves = this.estadisticas.DiaConMayorVentas(DayOfWeek.Thursday); 
            int viernes = this.estadisticas.DiaConMayorVentas(DayOfWeek.Friday); 
            int sabado = this.estadisticas.DiaConMayorVentas(DayOfWeek.Saturday);
            int total = lunes + martes + miercoles + jueves + viernes + sabado;

            if (total > 0)
            {
                AdaptarProgressBar(total);
                pgbLunes.Value = lunes;
                pgbMartes.Value = martes;
                pgbMiercoles.Value = miercoles;
                pgbJueves.Value = jueves;
                pgbViernes.Value = viernes;
                pgbSabado.Value = sabado;

                lblLunes.Text = $"{((lunes * 100) / total)}%";
                lblMartes.Text = $"{((martes * 100) / total)}%";
                lblMiercoles.Text = $"{((miercoles * 100) / total)}%";
                lblJueves.Text = $"{((jueves * 100) / total)}%";
                lblViernes.Text = $"{((viernes * 100) / total)}%";
                lblSabado.Text = $"{((sabado * 100) / total)}%";
            }
        }

        private void CalcularGeneros() 
        {
            int masculino = estadisticas.CantidadClientesPorGenero("Masculino");
            int femenino = estadisticas.CantidadClientesPorGenero("Femenino");
            int total = masculino + femenino;
            if (total > 0)
            {
                this.lblMasculino.Text = $"{((masculino * 100) / total)}%";
                this.lblFemenino.Text = $"{((femenino * 100) / total)}%";
            }
        }
        private void AdaptarProgressBar(int max) 
        {
            pgbLunes.Maximum = max ;
            pgbMartes.Maximum = max ;
            pgbMiercoles.Maximum = max ;
            pgbJueves.Maximum = max ;
            pgbViernes.Maximum = max;
            pgbSabado.Maximum = max;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cdoFiltrar_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.estadisticas.FechaInicio = cdoFiltrar.SelectionStart;
            this.estadisticas.FechaFinal = cdoFiltrar.SelectionEnd;
            this.Limpiar();
            this.CargarEstadisticas();
        }
        private void Limpiar() 
        {
            lblLunes.Text = "0%";
            lblMartes.Text = "0%";
            lblMiercoles.Text = "0%";
            lblJueves.Text = "0%";
            lblViernes.Text = "0%";
            lblSabado.Text = "0%";
            lblDineroRecaudado.Text = "$0";
            lblEnvaseBotella.Text = "0%";
            lblEnvaseLata.Text = "0%";
            lblEstadoAldia.Text = "0%";
            lblEstadoDeudores.Text = "0%";
            lblFemenino.Text = "0%";
            lblMasculino.Text = "0%";
            lblProductoCervezas.Text = "0%";
            lblProductoGaseosa.Text = "0%";
            lblStockCervezas.Text = "0";
            lblStockGaseosa.Text = "0";
            lblDineroCaja.Text = "$0";
            pgbLunes.Value = 0;
            pgbMartes.Value = 0;
            pgbMiercoles.Value = 0;
            pgbJueves.Value = 0;
            pgbViernes.Value = 0;
            pgbSabado.Value = 0;
        }
    }
}
