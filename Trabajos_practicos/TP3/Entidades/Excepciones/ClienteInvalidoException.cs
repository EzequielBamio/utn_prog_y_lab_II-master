using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteInvalidoException : Exception
    {
        public ClienteInvalidoException()
        {
        }

        public ClienteInvalidoException(string mensaje)
            : base(mensaje)
        {
        }

        public ClienteInvalidoException(string mensaje, Exception inner)
            : base(mensaje, inner)
        {
        }
    }
}
