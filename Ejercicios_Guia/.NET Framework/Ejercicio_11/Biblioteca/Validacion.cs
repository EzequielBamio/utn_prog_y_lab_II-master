using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validacion
    {

        public static bool Validar(int valor, int min, int max) 
        {
            bool rtn = false;
            if (valor >= min && valor <= max) 
            {
                rtn = true;
            }
            return rtn;
        }
    }
}
