using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
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

        #region operators

        public static string operator +(NumeroDecimal num1, NumeroBinario num2)
        {
            double resultado;
            int auxNumero = Conversor.BinarioDecimal(num2.GetNumero());
            resultado = auxNumero + num1.GetNumero();

            return Conversor.DecimalBinario((int)resultado);
        }
        public static string operator -(NumeroDecimal num1, NumeroBinario num2)
        {
            double resultado;
            int auxNumero = Conversor.BinarioDecimal(num2.GetNumero());
            resultado = auxNumero - num1.GetNumero();

            return Conversor.DecimalBinario((int)resultado);
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
