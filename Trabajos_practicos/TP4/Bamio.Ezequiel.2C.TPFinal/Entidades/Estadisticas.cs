using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estadisticas
    {
        private Fabrica fabrica;
        private DateTime fechaFinal;
        private DateTime fechaInicio;


        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }


        public Estadisticas(Fabrica fabrica)
        {
            this.fabrica = fabrica;
        }

        public int CantidadProducto(EProducto producto) 
        {
            int rtn = 0;
            foreach (Factura f in this.fabrica.HistorialFacturas) 
            {
                foreach (Producto p in f.Productos) 
                {
                    if (p.TipoProducto == producto && f.Fecha >= this.FechaInicio && f.Fecha <= this.fechaFinal)
                    {
                        rtn++;
                    }
                }
            }

            return rtn;
        }
        public int CantidadStock(EProducto producto)
        {
            int rtn = 0;
            foreach (Producto p in this.fabrica.Productos)
            {
                if (p.TipoProducto == producto)
                {
                    rtn++;
                }
            }
            

            return rtn;
        }
        public int CantidadEnvase(ETipoEnvase envase)
        {
            int rtn = 0;
            foreach (Factura f in this.fabrica.HistorialFacturas)
            {
                foreach (Producto p in f.Productos)
                {
                    if (p.TipoEnvase == envase && f.Fecha >= this.FechaInicio && f.Fecha <= this.fechaFinal)
                    {
                        rtn++;
                    }
                }
            }

            return rtn;
        }
        public int CantidadEstados(EEstado estado)
        {
            int rtn = 0;
            foreach (Cliente c in this.fabrica.Clientes)
            {
                if (c.Estado == estado)
                {
                    rtn++;
                }
            }

            return rtn;
        }
        public int CantidadClientesPorGenero(string sexo) 
        {
            int rtn = 0;
            foreach (Cliente cliente in this.fabrica.Clientes)
            {
                if (cliente.Sexo == sexo)
                {
                    rtn++;
                }
            }
            return rtn;
        }

        public int DiaConMayorVentas(DayOfWeek dia) 
        {
            int rtn = 0;
            foreach (Factura f in this.fabrica.HistorialFacturas)
            {
                if (f.Fecha.DayOfWeek == dia && f.Fecha >= this.FechaInicio && f.Fecha <= this.fechaFinal)
                {
                    rtn += f.Productos.Count;
                }
            }

            return rtn;
        }

        public float DineroRecaudado()
        {
            int rtn = 0;
            foreach (Cliente cliente in this.fabrica.Clientes) 
            {
                rtn += this.CalcularDineroCliente(cliente);
            }
            return rtn;
        }
        public int CalcularProductoCliente(Cliente c)
        {
            int rtn = 0;
            foreach (Factura f in this.fabrica.HistorialFacturas)
            {
                if (f.IdCliente == c.Id && f.Fecha >= this.FechaInicio && f.Fecha <= this.fechaFinal)
                {
                    rtn += f.Productos.Count;
                }
            }

            return rtn;
        }
        public int CalcularDineroCliente(Cliente c)
        {
            int rtn = 0;
            foreach (Factura f in this.fabrica.HistorialFacturas)
            {
                if (f.IdCliente == c.Id && f.Fecha >= this.FechaInicio && f.Fecha <= this.fechaFinal)
                {
                    rtn += f.CalcularGastosTotal();
                }
            }

            return rtn;
        }

    }
}
