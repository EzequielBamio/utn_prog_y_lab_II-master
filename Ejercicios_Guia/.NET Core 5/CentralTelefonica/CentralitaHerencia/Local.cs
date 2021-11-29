using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        private float costo;

        #region Builders
        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo) : this(new Llamada(duracion, destino, origen), costo)
        {
        }
        #endregion

        #region Propierties
        public float CostoLlamada 
        {
            get 
            {
                return this.costo;
            }
        }
        #endregion

        #region Show
        public override string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.Append(base.Mostrar());
            informacion.AppendLine($"Costo: {this.CostoLlamada}");

            return informacion.ToString();
        }
        #endregion

        #region Methods
        private float CalcularCosto()
        {
            return this.Duracion * this.CostoLlamada;
        }
        #endregion
    }


}

