using System;
using System.Threading.Tasks;
using Entidades;
namespace Ejercicio_64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            caja1.FilaClientes.Add("Federico");
            caja1.FilaClientes.Add("Romeo");
            caja1.FilaClientes.Add("Rocio");
            caja1.FilaClientes.Add("Sandro");

            caja2.FilaClientes.Add("Carlos");
            caja2.FilaClientes.Add("Candela");
            caja2.FilaClientes.Add("Pedro");
            caja2.FilaClientes.Add("Rocio");


            Negocio negocio = new Negocio(caja1, caja2);
            negocio.AsignarCaja();
            Task asignarCaja1 = new Task(caja1.AtenderClientes);
            Task asignarCaja2 = new Task(caja2.AtenderClientes);

            asignarCaja1.Start();
            asignarCaja2.Start();



            asignarCaja1.Wait();
            asignarCaja2.Wait();

            Console.WriteLine("No hay mas clientes.");

        }
    }
}
