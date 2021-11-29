using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
namespace Ejercicios_Delegados
{
    class Program
    {

        public delegate string ResultSearch();


        static void Main(string[] args)
        {

            List<Persona> people = new List<Persona>()
            {
                new Persona(12, "ezequiel", "bamio", 20),
                new Persona(25, "rocio", "perez", 21),
                new Persona(41, "federico", "padela", 29),
                new Persona(22, "pedro", "sartu", 23),
                new Persona(56, "rodrigo", "aries", 25)
            };



            people.ForEach((p) => Console.WriteLine(p.ToString()));
            do
            {
                Console.Write("Search: ");
                string key = Console.ReadLine();
                List<Persona> rtnPersonas = people.FindAll((p) => p.Nombre.Contains(key) || p.Apellido.Contains(key));

                if (rtnPersonas.Count > 0)
                    rtnPersonas.ForEach((p) => Console.WriteLine(p.ToString()));
                else
                    Console.WriteLine("It was not found person.");

                Console.WriteLine("try again? yes/not");
            } while (Console.ReadLine() != "no");



            //Persona rtnPersona = personas.Find((p) => p.Nombre.Contains("e"));
            //MostrarDatos mostrar = rtnPersona.ToString;

            //Console.WriteLine("Primera persona con 'E' " + mostrar.Invoke());
            //Console.WriteLine("--------------------------------------------------");
            //List<Persona> rtnPersonas = personas.FindAll((p) => p.Nombre.Contains("e") || p.Edad < 22);
            //rtnPersonas.ForEach((p) => Console.WriteLine(p.ToString()));


        }
    }
}
