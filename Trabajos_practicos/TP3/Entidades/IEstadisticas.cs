using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IEstadisticas
    {
        public int TotalVentas();
        public int TotalGaseosas();
        public int TotalCervezas();
        public int CantidadGaseosas();
        public int CantidadCervezas();
        public int CantidadLatas();
        public int CantidadBotellas();
        public Cliente MejorCliente();
    }
}
