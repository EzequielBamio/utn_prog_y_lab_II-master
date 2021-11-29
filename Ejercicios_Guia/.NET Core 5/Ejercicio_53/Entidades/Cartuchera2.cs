using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera2
    {
        private List<IAcciones> listaLapiz;
        private List<IAcciones> listaBoligrafo;
        public Cartuchera2(List<IAcciones> listaLapiz, List<IAcciones> listaBoligrafo)
        {
            this.listaLapiz = listaLapiz;
            this.listaBoligrafo = listaBoligrafo;

        }

        public bool ProbarElementos()
        {
            bool rtn = true;

            foreach (IAcciones item in this.listaLapiz)
            {
                item.UnidadesDeEscritura -= 1;
                if (item.UnidadesDeEscritura < 0)
                {
                    item.Recargar(20);
                    rtn = false;
                }
            }

            foreach (IAcciones item in this.listaBoligrafo)
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
