using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Entidades
{

    public class Producto
    {
        private string nombre;
        private int codigo;
        private int precio;
        private EProducto tipoProducto;
        private ETamanioEnvase tamanioEnvase;
        private ETipoEnvase tipoEnvase;
        private int stock;

        #region Builders
        public Producto()
        { }
        public Producto(int codigo, string nombre, int precio, ETamanioEnvase tamanioEnvase, ETipoEnvase tipoEnvase, EProducto tipoProducto, int stock)
        {

            this.Nombre = nombre;
            this.Codigo = codigo;
            this.Precio = precio;
            this.TamanioEnvase = tamanioEnvase;
            this.TipoEnvase = tipoEnvase;
            this.TipoProducto = tipoProducto;
            this.Stock = stock;
        }

        public Producto(string nombre, int precio, ETamanioEnvase tamanioEnvase, ETipoEnvase tipoEnvase, EProducto tipoProducto, int stock)
           : this(new Random().Next(10000, 99999), nombre, precio, tamanioEnvase, tipoEnvase, tipoProducto, stock)
        { }

        #endregion

        /// <summary>
        /// Cada propiedad devuelve su correspondiente atributo y asigna un valor
        /// </summary>
        #region Propierties
        public EProducto TipoProducto
        {
            get
            {
                return this.tipoProducto;
            }
            set
            {
                this.tipoProducto = value;
            }
        }
        public ETipoEnvase TipoEnvase
        {
            get
            {
                return this.tipoEnvase;
            }
            set
            {
                this.tipoEnvase = value;
            }
        }
        public ETamanioEnvase TamanioEnvase
        {
            get
            {
                return this.tamanioEnvase;
            }
            set
            {
                this.tamanioEnvase = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }
        public int Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }

        public int Stock { get => stock; set => stock = value; }
        #endregion

        #region Show
        /// <summary>
        /// Muestra los datos del producto
        /// </summary>
        /// <returns>Una cadena cargada con los datos.</returns>
        public string Datos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Producto: {this.TipoProducto}");
            datos.AppendLine($" Nombre: {this.Nombre}");
            datos.AppendLine($" Codigo: {this.codigo}");
            datos.AppendLine($" Precio: {this.Precio}");
            datos.AppendLine($" Tamaño: {this.tamanioEnvase}");
            datos.AppendLine($" Tipo: {this.TipoEnvase}");
            datos.AppendLine($" Stock: {this.Stock}");

            return datos.ToString();
        }
        #endregion

        #region Methods
        
        /// <summary>
        /// Dos productos son iguales, si su codigo son iguales
        /// </summary>
        /// <param name="producto1"></param>
        /// <param name="producto2"></param>
        /// <returns>true si son iguales</returns>
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            return producto1.codigo == producto2.codigo;
        }
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }
        public static Producto VerificarProducto(List<Producto> productos, Producto producto)
        {
            Producto rtn = null;
            foreach (Producto p in productos) 
            {
                if (p.Nombre == producto.Nombre && p.Precio == producto.Precio && p.TipoProducto == producto.tipoProducto && p.TipoEnvase == producto.TipoEnvase && p.TamanioEnvase == producto.TamanioEnvase) 
                {
                    rtn = p;
                    break;
                }
            }
            return rtn;
        }
        /// <summary>
        /// Busca el producto
        /// </summary>
        /// <param name="productos">Lista de productos</param>
        /// <param name="codigo">codigo del producto a encontrar</param>
        /// <returns>El producto encontrado o lanza una excepcion</returns>
        public static Producto BuscarPorId(List<Producto> productos, int codigo)
        {
            if (productos.Count > 0 && codigo >= 0)
            {
                foreach (Producto producto in productos)
                {
                    if (producto.codigo == codigo)
                    {
                        return producto;
                    }
                }
                throw new ProductoInvalidoException("No se encontro el producto");
            }
            throw new ProductoInvalidoException("La lista esta vacia o el codigo es erroneo");

        }
        public int CalcularPrecioTotal()
        {
            return this.Precio * this.Stock;
        }

        #endregion
    }
}
