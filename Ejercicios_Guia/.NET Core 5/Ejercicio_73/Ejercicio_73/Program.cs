using System;
using Entidades;
namespace Ejercicio_73
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hola. Seguime en Github, link: github.com/EzequielBamio";
            Console.WriteLine($"'{s}' tiene una cantidad de {s.CantidadSignos()} signos de puntación.");


            Console.ReadKey();
        }
    }
}
