using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caja
    {
        private List<string> filaClientes;

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public List<string> FilaClientes { get => this.filaClientes; }

        public void AtenderClientes() 
        {
            foreach (string cliente in this.filaClientes) 
            {
                Console.WriteLine($"{cliente} : {Task.CurrentId}");
                Thread.Sleep(2000);
            }
        }
    }
}
