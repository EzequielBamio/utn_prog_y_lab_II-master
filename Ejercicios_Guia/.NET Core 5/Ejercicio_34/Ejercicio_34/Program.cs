using System;
using Entidades;
namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil escord = new Automovil(4, 5, VehiculoTerrestre.Colores.Negro, 5, 4);
            Automovil bora = new Automovil(4, 5, VehiculoTerrestre.Colores.Rojo, 6, 5);
            Moto bonnie = new Moto(2, 2, VehiculoTerrestre.Colores.Verde, 160);
            Moto corse = new Moto(2, 2, VehiculoTerrestre.Colores.Amarillo, 100);
            Camion frigorificos = new Camion(4, 3, VehiculoTerrestre.Colores.Blanco, 5, 1500);
            Camion rigidos = new Camion(8, 3, VehiculoTerrestre.Colores.Rojo, 5, 5000);
            //Autos
            Console.WriteLine(escord.MostrarInformacion());
            Console.WriteLine(bora.MostrarInformacion());
            //Motos
            Console.WriteLine(bonnie.MostrarInformacion());
            Console.WriteLine(corse.MostrarInformacion());
            //Camion
            Console.WriteLine(frigorificos.MostrarInformacion());
            Console.WriteLine(rigidos.MostrarInformacion());



        }
    }
}
