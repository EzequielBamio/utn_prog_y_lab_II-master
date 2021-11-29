using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conversor
    {
        public static string DecimalBinario(int num) 
        {
            string binario = " ";
            int auxNumero = num;
            do
            {
                if (auxNumero % 2 == 0)
                {
                    binario += "0";
                }
                else
                {
                    binario += "1";
                }

                auxNumero = auxNumero / 2;

            } while (auxNumero > 0);

            binario = Conversor.Invertir(binario);

            return binario;
        }

        static string Invertir(string cadena) 
        {
            string invertido = "";
            for (int i = cadena.Length - 1; i >= 0; i--) {
                invertido += cadena[i];
            }

            return invertido;
        }

        public static int BinarioDecimal(string bin) 
        {
            int numDecimal = 0;
            int multiplo = 1;
            bin = Conversor.Invertir(bin);
            for (int i = 0; i < bin.Length; i++) 
            {
                if (bin[i] == '1') 
                {
                    numDecimal += multiplo;
                }
                multiplo *= 2;

            }
            return numDecimal;
        }
    }
}
