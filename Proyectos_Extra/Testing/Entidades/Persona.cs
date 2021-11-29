using System;
using System.Collections.Generic;
using System.Text;
namespace Entidades
{
    public class Persona
    {
        private int edad;
        private string nombre;
        private string apellido;

        public Persona() 
        {
        
        }
        public Persona(string nombre, string apellido) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Persona(string nombre, string apellido, int edad)
            : this(nombre, apellido)
        {
            this.Edad = edad;        
        }

        public string Nombre 
        {
            get 
            {
                return this.nombre;
            }
            set 
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public int Edad 
        {
            get 
            {
                return this.edad;
            }
            set 
            {
                if (this.ValidarEdad(value))
                {
                    this.edad = value;
                }else 
                {
                    throw new LimiteEdadExcepcion("La edad ingresada es invalida");   
                }

            }
        }

        public string MostrarDatos() 
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Nombre completo: {this.Apellido} {this.Nombre}");
            datos.AppendLine($"Edad: {this.Edad}");

            return datos.ToString();
        }

        private bool ValidarEdad(int edad) 
        {
            return edad > 17;
        }
    }
}
