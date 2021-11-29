using System;
using Entidades;
namespace Ejercicio_39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 39";

            Sobrescrito sobre = new SobreSobrescrito();
            Console.WriteLine(sobre.MiMetodo()); 
        }
    }
}
