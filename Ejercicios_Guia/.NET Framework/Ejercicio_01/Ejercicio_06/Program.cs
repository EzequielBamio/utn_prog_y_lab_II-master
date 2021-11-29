using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
            calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
            con DateTime.Now).
            Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.*/
            int dia;
            int mes;
            int anio;
            int cantidadAniosBisiestos = 0;
            int cantidadAniosNoBisiestos;
            int cantidadDiasBisiestos;
            int cantidadDiasNoBisiesto;
            int diasVividos;
            DateTime anioActual = DateTime.Now;

            Console.WriteLine("INGRESE LA FECHA DE SU NACIMIENTO.");
            Console.WriteLine(" ");
            Console.WriteLine("INGRESE EL DIA.");
            int.TryParse(Console.ReadLine(), out dia);
            Console.WriteLine("INGRESE EL MES.");
            int.TryParse(Console.ReadLine(), out mes);
            Console.WriteLine("INGRESE EL AÑO.");
            int.TryParse(Console.ReadLine(), out anio);

            //calcular los años bisiestos desde que nacio
            for (int i = anio; i < anioActual.Year; i++)
            {
                if (i % 4 == 0)
                {
                    cantidadAniosBisiestos++;
                }
            }
            //
            cantidadAniosNoBisiestos = (anioActual.Year - anio) - cantidadAniosBisiestos;
            cantidadDiasNoBisiesto = cantidadAniosNoBisiestos * 355;
            cantidadDiasBisiestos = cantidadAniosBisiestos * 366;
            diasVividos = cantidadDiasBisiestos + cantidadDiasNoBisiesto;
            Console.WriteLine("LA CANTIDAD DE DIAS VIVIDOS DEL AÑO {0} A {1} ES: {2}", anio, anioActual.Year, diasVividos);

            Console.ReadLine();
        }

    }
}
