using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
            por consola.
            Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%)*/
            int numeroIngresado;
            int divisor;
            int numero;
            bool esPrimo;
            Console.WriteLine("INGRESE NUMERO: ");
            int.TryParse(Console.ReadLine(), out numeroIngresado);
            if (numeroIngresado > 1)
            {
                for (numero = 3; numero <= numeroIngresado; numero++)
                {
                    esPrimo = true;
                    for (divisor = 2; divisor < numero; divisor++)
                    {
                        if (numero % divisor == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }
                    if (esPrimo)
                    {
                        Console.WriteLine("EL NUMERO {0} ES PRIMO", numero);
                    }

                }
            }
            Console.ReadLine();
        }

    }
}
