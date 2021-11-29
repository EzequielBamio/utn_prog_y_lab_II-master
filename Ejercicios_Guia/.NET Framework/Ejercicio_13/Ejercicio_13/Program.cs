using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
            string DecimalBinario(int). Convierte un número de entero a binario.
            int BinarioDecimal(string). Convierte un número binario a entero.
            NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.*/
            string binario, binario2;
            int numero, numero2;

            //binario = Conversor.DecimalBinario(28);
            //Console.WriteLine(binario);
            binario = Conversor.DecimalBinario(25);
            numero = Conversor.BinarioDecimal("1010010");
            Console.WriteLine("Decimal a Binario: " + binario);
            Console.WriteLine("Binario a Decimal: " + numero);
            Console.WriteLine("-------------------------------");
            binario2 = Conversor.DecimalBinario(numero);
            numero2 = Conversor.BinarioDecimal(binario);
            Console.WriteLine("Decimal a Binario: " + binario2);
            Console.WriteLine("Binario a Decimal: " + numero2);

            Console.ReadLine();
        }
    }
}
