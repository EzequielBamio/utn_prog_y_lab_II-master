using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1 
    {
        private List<IAcciones> lista;

        public Cartuchera1(List<IAcciones> lista) 
        {
            this.lista = lista;
        }

        public bool ProbarElementos() 
        {
            bool rtn = true;

            foreach (IAcciones item in this.lista) 
            {
                item.UnidadesDeEscritura -= 1;
                if (item.UnidadesDeEscritura < 0) 
                {
                    item.Recargar(20);
                    rtn = false;
                }
            }

            return rtn;
        }
    }
}
