using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace Entidades
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public string Nombre 
        {
            get 
            {
                return this.nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public static void GuardarBinary(Persona persona, string ruta)
        {
            using (Stream writer = new FileStream(ruta, FileMode.Create))
            {
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(writer, persona);
            }
        }
        public static Persona LeerBinary(string ruta)
        {
            using (Stream reader = new FileStream(ruta, FileMode.Open))
            {
                BinaryFormatter binary = new BinaryFormatter();
                Persona persona = (Persona)binary.Deserialize(reader);

                return persona;
            }

        }

        public static void Guardar(Persona persona, string ruta) 
        {
            using (StreamWriter writer = new StreamWriter(ruta))
            {
                string jsonString = JsonSerializer.Serialize(persona);
                writer.WriteLine(jsonString);
            }
        }

        public static Persona Leer(string ruta) 
        {
            using (StreamReader reader = new StreamReader(ruta))
            {
                Persona persona = JsonSerializer.Deserialize<Persona>(reader.ReadLine());

                return persona;
            }

        }

        public override string ToString()
        {
            return $"Nombre completo: {this.nombre} {this.apellido}";
        }


    }
}
