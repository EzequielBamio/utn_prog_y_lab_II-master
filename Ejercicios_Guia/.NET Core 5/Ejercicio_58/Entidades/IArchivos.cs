using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    interface IArchivos<T>
    {
        public bool Guardar(string ruta, T objeto);

        public bool GuardarComo(string ruta, T objeto);

        public T Leer(string ruta);
        
    }
}
