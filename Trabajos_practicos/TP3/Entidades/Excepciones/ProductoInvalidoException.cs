using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoInvalidoException : Exception
    {
        public ProductoInvalidoException()
        {
        }

        public ProductoInvalidoException(string mensaje)
            : base(mensaje)
        {
        }

        public ProductoInvalidoException(string mensaje, Exception inner)
            : base(mensaje, inner)
        {
        }
    }
}
