using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Grados;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit fahrenheit = new Fahrenheit(41);
            Kelvin kelvin = new Kelvin(888);
            Celsius celsius2 = new Celsius();
            Celsius celsius = new Celsius();
            Celsius totalCelsius = new Celsius();

            celsius2 = (Celsius)kelvin;
            celsius = (Celsius)fahrenheit;

            Console.WriteLine(celsius.GetGrados());
            Console.WriteLine(celsius2.GetGrados());

            totalCelsius = celsius + kelvin;

            Console.WriteLine(totalCelsius.GetGrados());


            Console.ReadLine();
        }
    }
}
