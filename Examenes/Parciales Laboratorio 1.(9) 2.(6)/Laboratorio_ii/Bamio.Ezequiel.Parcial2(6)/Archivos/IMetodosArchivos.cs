using System;

namespace Archivos
{
    public interface IMetodosArchivos<T>
    {
        public string GenerarRutaCompleta { get; }

        public bool ExisteArchivo(string nombreArchivo);
        public void Guardar(string archivo, T objeto);
        public void Leer(string archivo, out T objeto);

    }
}
