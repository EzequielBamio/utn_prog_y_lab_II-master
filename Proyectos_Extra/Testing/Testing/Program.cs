
using Entidades;
using System;
using System.Threading;
using Archivos;
using System.Collections.Generic;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string rutaCompleta = "Estudiantes.txt";
                List<Persona> listaPersonas = new List<Persona>(); 
                Serializador<List<Persona>> serializador = new Serializador<List<Persona>>();
                listaPersonas.Add(new Persona("Ezequiel", "Bamio", 20));
                listaPersonas.Add(new Persona("Rocio", "Jones", 21));

                serializador.Serializar(listaPersonas, rutaCompleta);
                //-------------------------------------------//
                List<Persona> listaPersonas2 = new List<Persona>();
                listaPersonas2 = serializador.Deserializar(rutaCompleta);
                foreach (Persona persona in listaPersonas2) 
                {
                    Console.WriteLine(persona.MostrarDatos());
                }

            }
            catch (Exception e) 
            {
                Console.WriteLine($"Algo salio mal. {e.Message}");
            }
            Console.ReadKey();
                
        }
        
    }
}
                /*FileManager file = new FileManager();
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string nombre = "//" + "Clase_Archivos";
                string extesion = ".txt";
                string texto = "Hola Mundo";

                file.EscribirArchivoTexto(ruta, nombre, extesion, texto, false);
                file.EscribirArchivoTexto(ruta, nombre, extesion, "Ezequiel Bamio", true);

                Console.WriteLine(file.LeerArchivoTexto(ruta, "//Hola", extesion));*/