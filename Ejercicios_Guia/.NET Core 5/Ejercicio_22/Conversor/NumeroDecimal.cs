using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        private double numero;
        #region builders
        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        #endregion

        #region Getters
        public double GetNumero()
        {
            return this.numero;
        }
        #endregion

        #region Convertion

        public static implicit operator NumeroDecimal(double numero) 
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator NumeroDecimal(NumeroBinario n)
        {
            return new NumeroDecimal(Conversor.BinarioDecimal(n.GetNumero()));
        }

        #endregion

        #region operators

        public static double operator +(NumeroDecimal num1, NumeroBinario num2)
        {
            double resultado;
            int auxNumero = Conversor.BinarioDecimal(num2.GetNumero());
            resultado = num1.GetNumero() + auxNumero;

            return resultado;
        }
        public static double operator -(NumeroDecimal num1, NumeroBinario num2)
        {
            double resultado;
            int auxNumero = Conversor.BinarioDecimal(num2.GetNumero());
            resultado = num1.GetNumero() - auxNumero;

            return resultado;
        }
        public static bool operator ==(NumeroDecimal num1, NumeroBinario num2)
        {
            int auxNumero = Conversor.BinarioDecimal(num2.GetNumero());

            return auxNumero == num1.GetNumero();
        }
        public static bool operator !=(NumeroDecimal num1, NumeroBinario num2)
        {
            return !(num1 == num2);
        }

        #endregion
    }
}
