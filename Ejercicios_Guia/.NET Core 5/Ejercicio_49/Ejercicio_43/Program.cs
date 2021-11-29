using System;
using Entidades;
namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 36";
            //COMPETENCIAS
            Competencia<AutoF1> competencia = new Competencia<AutoF1>(5, 10, Competencia<AutoF1>.TipoCompetencia.F1);

            Competencia<MotoCross> competencia2 = new Competencia<MotoCross>(7, 12, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            //F1
            AutoF1 auto1 = new AutoF1(16, "ES");
            AutoF1 auto2 = new AutoF1(55, "FR");
            AutoF1 auto3 = new AutoF1(87, "XS");
            //MC
            MotoCross moto1 = new MotoCross(22, "FT");
            MotoCross moto2 = new MotoCross(45, "SA");
            MotoCross moto3 = new MotoCross(32, "JU");
            try
            {
                #region AddCompetitionVehicle
                #region F1
                if (competencia + auto1)
                {
                    Console.WriteLine($"El numero {auto1.Numero} se agrego a la competencia.");
                }
                else
                {
                    Console.WriteLine($"El numero {auto1.Numero} no se agrego a la competencia.");
                }
                if (competencia + auto2)
                {
                    Console.WriteLine($"El numero {auto2.Numero} se agrego a la competencia.");
                }
                else
                {
                    Console.WriteLine($"El numero {auto2.Numero} no se agrego a la competencia.");
                }
                if (competencia + auto3)
                {
                    Console.WriteLine($"El numero {auto3.Numero} se agrego a la competencia.");
                }
                else
                {
                    Console.WriteLine($"El numero {auto3.Numero} no se agrego a la competencia.");
                }
                #endregion
                #region MotoCroos
                if (competencia2 + moto1)
                {
                    Console.WriteLine($"El numero {moto1.Numero} se agrego a la competencia.");
                }
                else
                {
                    Console.WriteLine($"El numero {moto1.Numero} no se agrego a la competencia.");
                }
                if (competencia2 + moto2)
                {
                    Console.WriteLine($"El numero {moto2.Numero} se agrego a la competencia.");
                }
                else
                {
                    Console.WriteLine($"El numero {moto2.Numero} no se agrego a la competencia.");
                }
                if (competencia2 + moto3)
                {
                    Console.WriteLine($"El numero {moto3.Numero} se agrego a la competencia.");
                }
                else
                {
                    Console.WriteLine($"El numero {moto3.Numero} no se agrego a la competencia.");
                }
                #endregion
                #endregion

            }
            catch (CompetenciaNoDisponibleException e) 
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(competencia.MostrarDatos());
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(competencia2.MostrarDatos());
         
        }
    }
}
