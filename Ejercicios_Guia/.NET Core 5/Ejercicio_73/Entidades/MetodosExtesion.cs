using System;

namespace Entidades
{
    public static class MetodosExtesion
    {
        public static int CantidadSignos(this string s) 
        {
            int rtn = 0;
            foreach (char c in s)
            {
                if (c == '.' || c == ',' || c == ';')
                {
                    rtn++;
                }
            }

            return rtn;
        }
    }
}
