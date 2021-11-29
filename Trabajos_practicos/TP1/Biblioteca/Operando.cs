using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Operando
    {
        private double numero;

        #region Builders
        public Operando() : this(0)
        {
        
        }
        public Operando(double numero) 
        {
            this.Numero = numero.ToString();
        }
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion

        #region Getters

        /// <summary>
        /// Agrega el valor, validando que sea un numero.
        /// </summary>
        private string Numero 
        {
            set 
            {
                this.numero = ValidarOperando(value);
            } 
        }
        #endregion

        #region Operations Binary and Decimal
        /// <summary>
        /// Valida que la cadena pasada por parametro es un Binaro, si lo es lo convierte a Decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Si es un numero binario retorna el numero convertido sino un mensaje de error</returns>
        public static string BinarioDecimal(string binario) 
        {
            string rtn = "Valor invalido";
            int resultado;
            int tamCadena;
            if (EsBinario(binario)) 
            {
                resultado = 0;
                tamCadena = binario.Length;

                foreach (char item in binario)
                {
                    tamCadena--;
                    if (item == '1')
                    {
                        resultado += (int)Math.Pow(2, tamCadena);
                    }
                }
                rtn = resultado.ToString();
            }
            return rtn;
        }

        /// <summary>
        /// Convierte el numero pasado por parametro en Binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>El numero convertido a binario</returns>
        public static string DecimalBinario(string numero) 
        {
            double auxNum;
            string rtn = string.Empty;
            if (double.TryParse(numero, out auxNum))
            {
                rtn = DecimalBinario(auxNum);
            }

            return rtn;
            
        }

        /// <summary>
        /// Convierte el numero pasado por parametro en Binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>El numero convertido a binario</returns>
        public static string DecimalBinario(double numero)
        {
            string rtn = string.Empty;
            int num = (int)numero;
            int resultado = num;
            int resto;
            if (num > -1)
            {
                do
                {
                    resto = resultado % 2;
                    resultado /= 2;
                    rtn = resto.ToString() + rtn;

                } while (resultado > 0);
            }
            else
            {
                rtn = "Valor invalido";
            }
            return rtn;
        }

        /// <summary>
        /// Valida la cadena pasada por parametro que sean '1' y '0'
        /// </summary>
        /// <param name="binario">Cadena a validar</param>
        /// <returns>True si es binario - False si no es binario</returns>
        private static bool EsBinario(string binario) 
        {
            bool rtn = true;   
            foreach (char item in binario) 
            {
                if (item != '1' && item != '0') 
                {
                    rtn = false;
                    break;
                } 
            }

            return rtn;
        }
        #endregion

        #region Operators

        /// <summary>
        /// Realiza la suma entre los operandos.
        /// </summary>
        /// <param name="n1">Operando 1</param>
        /// <param name="n2">Operando 2</param>
        /// <returns>El resultado de la suma entre los operandos.</returns>
        public static double operator +(Operando n1, Operando n2) 
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Realiza la resta entre los operandos.
        /// </summary>
        /// <param name="n1">Operando 1</param>
        /// <param name="n2">Operando 2</param>
        /// <returns>El resultado de la resta entre los operandos.</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Realiza la multiplicacion entre los operandos.
        /// </summary>
        /// <param name="n1">Operando 1</param>
        /// <param name="n2">Operando 2</param>
        /// <returns>El resultado de la multiplicacion entre los operandos.</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Realiza la division entre los operandos si n2 es distinto a 0.
        /// </summary>
        /// <param name="n1">Operando 1</param>
        /// <param name="n2">Operando 2</param>
        /// <returns>El resultado de la division entre los operandos o si n2 es 0 retorna el valor minimo de un double.</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double rtn = double.MinValue;
            if (n2.numero != 0) 
            {
                rtn = n1.numero / n2.numero;
            }
            return rtn;
        }
        #endregion

        #region Validate

        /// <summary>
        /// Valida que la cadena ingresada por parametro sea un numero.
        /// </summary>
        /// <param name="strNumero">Cadena a validar</param>
        /// <returns>El numero pasado por parametro, si no es un numero 0.</returns>
        private double ValidarOperando(string strNumero) 
        {
            double auxNumero;
            if (!double.TryParse(strNumero, out auxNumero)) 
            {
                auxNumero = 0;
            }

            return auxNumero;
        }
        #endregion

    }
}