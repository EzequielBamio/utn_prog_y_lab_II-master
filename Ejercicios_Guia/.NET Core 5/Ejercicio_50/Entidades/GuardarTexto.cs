using System;

namespace Entidades
{
    public class GuardarTexto<T, V> : IGuardar<T, V>
    {
        //Implicita
        public bool Guardar(T obj)
        {
            return true;
        }
        
        //Explicita
        V IGuardar<T, V>.Leer()
        {
            return (V)Convert.ChangeType("Texto Leído", typeof(V));
        }
    }
}
