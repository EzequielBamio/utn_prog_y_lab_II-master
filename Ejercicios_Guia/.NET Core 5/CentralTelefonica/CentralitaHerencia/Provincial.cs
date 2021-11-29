using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }
        private Franja franjaHoraria;
        #region Builders
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : this(miFranja, new Llamada(duracion, destino, origen))
        {
        }
        #endregion

        #region Propierties
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Show
        public override string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.Append(base.Mostrar());
            informacion.AppendLine($"Costo: {this.CostoLlamada} \nFranja horaria: {this.franjaHoraria}");

            return informacion.ToString();
        }
        #endregion

        #region Methods
        private float CalcularCosto() 
        {
            double valorFranja = 0.99; //Costo Franja_1

            if (this.franjaHoraria == Franja.Franja_2)
            {
                valorFranja = 1.25;
            }
            else 
            {
                if (this.franjaHoraria == Franja.Franja_3)
                {
                    valorFranja = 0.66;
                }
            }
            return this.Duracion * (float)valorFranja;
        }
        #endregion
    }
}
