using System;
using System.Collections.Generic;
using System.Globalization;
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
            Serializacion<Fabrica> serializacionFabrica = new Serializacion<Fabrica>();
            Serializacion<List<Factura>> serializacionFactura = new Serializacion<List<Factura>>();

            int idCliente;
            //cargamos los productos y clientes
            try
            {
                fabrica = serializacionFabrica.Leer("Fabrica.xml");
                fabrica.HistorialFacturas = serializacionFactura.LeerJson("historialFacturas.json");

                //mostramos ambas listas
                MostrarDatos(fabrica);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
            do
            {
                foreach (Cliente cliente in fabrica.Clientes)
                {
                    Console.WriteLine(cliente.Datos());
                }
                Console.WriteLine("Ingrese la id del cliente que desea ver sus facturas");
                int.TryParse(Console.ReadLine(), out idCliente);
                foreach (Factura f in fabrica.Facturas)
                {
                    if (idCliente == f.IdCliente)
                    {
                        Console.WriteLine(f.Recibo());
                    }
                }
                Console.WriteLine("Desea seguir viendo las facturas? s/n");
            } while (Console.ReadLine() == "s");
            Console.Clear();

            try
            {
                //creamos un nuevo producto
                Producto newProducto = new Producto("Test", 580, ETamanioEnvase.Chico, ETipoEnvase.Botella, EProducto.Gaseosa);
                //lo cargamos a la lista
                fabrica += newProducto;
                fabrica += newProducto;
            }
            catch (ProductoInvalidoException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
            Console.Clear();

            Estadisticas estadisticas = new Estadisticas(fabrica);
            estadisticas.FechaInicio = new DateTime(2021,11,16,0,00,00);
            estadisticas.FechaFinal = new DateTime(2021,11,22,0,00,00);

            //mostramos las estadisticas de la fabrica
            Console.WriteLine("Estados:");
            int deudor = estadisticas.CantidadEstados(EEstado.Deudor);
            int alDia = estadisticas.CantidadEstados(EEstado.AlDia);
            int total = alDia + deudor;
            if (total > 0)
            {
                Console.WriteLine($"Al dia: {((alDia * 100) / total)}%");
                Console.WriteLine($"Deudor: {((deudor * 100) / total)}%");
            }

            Console.WriteLine("Productos mas vendidos:");
            int cerveza = estadisticas.CantidadProducto(EProducto.Cerveza);
            int gaseosa = estadisticas.CantidadProducto(EProducto.Gaseosa);
            int total2 = gaseosa + cerveza;
            if (total2 > 0)
            {
                Console.WriteLine($"Gaseosas: {((gaseosa * 100) / total2)}%");
                Console.WriteLine($"Cervezas: {((cerveza * 100) / total2)}%");
            }

            Console.WriteLine("Tipos de envases mas vendidos:");
            int lata = estadisticas.CantidadEnvase(ETipoEnvase.Lata);
            int botella = estadisticas.CantidadEnvase(ETipoEnvase.Botella);
            int total3 = lata + botella;
            if (total3 > 0)
            {
                Console.WriteLine($"Botellas: {((botella * 100) / total3)}%");
                Console.WriteLine($"Latas: {((lata * 100) / total3)}%");
            }

            Console.WriteLine($"Dinero de las ventas: {estadisticas.DineroRecaudado()}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Test finalizado!");

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
