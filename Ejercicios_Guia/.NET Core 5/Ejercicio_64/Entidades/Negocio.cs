using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Negocio(Caja c1, Caja c2)
        {
            this.clientes = new List<string>();
            this.caja1 = c1;
            this.caja2 = c2;
        }

        public Caja Caja1 { get => this.caja1; }
        public Caja Caja2 { get => this.caja2; }
        public List<string> Clientes { get => this.clientes; }

        public void AsignarCaja() 
        {
            Console.WriteLine("Asignado cajas...");
            foreach (string cliente in this.Clientes) 
            {
                if (this.Caja1.FilaClientes.Count > this.Caja2.FilaClientes.Count)
                {
                    this.Caja1.FilaClientes.Add(cliente);
                }
                else 
                {
                    this.Caja2.FilaClientes.Add(cliente);
                }
                Thread.Sleep(1000);
            }
        }


    }
}
