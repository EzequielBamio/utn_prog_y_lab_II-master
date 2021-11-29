using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{

    public class PuestoAtencion
    {
        public enum Puesto { Caja1, Caja2 }

        private static int numeroActual;
        private Puesto puesto;

        #region Builders
        private PuestoAtencion() 
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }


        #endregion

        #region Properties
        public static int NumeroActual 
        {
            get 
            {
                return numeroActual++;
            }
        }
        #endregion

        #region Methods
        public static bool Atender(Cliente cli) 
        {
            bool rtn = true;
            Thread.Sleep(5000);
            return rtn;
        }
        #endregion
    }
}
