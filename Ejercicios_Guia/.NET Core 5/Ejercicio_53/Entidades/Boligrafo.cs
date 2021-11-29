using System;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color) 
        {
            this.Color = color;
            this.UnidadesDeEscritura = unidades;
        }

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }
        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escritura = new EscrituraWrapper(texto, this.Color);
            float tintaGastada = ((float)(texto.Length * 3)) / 100;
            this.UnidadesDeEscritura -= tintaGastada;

            return escritura;
        }

        public bool Recargar(int unidades)
        {
            bool rtn = false;
            if (unidades > -1) 
            {
                this.UnidadesDeEscritura = unidades;
                rtn = true;
            }
            return rtn;
        }

        public override string ToString()
        {
            return $"# Boligrafo #\n\n Color: {this.Color}\n Nivel tinta: {this.UnidadesDeEscritura}";
        }
    }
}
