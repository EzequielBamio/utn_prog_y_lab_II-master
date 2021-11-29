using System;
using System.Collections.Generic;
using System.Text.Json;
using Entidades;
using IO;
namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creado por Bamio Ezequiel.";
            Fabrica fabrica = new Fabrica("Bamio");
            Serializacion<List<Cliente>> serializacionCliente = new Serializacion<List<Cliente>>();
            Serializacion<List<Producto>> serializacionProducto = new Serializacion<List<Producto>>();

            //cargamos los productos y clientes
            try
            {
                fabrica.Clientes = serializacionCliente.Leer("Clientes.json");
                fabrica.Productos = serializacionProducto.Leer("Productos.json");
                //mostramos ambas listas
                MostrarDatos(fabrica);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try 
            { 
                //creamos un nuevo producto
                Producto newProducto = new Producto("Bamio", 580, ETamanioEnvase.Chico, ETipoEnvase.Botella, EProducto.Gaseosa);
                //lo cargamos a la lista
                fabrica += newProducto;
                fabrica += newProducto;
            }
            catch (ProductoInvalidoException e)
            {
                Console.WriteLine(e.Message);
            }
            MostrarDatos(fabrica);

            try
            {
                //el cliente compra un producto
                fabrica.Clientes[1] += fabrica.Productos[1];
                fabrica.Productos.Remove(fabrica.Productos[1]);
                MostrarDatos(fabrica);
                //mostramos el recibo del cliente
                Console.WriteLine(fabrica.Clientes[1].Recibo());
                //mostramos las estadisticas de la fabrica
                Console.WriteLine(fabrica.TotalVentas());
                Console.WriteLine(fabrica.TotalGaseosas());
                Console.WriteLine(fabrica.TotalCervezas());
                Console.WriteLine(fabrica.CantidadCervezas());
                Console.WriteLine(fabrica.CantidadGaseosas());
                Console.WriteLine(fabrica.CantidadBotellas());
                Console.WriteLine(fabrica.CantidadLatas());
                Cliente clienteAux = fabrica.MejorCliente();
                Console.WriteLine($"Mejor cliente:\n {clienteAux.Datos()} \nTotal comprado: ${clienteAux.CalcularGastosTotal()}");
            }
            catch (ClienteInvalidoException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void MostrarDatos(Fabrica fabrica) 
        {
            foreach (Cliente cliente in fabrica.Clientes)
            {
                Console.WriteLine(cliente.Datos());
            }
            foreach (Producto producto in fabrica.Productos)
            {
                Console.WriteLine(producto.Datos());
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
