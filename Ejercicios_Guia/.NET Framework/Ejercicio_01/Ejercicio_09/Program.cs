using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
            una pirámide como la siguiente:
                *
               ***
              *****
             *******
            *********
            Nota: Utilizar estructuras repetitivas y selectivas.*/
            int altura;
            int ancho = 1;
            int espacio; 
            Console.WriteLine("INGRESE LA ALTURA DE LA PIRAMIDE: ");
            int.TryParse(Console.ReadLine(), out altura);
            espacio = altura;
            for (int i = 0; i < altura; i++)
            {
                for (int x = espacio; x > 0; x--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < ancho; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                espacio--;
                ancho += 2;
            }
            Console.ReadLine();
        }
    }
}
