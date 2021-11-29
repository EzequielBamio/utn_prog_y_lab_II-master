using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c) 
        {
            bool rtn = false;
            c = Char.ToUpper(c);

            if (c == 'S')
            {
                rtn = true;
            }
            else {
                rtn = false;
            }
            

            return rtn;
        }
    }
}
