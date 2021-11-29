using System;
using Entidades;
namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 auto1 = new AutoF1(15, "Es");
            AutoF1 auto2 = new AutoF1(20, "Se");
            AutoF1 auto3 = new AutoF1(55, "Cf");
            Competencia competencia = new Competencia(10, 5);
            Console.WriteLine("### Agregar competidores. ###");
            #region Add
            if (competencia + auto1)
            {
                Console.WriteLine("El competidor se agrego exitosamente!");
            }
            else 
            {
                Console.WriteLine("El competidor no se agrego.");
            }
            if (competencia + auto2)
            {
                Console.WriteLine("El competidor se agrego exitosamente!");
            }
            else
            {
                Console.WriteLine("El competidor no se agrego.");
            }
            if (competencia + auto3)
            {
                Console.WriteLine("El competidor se agrego exitosamente!");
            }
            else
            {
                Console.WriteLine("El competidor no se agrego.");
            }
            #endregion
            /*Console.WriteLine("### Testing. ###");
            foreach (AutoF1 item in competencia.competidores) 
            {
                Console.WriteLine(item.MostrarDatos());
            }*/

            Console.WriteLine(competencia.MostrarDatos());

            if (competencia - auto2)
            {
                Console.WriteLine("Se elimino el competidor \n" + auto2.MostrarDatos());
            }
            else 
            {
                Console.WriteLine("El competidor sigue en competicion: \n" + auto2.MostrarDatos());

            }
        }
    }
}
