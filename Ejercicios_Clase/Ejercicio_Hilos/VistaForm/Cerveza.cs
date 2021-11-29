using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaForm
{
    public class Cerveza
    {
        private string nombre;
        public Cerveza(string nombre)
        {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return $"Marca: {this.nombre}";
        }
    }
}
