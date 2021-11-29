using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reporte
    {
        private int id;
        private int cantidadPedidos;
        private int cantidadEntregados;
        private int cantidadNoEntregados;
        private string fecha;
        private int totalVenta;

        public string Fecha { get => fecha; set => fecha = value; }
        public int TotalVenta { get => totalVenta; set => totalVenta = value; }
        public int Id { get => id; set => id = value; }
        public int CantidadPedidos { get => cantidadPedidos; set => cantidadPedidos = value; }
        public int CantidadEntregados { get => cantidadEntregados; set => cantidadEntregados = value; }
        public int CantidadNoEntregados { get => cantidadNoEntregados; set => cantidadNoEntregados = value; }

        public Reporte()
        {

        }
        public Reporte(int cantidadPedidos, int cantidadEntregados, int cantidadNoEntregados, int totalVenta, string fecha)
        {
            this.totalVenta = totalVenta;
            this.fecha = fecha;
            this.CantidadPedidos = cantidadPedidos;
            this.CantidadEntregados = cantidadEntregados;
            this.CantidadNoEntregados = cantidadNoEntregados;
        }
        public Reporte(int cantidadPedidos, int cantidadEntregados, int cantidadNoEntregados, int totalVenta)
            : this(cantidadPedidos, cantidadEntregados, cantidadNoEntregados, totalVenta, DateTime.Now.ToString("dddd, dd 'de' MMMM yyyy 'a las' HH:mm"))
        {
        }
        

        public override string ToString()
        {
            return $"Reporte: Total pedidos: {this.CantidadPedidos} - total entregados: {this.cantidadEntregados} - total no entregados: {this.CantidadNoEntregados} - Total: ${this.TotalVenta}";
        }

    }
}
