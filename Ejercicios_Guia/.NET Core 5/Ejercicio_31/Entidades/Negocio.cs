using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        #region Builders
        private Negocio() 
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region Properties
        public Cliente Cliente
        {
            get 
            {
                return clientes.Dequeue();
            }
            set 
            {
                bool rtn = (this + value);
            }
        }

        public int ClientesPendientes 
        {
            get 
            {
                return clientes.Count();
            }
        }
        #endregion

        #region Operators
        public static bool operator ==(Negocio n, Cliente c) 
        {
            bool rtn = false;
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c) 
                {
                    rtn = true;
                    break;
                }
            }
            return rtn;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator +(Negocio n, Cliente c) 
        {
            bool rtn = false;
            if(n != c) 
            {
                n.clientes.Enqueue(c);
                rtn = true;
            }
            return rtn;
        }
        public static bool operator ~(Negocio n)
        {
            bool rtn = false;
            if (PuestoAtencion.Atender(n.Cliente)) 
            {
                rtn = true;
            }
            return rtn;
        }


        #endregion
    }
}
