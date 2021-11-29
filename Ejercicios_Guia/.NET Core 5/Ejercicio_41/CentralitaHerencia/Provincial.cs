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
        protected Franja franjaHoraria;

        #region Builders
        public Provincial(Franja miFranja, Llamada llamada) 
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
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
            informacion.AppendLine($"Franja horaria: {this.franjaHoraria}");
            informacion.AppendLine($"Costo de llamada provincial: {this.CostoLlamada}");

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
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
    }
}
