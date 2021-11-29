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
        private ESexo sexo;
        private int telefono;
        private EEstado estado;

        #region Builders
        
        public Cliente() 
        {
            this.estado = EEstado.AlDia;
        }

        public Cliente(int id, string nombre, string apellido, string direccion, ESexo sexo, int telefono) 
            : this()
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
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
        public EEstado Estado 
        {
            get 
            {
                return this.estado;
            }
            set 
            {
                this.estado = value;
            }
        }
        public ESexo Sexo 
        {
            get 
            {
                return this.sexo;
            }
            set 
            {
                this.sexo = value;
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
            datos.AppendLine($"Sexo: {this.Sexo}");
            datos.AppendLine($"Telefono: {this.telefono}");

            return datos.ToString();
        }

        #endregion

        #region Methods
        /// <summary>
        /// Simular que el cliente paga o no la factura(pedido)
        /// </summary>
        /// <returns>Si pago retorna true sino false</returns>
        public bool Pagar() 
        {
            if (new Random().Next(0, 2) == 1) 
            {
                
                return true;
            } 
            return false;
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

        public static bool operator ==(Cliente cliente, Factura factura) 
        {
            return cliente.id == factura.IdCliente;
        }
        public static bool operator !=(Cliente cliente, Factura factura)
        {
            return !(cliente == factura);
        }
        #endregion
    }
}
