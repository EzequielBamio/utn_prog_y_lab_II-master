using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
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
        public abstract float CostoLlamada 
        {
            get;
        }
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
        protected virtual string Mostrar() 
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Duracion de llamada: {this.Duracion}");
            informacion.AppendLine($"NNumero origen: {this.NroOrigen}");
            informacion.AppendLine($"Numero destino: {this.NroDestino}");

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

        public static bool operator ==(Llamada l1, Llamada l2) 
        {
            return l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen;
        }
        public static bool operator !=(Llamada l1, Llamada l2) 
        {
            return !(l1 == l2);
        }
        #endregion
    }
}
