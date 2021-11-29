using System;
using Entidades;
namespace Ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  i. Crear un programa que genere 2 torneos, uno de Futbol y otro de Basquet.
                ii. Crear 3 equipos de cada tipo.
                iii. Agregar los equipos en tantos torneos como se pueda.
                iv. Llamar al método Mostrar de Torneo e imprimir su retorno por pantalla.
                v. Llamar al menos 3 veces a la propiedad JugarPartido de cada torneo e imprimir su
                respuesta por pantalla.
            */

            Torneo<Equipo> torneoFutbol = new Torneo<Equipo>("SuperLiga");
            Torneo<Equipo> torneoBasquet = new Torneo<Equipo>("Copa Oro");
            //Futbol
            EquipoFutbol boca = new EquipoFutbol("Boca", new DateTime(1993,04,3));
            EquipoFutbol river = new EquipoFutbol("River", new DateTime(1901, 05, 25));
            EquipoFutbol independiente = new EquipoFutbol("Independiente", new DateTime(1905, 01, 1));
            //Basqued
            EquipoFutbol atenas = new EquipoFutbol("Atenas", new DateTime(1987, 02, 15));
            EquipoFutbol peñarol = new EquipoFutbol("Peñarol", new DateTime(1957, 08, 24));
            EquipoFutbol olimpia = new EquipoFutbol("Olimpia", new DateTime(1977, 07, 14));
            //Agregar equipos de futbol
            #region AddTeamFootball

            if (torneoFutbol + boca)
            {
                Console.WriteLine("El equipo {0} se agrego correctamente", boca.Nombre);
            }
            else 
            {
                Console.WriteLine("No se pudo agregar al equipo {0}", boca.Nombre);
            }
            if (torneoFutbol + river)
            {
                Console.WriteLine("El equipo {0} se agrego correctamente", river.Nombre);
            }
            else
            {
                Console.WriteLine("No se pudo agregar al equipo {0}", river.Nombre);
            }
            if (torneoFutbol + independiente)
            {
                Console.WriteLine("El equipo {0} se agrego correctamente", independiente.Nombre);
            }
            else
            {
                Console.WriteLine("No se pudo agregar al equipo {0}", independiente.Nombre);
            }
            #endregion

            #region AddTeamBasketball

            if (torneoBasquet + atenas)
            {
                Console.WriteLine("El equipo {0} se agrego correctamente", atenas.Nombre);
            }
            else
            {
                Console.WriteLine("No se pudo agregar al equipo {0}", boca.Nombre);
            }
            if (torneoBasquet + peñarol)
            {
                Console.WriteLine("El equipo {0} se agrego correctamente", peñarol.Nombre);
            }
            else
            {
                Console.WriteLine("No se pudo agregar al equipo {0}", peñarol.Nombre);
            }
            if (torneoBasquet + olimpia)
            {
                Console.WriteLine("El equipo {0} se agrego correctamente", olimpia.Nombre);
            }
            else
            {
                Console.WriteLine("No se pudo agregar al equipo {0}", olimpia.Nombre);
            }
            #endregion
            //Mostrar Torneos y equipos
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(torneoFutbol.Mostrar());
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(torneoBasquet.Mostrar());
            Console.ReadKey();
            Console.Clear();
            //Juego
            #region GameFootball
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            #endregion

            #region GameBasketball
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            #endregion


        }
    }
}
