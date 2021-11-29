using System;
using Entidades;
namespace Ejercicio_72
{
    class Program
    {
        static void Main(string[] args)
        {
            long numero;
            do
            {
                Console.Write("Ingrese un número: ");
                long.TryParse(Console.ReadLine(), out numero);
                Console.WriteLine($"Número de          {numero.CantidadDeDigitos()} dígitos");
            } while (true);
        }
    }
}
