using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Testing
    {
        private Stack<int> numeros;
        public Testing()
        {
            this.numeros = new Stack<int>();

        }

        public double Resultado 
        {
           
            get 
            {
                int resultado = 0;
                foreach (int numero in this.numeros) 
                {
                    resultado += numero;
                }

                return resultado;
            }
        }

        public static Testing operator +(Testing super, int numero) 
        {
            foreach (int item in super.numeros) 
            {
                numero *= item;
            }
            super.numeros.Push(numero);

            return super;
        }
        
    }
}
