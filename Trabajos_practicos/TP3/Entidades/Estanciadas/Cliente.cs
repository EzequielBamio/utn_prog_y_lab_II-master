using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private string direccion;
        private int telefono;
        private List<Producto> productosComprados;


        #region Builders
        
        public Cliente() 
        {
            this.productosComprados = new List<Producto>();
        }
        
        public Cliente(int id, string nombre, string apellido, string direccion, int telefono) 
            : this()
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }

        #endregion

        /// <summary>
        /// Cada propiedad devuelve su correspondiente atributo y asigna un valor
        /// </summary>
        #region Propierties
        public int Id 
        {
            get 
            {
                return this.id;
            }
            set 
            {
                if (value > 0)
                {
                    this.id = value;
                }
                else 
                {
                    throw new IdInvalidaException();
                }
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
        public string Apellido 
        {
            get 
            {
                return this.apellido;
            }
            set 
            {
                this.apellido = value;
            }
        }
        public string Direccion 
        {
            get 
            {
                return this.direccion;
            }
            set 
            {
                this.direccion = value;
            }
        }
        public int Telefono 
        {
            get 
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }

        public List<Producto> Productos
        {
            get
            {
                return this.productosComprados;
            }
            set
            {
                this.productosComprados = value;
            }
        }
        #endregion

        #region Show
        /// <summary>
        /// Muestra los datos del cliente
        /// </summary>
        /// <returns>Una cadena cargada con los datos</returns>
        public string Datos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Id: {this.id}");
            datos.AppendLine($"Nombre: {this.Nombre}");
            datos.AppendLine($"Apellido: {this.Apellido}");
            datos.AppendLine($"Direccion: {this.Direccion}");
            datos.AppendLine($"Telefono: {this.telefono}");

            return datos.ToString();
        }
        /// <summary>
        /// Recibo de los pedidos encargados por el cliente
        /// </summary>
        /// <returns>Una cadena cargada con las facturas</returns>
        public string Recibo()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"# Factura #:\n");
            if (this.Productos.Count > 0)
            {
                datos.AppendLine(this.Datos());

            
                datos.AppendLine($"Productos:\n");

                foreach (Producto producto in this.Productos)
                {
                    datos.AppendLine($"Codigo: {producto.Codigo}");
                    datos.AppendLine($"Nombre: {producto.Nombre}");
                    datos.AppendLine($"Precio: {producto.Precio}");
                    datos.AppendLine("-----------------------------");
                }
                datos.AppendLine($"Total: ${this.CalcularGastosTotal()}");
            }
            else 
            {
                datos.AppendLine("Este cliente no tiene facturas\n");
            }
            return datos.ToString();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Calcula la cantidad de dinero que gasto el cliente
        /// </summary>
        /// <returns>Los gastos totales</returns>
        public int CalcularGastosTotal() 
        {
            int rtn = 0;
            if (this.Productos.Count > 0)
            {
                foreach (Producto producto in this.Productos)
                {
                    rtn += producto.Precio;
                }
            }

            return rtn;
        }

        /// <summary>
        /// Busca el cliente dentro de la lista pasada por parametro mediante la id
        /// </summary>
        /// <param name="clientes">Lista de cliente para buscar el cliente</param>
        /// <param name="id">La id del cliente a encontrar</param>
        /// <returns>El cliente o un lanza un excepcion si no encuentra al cliente o si la lista no tiene clientes</returns>
        public static Cliente BuscarPorId(List<Cliente> clientes, int id) 
        {
            if (clientes.Count > 0 && id >= 0)
            {
                foreach (Cliente cliente in clientes)
                {
                    if (cliente.id == id)
                    {
                        return cliente;
                    }
                }
            }

            throw new ClienteInvalidoException("No se encontro al cliente");
        }

        #endregion
    }
}
