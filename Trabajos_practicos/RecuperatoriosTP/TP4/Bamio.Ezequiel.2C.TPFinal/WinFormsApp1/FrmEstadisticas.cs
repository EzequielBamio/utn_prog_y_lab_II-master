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
using BD;
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
            cmbFiltrarMes.DataSource = Enum.GetValues(typeof(EMes));
            EMes mesFiltrar;
            Enum.TryParse(cmbFiltrarMes.SelectedValue.ToString(), out mesFiltrar);
            this.estadisticas.Mes = mesFiltrar;
            DatosDias();
        }

        private int CalcularPorcentaje(int dato1, int dato2) 
        {
            int rtn = 0;
            try
            {
                rtn = (dato1 * 100) / (dato1 + dato2);
            }
            catch (DivideByZeroException)
            {

            }
            catch (Exception) 
            {
                MessageBox.Show("Algo salio mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return rtn;

        }

        private void DatosDias() 
        {
            dgvMeses.Rows.Clear();
            int i = dgvMeses.Rows.Count;
            int dia = 1;
            int crecimiento = 0;
            do
            {
                int diaMayorVentas = this.estadisticas.DiaConMayorVentas((EDias)dia);
                if (dia != 1)
                {
                    crecimiento = this.estadisticas.CalcularCrecimiento(this.estadisticas.DiaConMayorVentas((EDias)dia - 1), diaMayorVentas);
                }
                else
                {
                    crecimiento = diaMayorVentas;
                }
                
                try
                {
                    dgvMeses.Rows.Insert(i, (EDias)dia, diaMayorVentas, crecimiento, (crecimiento * 100 / diaMayorVentas));
                }
                catch (DivideByZeroException)
                {
                    dgvMeses.Rows.Insert(i, (EDias)dia, diaMayorVentas, 0, 0);
                }
                dia++;
            } while (dia < 6);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEnvases_Click(object sender, EventArgs e)
        {
            int botellasVendidas = this.estadisticas.CantidadEnvase(ETipoEnvase.Botella);
            int latasVendidas = this.estadisticas.CantidadEnvase(ETipoEnvase.Lata);
            int cantidadEnvasesVendidos = botellasVendidas + latasVendidas;
            int botellasGaseosa = this.estadisticas.CantidadEnvase(ETipoEnvase.Botella, EProducto.Gaseosa);
            int latasGaseosa = this.estadisticas.CantidadEnvase(ETipoEnvase.Lata, EProducto.Gaseosa);
            int cantidadEnvasesGaseosas = botellasGaseosa + latasGaseosa;
            int botellasCerveza = this.estadisticas.CantidadEnvase(ETipoEnvase.Botella, EProducto.Cerveza);
            int latasCerveza = this.estadisticas.CantidadEnvase(ETipoEnvase.Lata, EProducto.Cerveza);
            int cantidadEnvasesCervezas = botellasCerveza + latasCerveza;

            int masculinoBotella = this.estadisticas.CantidadEnvase(ETipoEnvase.Botella, ESexo.Masculino);
            int masculinoLata = this.estadisticas.CantidadEnvase(ETipoEnvase.Lata, ESexo.Masculino);
            int masculino = masculinoBotella + masculinoLata;

            int femeninoBotella = this.estadisticas.CantidadEnvase(ETipoEnvase.Botella, ESexo.Femenino);
            int femeninoLata = this.estadisticas.CantidadEnvase(ETipoEnvase.Lata, ESexo.Femenino);
            int femenino = femeninoBotella + femeninoLata;

            int cantidadEnvasesGeneros = masculino + femenino;
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"La cantidad de envases vendidos es de {cantidadEnvasesVendidos}, Botellas {this.CalcularPorcentaje(botellasVendidas, latasVendidas)}%  & Latas {this.CalcularPorcentaje(latasVendidas, botellasVendidas)}%");
            datos.AppendLine($"----------------------------------------");
            datos.AppendLine($"La cantidad de envases por Gaseosas es de {cantidadEnvasesGaseosas}, Botellas {this.CalcularPorcentaje(botellasGaseosa, latasCerveza)}% & Latas {this.CalcularPorcentaje(latasGaseosa, botellasGaseosa)}%");

            datos.AppendLine($"La cantidad de envases por Cervezas es de {cantidadEnvasesCervezas}, Botellas {this.CalcularPorcentaje(botellasCerveza, latasCerveza)}% & Latas {this.CalcularPorcentaje(latasCerveza, botellasCerveza)}%");

            datos.AppendLine($"----------------------------------------");
            datos.AppendLine($"La cantidad de envases vendidos por genero es de {cantidadEnvasesGeneros}, Masculino {this.CalcularPorcentaje(masculino, femenino)}% & Femenino {this.CalcularPorcentaje(femenino, masculino)}%");

            rtbAnalisis.Text = datos.ToString();
            
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            int alDia = this.estadisticas.CantidadEstados(EEstado.AlDia);
            int deudores = this.estadisticas.CantidadEstados(EEstado.Deudor);
            int totalEstados = alDia + deudores;
            int alDiaMasculino = this.estadisticas.CantidadEstados(EEstado.AlDia, ESexo.Masculino);
            int deudoresMasculino = this.estadisticas.CantidadEstados(EEstado.Deudor, ESexo.Masculino);
            int totalEstadosMasculinos = alDiaMasculino + deudoresMasculino;
            int alDiaFemenino = this.estadisticas.CantidadEstados(EEstado.AlDia, ESexo.Femenino);
            int deudoresFemenino = this.estadisticas.CantidadEstados(EEstado.Deudor, ESexo.Femenino);
            int totalEstadosFemeninos = alDiaFemenino + deudoresFemenino;


            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"La cantidad de estados de clientes es {totalEstados}, Al dia {this.CalcularPorcentaje(alDia, deudores)}% & Deudores {this.CalcularPorcentaje(deudores, alDia)}%");
            datos.AppendLine($"----------------------------------------");
            datos.AppendLine($"La cantidad de estados de clientes Masculinos {totalEstadosMasculinos}, Al dia {this.CalcularPorcentaje(alDiaMasculino, deudoresMasculino)}% & Deudores {this.CalcularPorcentaje(deudoresMasculino, alDiaMasculino)}%");
            datos.AppendLine($"----------------------------------------");
            datos.AppendLine($"La cantidad de estados de clientes Femeninos {totalEstadosFemeninos}, Al dia {this.CalcularPorcentaje(alDiaFemenino, deudoresFemenino)}% & Deudores {this.CalcularPorcentaje(deudoresFemenino, alDiaFemenino)}%");

            rtbAnalisis.Text = datos.ToString();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            int cervezaMayorGanancia = estadisticas.CantidadProductoConMayorGanancia(EProducto.Cerveza);
            int gaseosaMayorGanancia = estadisticas.CantidadProductoConMayorGanancia(EProducto.Gaseosa);
            int cervezaMasVendido = estadisticas.CantidadProducto(EProducto.Cerveza);
            int gaseosaMasVendido = estadisticas.CantidadProducto(EProducto.Gaseosa);
            int cervezaMasculino = estadisticas.CantidadProducto(EProducto.Cerveza, ESexo.Masculino);
            int gaseosaMasculino = estadisticas.CantidadProducto(EProducto.Gaseosa, ESexo.Masculino);
            int totalProductosMasculino = gaseosaMasculino + cervezaMasculino;
            int cervezaFemenino = estadisticas.CantidadProducto(EProducto.Cerveza, ESexo.Femenino);
            int gaseosaFemenino = estadisticas.CantidadProducto(EProducto.Gaseosa, ESexo.Femenino);
            int totalProductosFemenino = gaseosaFemenino + cervezaFemenino;

            int totalProductos = totalProductosMasculino + totalProductosFemenino;
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Total de productos vendidos {gaseosaMasVendido+ cervezaMasVendido}, Gaseosas {gaseosaMasVendido} & Cerveza {cervezaMasVendido}");
            datos.AppendLine($"----------------------------------------");
            datos.AppendLine($"Ganancia por tipo de producto Gaseosas ${gaseosaMayorGanancia} & Cerveza ${cervezaMayorGanancia}");
            datos.AppendLine($"----------------------------------------");
            datos.AppendLine($"Porcentaje de productos mas vendidos Gaseosas {this.CalcularPorcentaje(gaseosaMasVendido, cervezaMasVendido)}% & Cerveza {this.CalcularPorcentaje(cervezaMasVendido, gaseosaMasVendido)}%");
            datos.AppendLine($"----------------------------------------");
            datos.AppendLine($"La cantidad de productos mas comprados por genero es {totalProductos}, Masculino {this.CalcularPorcentaje(totalProductosMasculino, totalProductosFemenino)}% Femenino {this.CalcularPorcentaje(totalProductosFemenino, totalProductosMasculino)}%");
            datos.AppendLine($"----------------------------------------");
            datos.AppendLine($"La cantidad de productos mas comprados por el genero Masculino {totalProductosMasculino}, Gaseosas {this.CalcularPorcentaje(gaseosaMasculino, cervezaMasculino)}% Cervezas {this.CalcularPorcentaje(cervezaMasculino, gaseosaMasculino)}%");
            datos.AppendLine($"----------------------------------------");
            datos.AppendLine($"La cantidad de productos mas comprados por el genero Fenemino {totalProductosFemenino}, Gaseosas {this.CalcularPorcentaje(gaseosaFemenino, cervezaFemenino)}% Cervezas {this.CalcularPorcentaje(cervezaFemenino, gaseosaFemenino)}%");

            rtbAnalisis.Text = datos.ToString();
        }

        private void btnFabrica_Click(object sender, EventArgs e)
        {
            int masculino = this.estadisticas.CantidadClientes(ESexo.Masculino);
            int femenino = this.estadisticas.CantidadClientes(ESexo.Femenino);
            int gaseosa = this.estadisticas.CantidadStock(EProducto.Gaseosa);
            int cerveza = this.estadisticas.CantidadStock(EProducto.Cerveza);


            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Nombre de la fabrica: {this.fabrica.Nombre}");
            datos.AppendLine($"Dinero actual en la caja: {this.fabrica.DineroCaja}");
            datos.AppendLine($"----------------------------------------");
            datos.AppendLine($"Cantidad de clientes actuales ({masculino + femenino}) Masculino {masculino} & Femenino {femenino}");
            datos.AppendLine($"----------------------------------------");
            datos.AppendLine($"Cantidad de productos actuales ({gaseosa + cerveza}) Gaseosas {gaseosa} & Cervezas {cerveza}");

            rtbAnalisis.Text = datos.ToString();

        }

        private void cmbFiltrarMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            EMes mesFiltrar;
            Enum.TryParse(cmbFiltrarMes.SelectedValue.ToString(), out mesFiltrar);
            this.estadisticas.Mes = mesFiltrar;
            DatosDias();
        }
    }
}
