using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador();
            int conversion;
            long sumarLong;
            bool igualdadSumador;
            long result;
            string result2;
            result = sumador.Sumar(2, 2);
            result2 = sumador.Sumar("20", "20");
            sumador2.Sumar(2, 3);
            sumador2.Sumar("20", "21");
            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.WriteLine("Conversion:");
            conversion = (int)sumador;
            Console.WriteLine(conversion);
            conversion = (int)sumador2;
            Console.WriteLine(conversion);

            Console.WriteLine("SumarLong:");
            sumarLong = sumador + sumador2;
            Console.WriteLine(sumarLong);

            Console.WriteLine("Igualdad:");
            igualdadSumador = sumador | sumador2;
            Console.WriteLine(igualdadSumador);


            Console.ReadLine();

        }
    }
}
