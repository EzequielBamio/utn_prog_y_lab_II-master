using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que imprima por pantalla una pirámide como
            la siguiente:
            *
            ***
            *****
            *******
            *********
            El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
            ejemplo anterior la altura ingresada fue de 5.
            Nota: Utilizar estructuras repetitivas y selectivas.*/
            int altura;
            int ancho = 1;

            Console.WriteLine("INGRESE LA ALTURA DE LA PIRAMIDE: ");
            int.TryParse(Console.ReadLine(), out altura);
            for (int i = 0; i < altura; i++) {
                for (int j = 0; j < ancho; j++) {
                    Console.Write("*");
                }
                Console.WriteLine("");
                ancho += 2;
            }
            Console.ReadLine();
        }
    }
}
