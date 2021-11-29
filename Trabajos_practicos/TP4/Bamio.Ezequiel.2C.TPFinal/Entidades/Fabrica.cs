using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    public class Fabrica : IIdentificador<Cliente>
    {
        private List<Cliente> clientes;
        private List<Producto> productos;
        private List<Factura> facturas;
        private List<Factura> historialFacturas;
        private string nombre;
        private float dineroCaja;

        #region Builders
        private Fabrica()
        {
            this.clientes = new List<Cliente>();
            this.productos = new List<Producto>();
            this.Facturas = new List<Factura>();
            this.HistorialFacturas = new List<Factura>();
        }
        public Fabrica(string nombre)
            : this()
        {
            this.Nombre = nombre;
            this.dineroCaja = 0;
        }
        #endregion

        /// <summary>
        /// Cada propiedad devuelve su correspondiente atributo y asigna un valor
        /// </summary>
        #region Propierties
        public List<Cliente> Clientes
        {
            get
            {
                return this.clientes;
            }
            set
            {
                this.clientes = value;
            }
        }
        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
            set
            {
                this.productos = value;
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
        public float DineroCaja 
        {
            get
            {
                return this.dineroCaja;
            }
            set
            {
                this.dineroCaja += value;
            } 
        }
        public List<Factura> Facturas 
        {
            get
            {
                return this.facturas;
            }
            set 
            {
                this.facturas = value;
            }
        }
        [XmlIgnore]
        public List<Factura> HistorialFacturas { get => historialFacturas; set => historialFacturas = value; }
        #endregion



        #region Methods
        /// <summary>
        /// Agrega una factura a la lista Facturas y al HistorialFacturas
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="factura"></param>
        /// <returns></returns>
        public static Fabrica operator +(Fabrica fabrica, Factura factura) 
        {
            if (fabrica is not null && factura is not null)
            {
                factura.Id = fabrica.Facturas.Count;
                fabrica.Facturas.Add(factura);
                fabrica.HistorialFacturas.Add(factura);
                
            }

            return fabrica;
        }
        public static Fabrica operator -(Fabrica fabrica, Factura factura)
        {
            if (fabrica is not null && factura is not null)
            {
                fabrica.Facturas.Remove(factura);
                
            }

            return fabrica;
        }

        #region Operators Cliente
        public static Fabrica operator +(Fabrica fabrica, Cliente cliente)
        {
            if (fabrica != cliente)
            {
                fabrica.Clientes.Add(cliente);
            }
            else
            {
                throw new ClienteInvalidoException("Ese cliente ya existe en la lista.");
            }

            return fabrica;
        }
        public static Fabrica operator -(Fabrica fabrica, Cliente cliente)
        {
            if (fabrica == cliente)
            {
                fabrica.Clientes.Remove(cliente);
            }
            else
            {
                throw new ClienteInvalidoException("No se puede eliminar un cliente que no esta en la lista.");
            }

            return fabrica;
        }
        public static bool operator ==(Fabrica fabrica, Cliente cliente)
        {
            bool rtn = false;

            if (!(fabrica is null && cliente is null))
            {
                foreach (Cliente item in fabrica.Clientes)
                {
                    if (item.Id == cliente.Id)
                    {
                        rtn = true;
                        break;
                    }
                }
            }

            return rtn;
        }
        public static bool operator !=(Fabrica fabrica, Cliente cliente)
        {
            return !(fabrica == cliente);
        }
        #endregion

        #region Operators Producto
        public static Fabrica operator +(Fabrica fabrica, Producto producto)
        {
            if (fabrica != producto)
            {
                fabrica.Productos.Add(producto);
            }
            else
            {
                throw new ProductoInvalidoException("Ese producto ya existe en la lista.");
            }

            return fabrica;
        }
        public static Fabrica operator -(Fabrica fabrica, Producto producto)
        {
            if (fabrica == producto)
            {
                fabrica.Productos.Remove(producto);
            }
            else
            {
                throw new ProductoInvalidoException("No se puede eliminar un producto que no esta en la lista.");
            }

            return fabrica;
        }
        public static bool operator ==(Fabrica fabrica, Producto producto)
        {
            bool rtn = false;

            if (!(fabrica is null && producto is null))
            {
                foreach (Producto item in fabrica.Productos)
                {
                    if (item == producto)
                    {
                        rtn = true;
                        break;
                    }
                }
            }

            return rtn;
        }
        public static bool operator !=(Fabrica fabrica, Producto producto)
        {
            return !(fabrica == producto);
        }
        #endregion

        /// <summary>
        /// Elimina todas las facturas que tengan la id del cliente pasado por parametro. Tanto en la lista HistorialFacturas y Facturas
        /// </summary>
        /// <param name="cliente"></param>
        public void EliminarFacturasCliente(Cliente cliente) 
        {
            for (int i = 0; i < this.HistorialFacturas.Count; i++) 
            {
                if (cliente.Id == this.HistorialFacturas[i].IdCliente)
                {
                    this.HistorialFacturas.Remove(this.HistorialFacturas[i]);
                }
            }
            for (int i = 0; i < this.Facturas.Count; i++)
            {
                if (cliente.Id == this.Facturas[i].IdCliente)
                {
                    this.Facturas.Remove(this.Facturas[i]);
                }
            }        }
        public int GenerarId()
        {
            int id = 1;
            foreach (Cliente cliente in this.Clientes)
            {
                if (cliente.Id != id)
                {
                    break;
                }
                id++;
            }
            return id;
        }
        public int OrdenarPorId(Cliente cliente1, Cliente cliente2) 
        {
            if (cliente1.Id > cliente2.Id)
            {
                return 1;
            }
            else 
            {
                if (cliente1.Id < cliente2.Id)
                {
                    return -1;
                }
            }

            return 0;
        }
        #endregion

    }
}
