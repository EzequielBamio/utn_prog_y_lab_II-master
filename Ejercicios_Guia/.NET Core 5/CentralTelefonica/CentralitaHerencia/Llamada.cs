using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        public enum TipoLlamada { Local , Provincial, Todas }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Builders
        public Llamada(float duracion, string nroDestino, string nroOrigen) 
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Propierties
        public float Duracion 
        {
            get 
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        #region Show
        public virtual string Mostrar() 
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Duracion: {this.Duracion} \nNro destino: {this.NroDestino} \nNro origen: {this.nroOrigen}");
            return informacion.ToString();
        }
        #endregion

        #region Methods
        public static int OrdernarPorDuracion(Llamada l1, Llamada l2) 
        {
            int rtn = 0;
            if (l1.duracion > l2.duracion) 
            {
                rtn = 1;
            }
            if (l1.duracion < l2.duracion)
            {
                rtn = -1;
            }

            return rtn;
        }
        #endregion
    }
}
