using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
            un mensaje "¿Continuar? (S/N)".
            En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
            opciones.
            El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
            cualquier otro valor.*/
            int numeroIngresado;
            char respuesta;
            bool rtn = false; ;
            do
            {
                Console.WriteLine("[*] INGRESE UN NUMERO: ");
                int.TryParse(Console.ReadLine(), out numeroIngresado);
                if(numeroIngresado > 0)
                {
                    Console.WriteLine("¿Continuar? (S/N)");
                    char.TryParse(Console.ReadLine(), out respuesta);
                    rtn = ValidarRespuesta.ValidaS_N(respuesta);
                    if (!rtn)
                    {
                        rtn = false;
                    }
                    
                }

            } while (rtn != false);
            Console.WriteLine("FIN DEL PROGRAMA.");
            Console.ReadLine();
        }
    }
}
