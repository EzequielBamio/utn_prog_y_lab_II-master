using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Billetes;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(10);
            Euro euro = new Euro(20);
            Pesos pesos = new Pesos(9);

            Dolar pagoDolar = new Dolar();
            Euro pagoEuro = new Euro();
            Pesos pagoPesos = new Pesos();
            Pesos doublePesos = new Pesos();

            double pDolar;
            double pEuro;
            double pPesos;

            pagoEuro = (Euro) dolar;
            pEuro = pagoEuro.GetCantidad();
            Console.WriteLine("Dolar: ${0} - Euro: ${1}", dolar.GetCantidad(), Math.Round(pEuro, 2));

            pagoPesos = (Pesos)dolar;
            pPesos = pagoPesos.GetCantidad();
            Console.WriteLine("Dolar: ${0} - Pesos: ${1}", dolar.GetCantidad(), Math.Round(pPesos, 2));



            Console.ReadLine();
        }
    }
}
