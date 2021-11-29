using System;
using Entidades;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente(1136457588, "Franco");
            Cliente cliente2 = new Cliente(1155778811, "Pedro");
            Cliente cliente3 = new Cliente(1125487963, "Sandez");

            Negocio negocio1 = new Negocio("Jumbo");
            Console.WriteLine("Agregar Clientes");
            Console.WriteLine("----------------------------------------");

            if (negocio1 + cliente1)
            {
                Console.WriteLine("Se agrego el cliente, exitosamente!");
            }
            else 
            {
                Console.WriteLine("No se agrego el cliente");
            }
            if (negocio1 + cliente2)
            {
                Console.WriteLine("Se agrego el cliente, exitosamente!");
            }
            else
            {
                Console.WriteLine("No se agrego el cliente");
            }
            if (negocio1 + cliente3)
            {
                Console.WriteLine("Se agrego el cliente, exitosamente!");
            }
            else
            {
                Console.WriteLine("No se agrego el cliente");
            }
            Console.WriteLine("----------------------------------------");
            /*Console.WriteLine("Test clientes: ");
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine(negocio1.Cliente.Nombre);
            }*/
            
            if (~negocio1) 
            {
                Console.WriteLine("Numero del cliente atendido: {0}", cliente1.Numero);
            }
            Console.WriteLine(negocio1.ClientesPendientes);
            if (~negocio1)
            {
                Console.WriteLine("Numero del cliente atendido: {0}", cliente2.Numero);
            }
            Console.WriteLine(negocio1.ClientesPendientes);
            if (~negocio1)
            {
                Console.WriteLine("Numero del cliente atendido: {0}", cliente3.Numero);
            }

        }
    }
}
