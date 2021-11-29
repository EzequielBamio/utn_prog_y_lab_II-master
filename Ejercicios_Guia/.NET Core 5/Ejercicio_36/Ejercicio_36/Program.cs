using System;
using Entidades;
namespace Ejercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 36";
            //competencias
            Competencia competencia = new Competencia(5, 10, Competencia.TipoCompetencia.F1);
            Competencia competencia2 = new Competencia(7, 12, Competencia.TipoCompetencia.MotoCross);
            //f1
            AutoF1 auto1 = new AutoF1(16, "ES");
            AutoF1 auto2 = new AutoF1(55, "FR");
            AutoF1 auto3 = new AutoF1(87, "XS");
            //MC
            MotoCross moto1 = new MotoCross(22, "FT");
            MotoCross moto2 = new MotoCross(45, "SA");
            MotoCross moto3 = new MotoCross(32, "JU");

            if (competencia + auto1)
            {
                Console.WriteLine($"El numero {auto1.Numero} se agrego a la competencia.");
            }
            else 
            {
                Console.WriteLine($"El numero {auto1.Numero} no se agrego a la competencia.");
            }
            if (competencia2 + auto2)
            {
                Console.WriteLine($"El numero {auto2.Numero} se agrego a la competencia.");
            }
            else
            {
                Console.WriteLine($"El numero {auto2.Numero} no se agrego a la competencia.");
            }
            if (competencia2 + moto1)
            {
                Console.WriteLine($"El numero {moto1.Numero} se agrego a la competencia.");
            }
            else
            {
                Console.WriteLine($"El numero {moto1.Numero} no se agrego a la competencia.");
            }




        }
    }
}
