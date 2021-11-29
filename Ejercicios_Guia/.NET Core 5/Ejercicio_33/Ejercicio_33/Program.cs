using System;
using Entidades;
namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro nuevoLibro = new Libro();
            nuevoLibro[0] = "El jinite";
            nuevoLibro[1] = "El Pedro";
            nuevoLibro[2] = "El Juane";
            nuevoLibro[3] = "El Yane";

            Console.WriteLine(nuevoLibro[0]);
            Console.WriteLine(nuevoLibro[1]);
            Console.WriteLine(nuevoLibro[2]);
            Console.WriteLine(nuevoLibro[3]);

        }
    }
}
