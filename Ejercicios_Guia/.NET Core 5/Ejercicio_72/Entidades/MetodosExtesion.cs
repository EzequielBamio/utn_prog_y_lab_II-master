using System;

namespace Entidades
{
    public static class MetodosExtesion
    {
        public static int CantidadDeDigitos(this long n) 
        {
            

            return n.ToString().Length;
        }
    }
}
