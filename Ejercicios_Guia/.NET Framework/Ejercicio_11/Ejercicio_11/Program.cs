using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
            siguiente firma: bool Validar(int valor, int min, int max):
            a. valor: dato a validar
            b. min y max: rango en el cual deberá estar la variable valor.
            Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
            anteriormente que esten dentro del rango -100 y 100.
            Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
            Nota: Utilizar variables escalares, NO utilizar vectores.*/
            int numeroIngresado;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            int acumuladorNumeros = 0;
            int promedio;
            int rangoMinimo = -100;
            int rangoMaximo = 100;
            int cantidadNumeros = 10;

            Console.WriteLine("Ejercicio_11");
            

            for (int i = 0; i < cantidadNumeros; i++) 
            {
                Console.WriteLine("[*] Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out numeroIngresado);

                while (!Validacion.Validar(numeroIngresado, rangoMinimo, rangoMaximo))
                {
                    Console.WriteLine("[-] ERROR: Reingrese un numero: ");
                    int.TryParse(Console.ReadLine(), out numeroIngresado);
                }
                if (i == 0)
                {
                    numeroMaximo = numeroIngresado;
                    numeroMinimo = numeroIngresado;
                }
                acumuladorNumeros += numeroIngresado;
                numeroMaximo = Math.Max(numeroMaximo, numeroIngresado);
                numeroMinimo = Math.Min(numeroMinimo, numeroIngresado);
            }
            Console.WriteLine("El numero Mayor es: {0}", numeroMaximo);
            Console.WriteLine("El numero Menor es: {0}", numeroMinimo);
            promedio = Calcular.promedio(acumuladorNumeros, cantidadNumeros);
            Console.WriteLine("El promedio es: {0}", promedio);

            Console.ReadLine();
        }
    }
}
