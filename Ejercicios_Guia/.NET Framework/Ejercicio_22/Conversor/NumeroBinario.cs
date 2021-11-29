using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class NumeroBinario
    {
        private string numero;
        #region builders
        private NumeroBinario(string numero) 
        {
            this.numero = numero;
        }
        #endregion

        #region Getters
        public string GetNumero() 
        {
            return this.numero;
        }
        #endregion

        #region operators

        public static string operator +(NumeroBinario num1, NumeroDecimal num2) 
        {
            double resultado;
            int auxNumero = Conversor.BinarioDecimal(num1.GetNumero());
            resultado = auxNumero + num2.GetNumero();

            return Conversor.DecimalBinario((int)resultado);
        }
        public static string operator -(NumeroBinario num1, NumeroDecimal num2)
        {
            double resultado;
            int auxNumero = Conversor.BinarioDecimal(num1.GetNumero());
            resultado = auxNumero - num2.GetNumero();

            return Conversor.DecimalBinario((int)resultado);
        }
        public static bool operator ==(NumeroBinario num1, NumeroDecimal num2)
        {
            int auxNumero = Conversor.BinarioDecimal(num1.GetNumero());

            return auxNumero == num2.GetNumero();
        }
        public static bool operator !=(NumeroBinario num1, NumeroDecimal num2)
        {
            return !(num1 == num2);
        }

        #endregion
    }
}
