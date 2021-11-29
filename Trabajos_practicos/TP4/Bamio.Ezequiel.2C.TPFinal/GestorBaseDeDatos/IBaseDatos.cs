using System;
using System.Collections.Generic;

namespace BD
{
    public interface IBaseDatos<T> where T : class, new()
    {
        public void Guardar(T objeto);
        public void Borrar(int id);
        public List<T> Leer();
        public T Leer(int id);
    }
}
