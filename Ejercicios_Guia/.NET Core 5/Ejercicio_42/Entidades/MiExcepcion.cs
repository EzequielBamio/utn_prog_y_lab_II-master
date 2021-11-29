using System;

namespace Entidades
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string mensaje, Exception inner) 
            : base(mensaje, inner)
        { }
    }
}
