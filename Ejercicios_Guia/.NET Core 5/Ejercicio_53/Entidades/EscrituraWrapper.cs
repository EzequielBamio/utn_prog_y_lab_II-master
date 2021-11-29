using System;

namespace Entidades
{
    public class EscrituraWrapper
    {
        public ConsoleColor color;
        public string texto;

        public EscrituraWrapper(string texto, ConsoleColor color) 
        {
            this.texto = texto;
            this.color = color;
        }
    }
}
