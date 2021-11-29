using System;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numerosIngresados = new int[20];
            int auxNum;
            Random random = new Random(); 
            for (int i = 0; i < 20; i++) 
            {
                auxNum = random.Next(-20,10);
                if (auxNum != 0)
                {
                    numerosIngresados[i] = auxNum;
                }
            }

            foreach (int numero in numerosIngresados) 
            {
                Console.WriteLine("Vector original: {0}", numero);
            }

            Console.WriteLine("\n-----------------------------\n");
            Array.Sort(numerosIngresados);
            Array.Reverse(numerosIngresados);
            
            foreach (int numero in numerosIngresados)
            {
                if(numero > -1)
                {
                    Console.WriteLine("Vector positivo, decreciente: {0}", numero);
                }
            }

            Console.WriteLine("\n-----------------------------\n");
            Array.Sort(numerosIngresados);

            foreach (int numero in numerosIngresados)
            {
                if (numero < 0)
                {
                    Console.WriteLine("Vector negativo, creciente: {0}", numero);
                }
            }

            Console.ReadKey();
        }
    }
}
