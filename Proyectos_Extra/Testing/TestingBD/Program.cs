using System;
using System.Collections.Generic;
using ConexionBD;
namespace TestingBD
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProductosDAO productosDAO = new ProductosDAO();
                List<Producto> listProductos = new List<Producto>();
                //Producto producto = new Producto(1, "Sprite", "Gaseosa Light", "YTUGJA23", 155);
                //Producto producto2 = new Producto(1, "Pan", "Elaborado 2021", "", 120);
                //productosDAO.InsertarProducto(producto);
                //productosDAO.EditarProducto(producto, 5);
                //productosDAO.EliminarProducto(6);
                listProductos = productosDAO.ListarProductos();
                foreach (Producto item in listProductos)
                {
                    Console.WriteLine(item.Mostrar());
                }
                //Producto producto = productosDAO.ListarProducto(2);
                //Console.WriteLine(producto.Mostrar());

            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
