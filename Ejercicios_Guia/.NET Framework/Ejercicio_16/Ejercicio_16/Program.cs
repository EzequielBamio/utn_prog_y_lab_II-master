using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumnos alumno1;
            alumno1 = new Alumnos("Bamio", 43388576, "Ezequiel");
            Alumnos alumno2;
            alumno2 = new Alumnos("Vega", 54488775, "Agustin");
            Alumnos alumno3;
            alumno3 = new Alumnos("Sandez", 41005587, "Pedro");

            alumno1.Estudiar(5, 8);
            alumno1.CalcularFinal();
            Console.WriteLine(alumno1.Mostrar());
            alumno2.Estudiar(4, 2);
            alumno2.CalcularFinal();
            Console.WriteLine(alumno2.Mostrar());
            alumno3.Estudiar(4, 5);
            alumno3.CalcularFinal();
            Console.WriteLine(alumno3.Mostrar());


            Console.ReadKey();
        }
    }
}
