using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cR, short cP, Colores color, short cilindrada) : base(cR, cP, color) 
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada 
        {
            get 
            {
                return this.cilindrada;
            }
            set 
            {
                if(value > -1)
                {
                    this.cilindrada = value;
                }
            }

        }
        public string MostrarInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.Append("     -------[Moto]-------     ");
            informacion.Append(base.MostrarDatos());
            informacion.Append("\n[*] Cilindrada:     " + this.Cilindrada);

            return informacion.ToString();
        }
    }
}
