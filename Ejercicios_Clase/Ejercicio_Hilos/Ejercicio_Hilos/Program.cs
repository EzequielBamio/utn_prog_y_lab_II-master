using System;
using System.Threading;
using System.Threading.Tasks;
 
namespace Ejercicio_Hilos
{
    class Program
    {

        static void Main(string[] args)
        {
            //Action Barra;

        Console.WriteLine("Bienvenidos a la Barra. En un momento seran atendidos.");
            //Barra = Barman1;
            //Barra += Barman1;


            //Task atender1 = Task.Run(()=> {
            //    Console.WriteLine("Preparando un trago...");
            //    Thread.Sleep(10000);
            //    Console.WriteLine("trago terminado en caja " + Task.CurrentId);
            //});

            Task atender2 = Task.Run(Barman2);
            Console.WriteLine($"ID principal: {Task.CurrentId}");
            Console.WriteLine($"Tarea: {atender2.Id}");

            atender2.Wait();



        }

        static async void Barman1() 
        {
            Console.WriteLine("Preparando un trago...");
            Thread.Sleep(15000);
            Console.WriteLine("trago terminado en caja " + Task.CurrentId);
        }
        static void Barman2()
        {
            Console.WriteLine("Preparando un trago...");
            Thread.Sleep(7000);
            Console.WriteLine("trago terminado en caja " + Task.CurrentId);
        }


    }
}
