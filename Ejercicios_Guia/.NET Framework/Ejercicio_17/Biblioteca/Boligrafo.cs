using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo
    {

        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color) 
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor() 
        {
            return this.color;
        }

        public short GetTinta() 
        {
            return this.tinta;
        }

        private string SetAstericos(int value) 
        {
            string rtn = "";
            for (int i = 0; i < value; i++)
            {
                rtn += "*";
            }

            return rtn;
        }
        public bool Pintar(short gasto, out string dibujo) 
        {
            bool rtn = false;
            dibujo = "";
            short auxTinta = GetTinta();
            short auxTintaActual;

            if(gasto < 0)
            {
                if (auxTinta > 0)
                {
                    SetTinta(gasto);
                    auxTintaActual = GetTinta();

                    if (auxTintaActual == 0)
                    {
                        dibujo = SetAstericos(auxTinta);
                    }
                    else
                    {
                        dibujo = SetAstericos(auxTinta - auxTintaActual);
                    }
                    rtn = true;
                }
            }

            return rtn;
        }

        public void Recargar() 
        {
            SetTinta(cantidadTintaMaxima);
        }

        private void SetTinta(short tinta) 
        {
            short auxTintaActual = (short)(GetTinta() + tinta);

            if (auxTintaActual < 0)
            {
                auxTintaActual = 0;
            }
            else 
            {
                if (auxTintaActual > cantidadTintaMaxima) 
                {
                    auxTintaActual = 100;
                }
            }

            this.tinta = auxTintaActual;
        }

    }
}
