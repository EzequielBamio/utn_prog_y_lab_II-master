using System;

namespace Biblioteca
{
    public static class Calculadora
    {
        /// <summary>
        /// Hace la operacion correspondiente.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>El resultado de la operacion realizada</returns>
        public static double Operar(Operando num1, Operando num2, char operador) 
        {
            double rtn = 0;
            
            switch (ValidarOperador(operador)) 
            {
                case '+':
                    rtn = num1 + num2;
                    break;
                case '-':
                    rtn = num1 - num2;
                    break;
                case '*':
                    rtn = num1 * num2;
                    break;
                case '/':
                    rtn = num1 / num2;
                    break;
            }
            return rtn;
        }

        /// <summary>
        /// Valida que el Caracter pasado por parametro sea un operador
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>El operador, si no retornara un '+'</returns>
        private static char ValidarOperador(char operador) 
        {
            char rtn;

            switch (operador) 
            {
                case '-':
                case '*':
                case '/':
                    rtn = operador;
                    break;
                default:
                    rtn = '+';
                    break;
            }

            return rtn;
        }
    }
}
