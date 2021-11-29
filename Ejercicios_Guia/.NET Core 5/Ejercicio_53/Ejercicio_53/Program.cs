using System;
using System.Collections.Generic;
using Entidades;
namespace Ejercicio_53
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(0, ConsoleColor.Green);
            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz.ToString()); 
            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo.ToString());
            Console.ReadKey();
            Console.Clear();
            List<IAcciones> list = new List<IAcciones>();
            list.Add(miBoligrafo);
            Cartuchera1 cartuchera1 = new Cartuchera1(list);
            if (cartuchera1.ProbarElementos())
            {
                Console.WriteLine("Los boligrafos pudieron gastar las 1 unidades.");
            }
            else 
            {
                Console.WriteLine("ERROR: alguno de los boligrafos no pudo gastar las 1 unidades.");
            }

        }
    }
}
