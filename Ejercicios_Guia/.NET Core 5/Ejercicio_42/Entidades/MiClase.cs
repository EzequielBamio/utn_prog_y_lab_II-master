using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
        public MiClase() 
        {
            try
            {
                MiClase.MiMetodo();
            }
            catch (DivideByZeroException) 
            {
                throw;
            }
        }
        public MiClase(string mensaje)
        {

            try
            {
                MiClase miClase = new MiClase();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("Fallo en Mi Clase", e);
            }
        }

        public static void MiMetodo() 
        {
            throw new DivideByZeroException();
        }

    }
}
