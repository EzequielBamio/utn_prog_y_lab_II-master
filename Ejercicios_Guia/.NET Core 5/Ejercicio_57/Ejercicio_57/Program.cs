using System;
using Entidades;
namespace Ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Persona persona = new Persona("Ezequiel", "Bamio");
                //Persona.Guardar(persona, "");
                //Persona persona2 = Persona.Leer("");
                //Console.WriteLine("Listo");
                //Console.WriteLine(persona2.ToString());

                Persona persona = new Persona("Ezequiel", "Bamio");
                Persona.GuardarBinary(persona, "Test.bin");
                Console.WriteLine("Listo Guardar");
                Persona persona2 = Persona.LeerBinary("Test.bin");
                Console.WriteLine("Listo Leer");
                Console.WriteLine(persona2.ToString());

            }
            catch (ArgumentException e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
