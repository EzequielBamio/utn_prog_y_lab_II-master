using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*. Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
            multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
            operación que desea realizar (pulsando el caracter +, -, * ó /).
            El usuario decidirá cuándo finalizar el programa.
            Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
                a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
                operación matemática. El método devolverá el resultado de la operación.
                b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
                utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
                TRUE si el número es distinto de CERO*/
            char opcion;
            double numeroA;
            double numeroB;
            double resultado;
            do
            {
                Console.WriteLine("\n[*] INGRESE EL NUMERO A: ");
                double.TryParse(Console.ReadLine(), out numeroA);
                Console.WriteLine("\n[*] INGRESE EL NUMERO B: ");
                double.TryParse(Console.ReadLine(), out numeroB);

                Console.WriteLine("[+] SUMA");
                Console.WriteLine("[-] RESTA");
                Console.WriteLine("[*] MULTIPLICACION");
                Console.WriteLine("[/] DIVISON");
                Console.WriteLine("\n[0] SALIR");
                Console.WriteLine("\n[*] INGRESE OPCION: ");
                char.TryParse(Console.ReadLine(), out opcion);

                resultado = Calculadora.Calcular(numeroA, numeroB, opcion);
                if (resultado > -1001)
                {
                    Console.WriteLine("El resultado de la '{0}' es: {1}", opcion, resultado);
                }
                else 
                {
                    if (resultado == -1002)
                    {
                        Console.WriteLine("[ERROR] Hubo un error, no se puede dividir por cero, numero ingresado: A:'{0}' B:'{1}'", numeroA, numeroB);
                    }
                    else 
                    {
                        Console.WriteLine("[ERROR] Algo fallo.");
                    }
                }

            } while (opcion != '0');
        }
    }
}
