using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void MetodoInstancia() 
        {
            try
            {
                MiClase miClase = new MiClase("Hola");
            }
            catch (UnaExcepcion e) 
            {
                throw new MiExcepcion("Fallo en otra clase", e);
            }
        }
    }
}
