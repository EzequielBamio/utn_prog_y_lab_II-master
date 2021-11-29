using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
            mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
            Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/
            double numeroIngresado;
            double numeroAlCuadrado;
            double numeroAlCubo;

            Console.WriteLine("INGRESE UN NUMERO: ");
            double.TryParse(Console.ReadLine(), out numeroIngresado);

            if (numeroIngresado > 0)
            {
                numeroAlCuadrado = Math.Pow(numeroIngresado, 2);
                numeroAlCubo = Math.Pow(numeroIngresado, 3);
                Console.WriteLine("NUMERO: {0}, EL CUADRADO: {1}, EL CUBO: {2}", numeroIngresado, numeroAlCuadrado, numeroAlCubo);
            }
            else {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
            Console.ReadLine();
        }
    }
}
