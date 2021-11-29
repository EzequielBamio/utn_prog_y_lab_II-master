using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        private int id;
        private int idCliente;
        private List<Producto> productos;
        private DateTime fecha;


        public Factura()
        {
            this.productos = new List<Producto>();
        }
        public Factura(int idCliente)
            : this()
        {
            this.IdCliente = idCliente;
            this.Fecha = DateTime.Now;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// Muestra la factura sin los productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder factura = new StringBuilder();
            factura.AppendLine($"# Factura ({this.Id})#:\n");
            factura.AppendLine($"Cliente: {this.IdCliente}.");
            factura.AppendLine($"Fecha: {this.Fecha.ToString("dddd dd, MM, yyyy")}");

            return factura.ToString();
        }

        /// <summary>
        /// Muestra la factura con los productos cargados
        /// </summary>
        /// <returns></returns>
        public string Recibo() 
        {
            StringBuilder factura = new StringBuilder();
            if (this.Productos.Count > 0)
            {
                factura.AppendLine(this.ToString());

                factura.AppendLine($"Productos:\n");

                foreach (Producto producto in this.Productos)
                {
                    factura.AppendLine($"Codigo: {producto.Codigo}");
                    factura.AppendLine($"Nombre: {producto.Nombre}");
                    factura.AppendLine($"Precio: {producto.Precio}");
                    factura.AppendLine("-----------------------------");
                }
                factura.AppendLine($"Total: ${this.CalcularGastosTotal()}");
            }

            return factura.ToString();

        }

        /// <summary>
        /// Calcula la cantidad de dinero que gasto el cliente
        /// </summary>
        /// <returns>Los gastos totales</returns>
        public int CalcularGastosTotal()
        {
            int rtn = 0;

            foreach (Producto p in this.Productos)
            {
                rtn += p.Precio;
            }

            return rtn;
        }
        /// <summary>
        /// Agrega un producto a la lista de productos de Factura
        /// </summary>
        /// <param name="factura"></param>
        /// <param name="producto"></param>
        /// <returns>Factura con el producto cargado</returns>
        public static Factura operator +(Factura factura, Producto producto) 
        {
            if (factura is not null && producto is not null) 
            {
                factura.Productos.Add(producto);
            }
            return factura;
        }
    }
}
