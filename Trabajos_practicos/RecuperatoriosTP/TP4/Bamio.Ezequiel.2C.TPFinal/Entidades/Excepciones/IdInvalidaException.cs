using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IdInvalidaException : Exception
    {
        public IdInvalidaException()
        {
        }

        public IdInvalidaException(string mensaje)
            : base(mensaje)
        {
        }

        public IdInvalidaException(string mensaje, Exception inner)
            : base(mensaje, inner)
        {
        }
    }
}
