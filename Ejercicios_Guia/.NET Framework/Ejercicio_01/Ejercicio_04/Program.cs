using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
              dos grupos de números, cuyas sumas son iguales.
              El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
              cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
              49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
              Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
              usuario ingrese por consola.
              Nota: Utilizar estructuras repetitivas y selectivas.*/

            int numeroIngresado;
            int acumuladorDownNumerico = 0;
            int acumuladorUpNumerico = 0;
            Console.WriteLine("INGRESE UN NUMERO: ");
            int.TryParse(Console.ReadLine(), out numeroIngresado);
            if (numeroIngresado > 1) {
                for(int i = 1; i < numeroIngresado; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        acumuladorDownNumerico += j;
                    }
                    for (int j = i + 1; j < numeroIngresado; j++)
                    {
                        acumuladorUpNumerico += j;
                        if (acumuladorUpNumerico == acumuladorDownNumerico)
                        {
                            Console.WriteLine("EL NUMERO {0} ES UN CENTRO NUMERICO", i);
                        }                    
                    }
                    acumuladorDownNumerico = 0;
                    acumuladorUpNumerico = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
