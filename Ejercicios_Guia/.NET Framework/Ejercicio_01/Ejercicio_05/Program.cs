using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que determine si un año es bisiesto.
            Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
            también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
            Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/
            int anioInicio;
            int anioFin;

            Console.WriteLine("INGRESE EL AÑO DE INCIO: ");
            int.TryParse(Console.ReadLine(), out anioInicio);
            Console.WriteLine("INGRESE EL AÑO DE FIN");
            int.TryParse(Console.ReadLine(), out anioFin);

            for (int i = anioInicio; i < anioFin; i++) {
                if (i % 4 == 0) {
                    Console.WriteLine("EL AÑO {0} ES BISIESTO.", i);
                    Console.WriteLine("--------------------------");
                }
            }

            Console.ReadLine();
        }
    }
}
