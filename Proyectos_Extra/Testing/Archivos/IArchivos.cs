using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivos<T> where T : class
    {
        void Escribir(string rutaCompleta, T dato, bool incluir);

        T Leer(string rutaCompleta);
    }
}
