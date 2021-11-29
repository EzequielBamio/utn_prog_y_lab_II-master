using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Fabrica : IEstadisticas, IIdentificador<Cliente>
    {
        private List<Cliente> clientes;
        private List<Producto> productos;
        private List<Producto> productosVendidos;
        private string nombre;

        #region Builders
        public Fabrica()
        {
            this.clientes = new List<Cliente>();
            this.productos = new List<Producto>();
            this.productosVendidos = new List<Producto>();
        }
        public Fabrica(string nombre)
            : this()
        {
            this.Nombre = nombre;

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
        public List<Producto> ProductosVendidos
        {
            get
            {
                return this.productosVendidos;
            }
            set
            {
                this.productosVendidos = value;
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
        #endregion

        #region Methods

        #region IEstadisticas
        private int CalcularTotal(List<Producto> productos) 
        {
            int total = 0;
            foreach (Producto producto in productos)
            {
                total += producto.Precio;
            }
            return total;
        }
        public int TotalVentas()
        {
            return this.CalcularTotal(this.productosVendidos);
        }
        public int TotalEnMercaderia()
        {
            return this.CalcularTotal(this.Productos);
        }
        public int TotalGaseosas()
        {
            int totalVentasGaseosas = 0;
            foreach (Producto producto in this.ProductosVendidos)
            {
                if (producto.TipoProducto is EProducto.Gaseosa)
                {
                    totalVentasGaseosas += producto.Precio;
                }
            }

            return totalVentasGaseosas;
        }

        public int TotalCervezas()
        {
            int totalVentasCervezas = 0;
            foreach (Producto producto in this.ProductosVendidos)
            {
                if (producto.TipoProducto is EProducto.Cerveza)
                {
                    totalVentasCervezas += producto.Precio;
                }
            }

            return totalVentasCervezas;
        }

        public int CantidadGaseosas()
        {
            int cantidadGaseosas = 0;
            foreach (Producto producto in this.Productos)
            {
                if (producto.TipoProducto is EProducto.Gaseosa)
                {
                    cantidadGaseosas++;
                }
            }

            return cantidadGaseosas;
        }

        public int CantidadCervezas()
        {
            int cantidadCervezas = 0;
            foreach (Producto producto in this.Productos)
            {
                if (producto.TipoProducto is EProducto.Cerveza)
                {
                    cantidadCervezas++;
                }
            }

            return cantidadCervezas;
        }

        public int CantidadLatas()
        {
            int cantidadLatas = 0;
            foreach (Producto producto in this.Productos)
            {
                if (producto.TipoEnvase is ETipoEnvase.Lata)
                {
                    cantidadLatas++;
                }
            }

            return cantidadLatas;
        }

        public int CantidadBotellas()
        {
            int cantidadBotellas = 0;
            foreach (Producto producto in this.Productos)
            {
                if (producto.TipoEnvase is ETipoEnvase.Botella)
                {
                    cantidadBotellas++;
                }
            }

            return cantidadBotellas;
        }
        public Cliente MejorCliente()
        {
            if (this.Clientes.Count > 0)
            {
                Cliente cliente = this.Clientes[0];
                foreach (Cliente cliente1 in this.Clientes)
                {
                    foreach (Cliente cliente2 in this.Clientes)
                    {
                        if (cliente1.CalcularGastosTotal() > cliente2.CalcularGastosTotal())
                        {
                            cliente = cliente1;
                        }
                        else
                        {
                            if (cliente1.CalcularGastosTotal() > cliente2.CalcularGastosTotal())
                            {
                                cliente = cliente2;
                            }
                        }
                    }
                }

                return cliente;
            }
            else 
            {
                throw new ClienteInvalidoException("La lista no tiene clientes cargados.");
            }

        }
        #endregion

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
