using System;

using Entidades;

namespace Ejercicio_Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio de Practica en clase. #4";

            Auto auto = new Auto();

            auto.Acelerar();

            Console.ReadLine();
        }
    }
}
