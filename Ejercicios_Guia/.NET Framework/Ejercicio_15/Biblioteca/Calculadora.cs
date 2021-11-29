using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Calculadora
    {
        public static double Calcular(double A, double B, char operador) 
        {
            double rtn = -1001;
            switch (operador)
            {
                case '+':
                    rtn = A + B;
                    break;
                case '-':
                    rtn = A - B;
                    break;
                case '*':
                    rtn = A * B;
                    break;
                case '/':
                    rtn = -1002;
                    if (Calculadora.Validar(B)) 
                    {
                        rtn = A / B;
                    }
                    break;
            }

            return rtn;
        }

        private static bool Validar(double B) 
        {
            bool rtn = false;
            if (B != 0) 
            {
                rtn = true;
            }

            return rtn;
        }
    }
}
