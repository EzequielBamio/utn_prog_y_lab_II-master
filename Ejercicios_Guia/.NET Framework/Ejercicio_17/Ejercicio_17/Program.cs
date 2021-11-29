using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibu = "";
            Boligrafo boligrafo1 = new Boligrafo(50, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);
            Console.WriteLine(boligrafo1.GetTinta());
            Console.WriteLine(boligrafo2.GetTinta());

             if (boligrafo1.Pintar(-12, out dibu))
             {
                Console.ForegroundColor = boligrafo1.GetColor();
                Console.WriteLine(dibu);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(boligrafo1.GetTinta());
             }

            if (boligrafo2.Pintar(-5, out dibu)) 
            {
                Console.ForegroundColor = boligrafo2.GetColor();
                Console.WriteLine(dibu);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(boligrafo2.GetTinta());
            }




            Console.ReadKey();
        }
    }
}
