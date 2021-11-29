using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LimiteEdadExcepcion : Exception
    {

        public LimiteEdadExcepcion(string mensaje) 
            : base(mensaje)
        {
        }

        public LimiteEdadExcepcion(string mensaje, Exception inner)
            : base(mensaje, inner)
        {
        }

    }
}
