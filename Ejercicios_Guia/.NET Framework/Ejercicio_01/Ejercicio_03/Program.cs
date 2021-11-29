using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
            (excluido el mismo) que son divisores del número.
            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            Escribir una aplicación que encuentre los 4 primeros números perfectos.
            Nota: Utilizar estructuras repetitivas y selectivas.*/

            int numeroPerfecto = 7;
            int acu_Divisores = 0 ;
            int con_Auxiliar = 0;

            while (con_Auxiliar < 4) {
                //buscar divisores
                for (int i = 1; i < numeroPerfecto; i++)
                {
                    if (numeroPerfecto % i == 0)
                    {
                        acu_Divisores += i;
                        if (acu_Divisores == numeroPerfecto)
                        {
                            Console.WriteLine("EL NUMERO PERFECTO ES {0}", numeroPerfecto);
                            con_Auxiliar++;
                        }
                    }
                }
                //fin buscar divisores
                acu_Divisores = 0;
                numeroPerfecto++;
            }
            Console.ReadLine();
        }
    }
}
