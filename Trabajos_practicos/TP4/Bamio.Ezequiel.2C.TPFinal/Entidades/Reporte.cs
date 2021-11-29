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
        private int totalPedidos;
        private int totalPagos;
        private int totalNoPagos;
        private string fecha;
        private int reacudado;

        public Reporte()
        {

        }
        public Reporte(int totalPedidos, int totalPagos, int totalNoPagos, int recaudado, string fecha)
        {
            this.Id = new Random().Next(1, 5000);
            this.totalPedidos = totalPedidos;
            this.totalPagos = totalPagos;
            this.totalNoPagos = totalNoPagos;
            this.reacudado = recaudado;
            this.fecha = fecha;
        }
        public Reporte(int totalPedidos, int totalPagos, int totalNoPagos)
            : this(totalPedidos, totalPagos, totalNoPagos, 0, DateTime.Now.ToString("dddd dd 'de' MMMM yyyy"))
        {
        }
        public Reporte(int totalPedidos, int totalPagos, int totalNoPagos, int recaudado)
            : this(totalPedidos, totalPagos, totalNoPagos)
        {
            this.Reacudado = recaudado;
        }
        public Reporte(int id, int totalPedidos, int totalPagos, int totalNoPagos, int recaudado)
            : this(totalPedidos, totalPagos, totalNoPagos, recaudado)
        {
            this.Id = id;
        }

        public int TotalPedidos { get => totalPedidos; set => totalPedidos = value; }
        public int TotalPagos { get => totalPagos; set => totalPagos = value; }
        public int TotalNoPagos { get => totalNoPagos; set => totalNoPagos = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Reacudado { get => reacudado; set => reacudado = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"Reporte: Total pedidos: {this.TotalPedidos} - total pagos: {this.TotalPagos} - total no pagos: {this.TotalNoPagos}";
        }

    }
}
