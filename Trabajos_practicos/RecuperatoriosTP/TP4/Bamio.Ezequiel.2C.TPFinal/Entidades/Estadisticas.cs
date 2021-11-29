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
        private EMes mes;

        public EMes Mes { get => mes; set => mes = value; }

        public Estadisticas(Fabrica fabrica)
        {
            this.fabrica = fabrica;
        }
        
        public int CantidadProductoConMayorGanancia(EProducto producto)
        {
            int rtn = 0;
            foreach (Factura f in this.fabrica.HistorialFacturas)
            {
                foreach (Producto p in f.Productos)
                {
                    if (p.TipoProducto == producto && f.Fecha.Month == (int)mes)
                    {
                        rtn += p.CalcularPrecioTotal();
                    }
                }
            }

            return rtn;
        }
        public int CantidadProducto(EProducto producto) 
        {
            int rtn = 0;
            foreach (Factura f in this.fabrica.HistorialFacturas) 
            {
                foreach (Producto p in f.Productos) 
                {
                    if (p.TipoProducto == producto && f.Fecha.Month == (int)mes)
                    {
                        rtn += p.Stock;
                    }
                }
            }

            return rtn;
        }
        public int CantidadProducto(EProducto producto, ESexo sexo)
        {
            int rtn = 0;
            foreach (Factura f in this.fabrica.HistorialFacturas)
            {
                foreach (Cliente c in this.fabrica.Clientes) 
                {
                    if (c.Id == f.IdCliente)
                    {
                        foreach (Producto p in f.Productos)
                        {
                            if (p.TipoProducto == producto && c.Sexo == sexo && f.Fecha.Month == (int)mes)
                            {
                                rtn += p.Stock;
                            }
                        }
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
                    rtn += p.Stock;
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
                    if (p.TipoEnvase == envase && f.Fecha.Month == (int)mes)
                    {
                        rtn += p.Stock;
                    }
                }
            }

            return rtn;
        }
        public int CantidadEnvase(ETipoEnvase envase, EProducto producto)
        {
            int rtn = 0;
            foreach (Factura f in this.fabrica.HistorialFacturas)
            {
                foreach (Producto p in f.Productos)
                {
                    if (p.TipoEnvase == envase && p.TipoProducto == producto && f.Fecha.Month == (int)mes)
                    {
                        rtn += p.Stock;
                    }
                }
            }

            return rtn;
        }
        public int CantidadEnvase(ETipoEnvase envase, ESexo sexo)
        {
            int rtn = 0;
            foreach (Factura f in this.fabrica.HistorialFacturas)
            {
                foreach (Cliente c in this.fabrica.Clientes)
                {
                    foreach (Producto p in f.Productos)
                    {
                    
                        if (p.TipoEnvase == envase && c.Sexo == sexo && f.Fecha.Month == (int)mes)
                        {
                            rtn += p.Stock;
                        }
                        
                    }
                }
            }

            return rtn;
        }
        public int CantidadClientes(ESexo sexo)
        {
            int rtn = 0;
            foreach (Cliente c in this.fabrica.Clientes)
            {
                if (c.Sexo == sexo)
                {
                    rtn++;
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
        public int CantidadEstados(EEstado estado, ESexo sexo)
        {
            int rtn = 0;
            foreach (Cliente c in this.fabrica.Clientes)
            {
                if (c.Estado == estado && c.Sexo == sexo)
                {
                    rtn++;
                }
            }

            return rtn;
        }

        public int DiaConMayorVentas(EDias dia) 
        {
            int rtn = 0;
            foreach (Factura f in this.fabrica.HistorialFacturas)
            {
                if ((EDias)f.Fecha.DayOfWeek <= dia && f.Fecha.Month == (int)mes)
                {
                    rtn += f.CalcularGastosTotal();
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

        public int CalcularDineroCliente(Cliente c)
        {
            int rtn = 0;
            foreach (Factura f in this.fabrica.HistorialFacturas)
            {
                if (f.IdCliente == c.Id)
                {
                    rtn += f.CalcularGastosTotal();
                }
            }

            return rtn;
        }

        public int CalcularCrecimiento(int ventasDiaAnterior, int ventasDiaActual) 
        {

            if (ventasDiaAnterior > ventasDiaActual)
            {
                return ventasDiaAnterior - ventasDiaActual;
            }
            else 
            {
                return ventasDiaActual - ventasDiaAnterior;
            }
        }

        

    }
}
