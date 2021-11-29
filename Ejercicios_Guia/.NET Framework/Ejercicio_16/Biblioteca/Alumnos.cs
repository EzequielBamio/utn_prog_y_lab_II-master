using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Alumnos
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private string apellido;
        private int legajo;
        private string nombre;

        public Alumnos(string apellido, int legajo, string nombre) 
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        public void CalcularFinal() 
        {
            float auxNotaFinal = -1;
            if (nota1 >= 4 && nota2 >= 4) 
            {
                Random random = new Random();
                auxNotaFinal = random.Next(4,10);
            }

            this.notaFinal = auxNotaFinal;
        }
        public void Estudiar(byte notaUno, byte notaDos) 
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar() 
        {
            string mensaje;
            mensaje = "Nombre: " + this.nombre + "\nApellido: " + this.apellido + "\nLegajo: " + this.legajo + "\nNota1: " + this.nota1 + "\nNota2: " + this.nota2 + "\nAlumno desaprobado\n";
            if (notaFinal != -1) 
            {
                mensaje = "Nombre: " + this.nombre + "\nApellido: " + this.apellido + "\nLegajo: " + this.legajo + "\nNota1: " + this.nota1 + "\nNota2: " + this.nota2 + "\nNota final: " + this.notaFinal + "\n";
            }
            return mensaje;
        }
    }
}
