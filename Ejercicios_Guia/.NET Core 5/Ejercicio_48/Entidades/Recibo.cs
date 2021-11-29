using System;

namespace Entidades
{
    public class Recibo : Documento
    {
        public Recibo() 
            : this(0)
        { }
        public Recibo(int numero)
            : base(numero)
        { }
    }
}
