using System;
using Entidades;
namespace Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 25";

            Equipo equipo = new Equipo(3, "Boca Juniors");
            Jugador jugador1 = new Jugador(2254887, "Aaron Molinas", 2, 7);
            Jugador jugador2 = new Jugador(3522448, "Juan Ramirez", 5, 9);
            Jugador jugador3 = new Jugador(4422335, "Alan Varela", 1, 16);
            Jugador jugador4 = new Jugador(2254887, "Aaron Molinas", 2, 7);
            DirectorTecnico tecnico = new DirectorTecnico("Sebastian Battaglia", DateTime.Parse("23-05-1998"));


            Console.WriteLine(equipo + jugador1);
            Console.WriteLine(equipo + jugador2);
            Console.WriteLine(equipo + jugador3);
            Console.WriteLine(jugador1 == jugador4);
            Console.WriteLine(jugador3 == jugador4);
            Console.WriteLine("Estadisticas: ");

            Console.WriteLine(jugador1.MostrarDatos());
            Console.WriteLine(jugador2.MostrarDatos());
            Console.WriteLine(jugador3.MostrarDatos());
            Console.WriteLine("\n-------------------------------\n");
            Console.WriteLine(tecnico.MostrarDatos());

        }
    }
}
