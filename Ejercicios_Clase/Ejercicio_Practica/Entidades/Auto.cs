using System;

namespace Entidades
{
    public class Auto
    {
        public int velocidadActual;

        /// <summary>
        /// Acelera el Automovil en 1 Unidad a la vez
        /// </summary>
        public void Acelerar() 
        {
            this.velocidadActual++;
        }

        /// <summary>
        /// Acelera el Automovil 
        /// </summary>
        /// <param name="incremento"></param>
        public void Acelerar(int incremento)
        {
            this.velocidadActual += incremento;
        }

    }
}
