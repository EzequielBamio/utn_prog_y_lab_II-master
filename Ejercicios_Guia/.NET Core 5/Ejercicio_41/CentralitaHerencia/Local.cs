using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        #region Builders
        public Local(Llamada llamada, float costo) 
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }
        public Local(string origen, float duracion, string destino, float costo) 
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        #endregion

        #region Propierties
        public override float CostoLlamada 
        {
            get 
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Show
        protected override string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine(base.Mostrar());
            informacion.AppendLine($"Costo de llamada local: {this.CostoLlamada}");

            return informacion.ToString();
        }
        #endregion

        #region Methods
        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }
        public override bool Equals(object obj)
        {
            return obj is Local;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }


}

