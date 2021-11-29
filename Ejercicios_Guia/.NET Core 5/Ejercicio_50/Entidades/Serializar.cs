using System;

namespace Entidades
{
    public class Serializar<S, V> : IGuardar<S, V>
    {
        //Implicita
        public bool Guardar(S obj)
        {
            return true;
        }

        //Explicita
        V IGuardar<S, V>.Leer()
        {
            return (V)Convert.ChangeType("Texto Leído", typeof(V));
        }
    }
}
