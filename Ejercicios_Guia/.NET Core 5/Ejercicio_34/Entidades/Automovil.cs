using System;
using System.Text;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cR, short cP, Colores color, short cM, int cPer) : base(cR, cP, color)
        {
            this.CantidadMarchas = cM;
            this.CantidadPasajeros = cPer;

        }

        public short CantidadMarchas 
        {
            get 
            {
                return this.cantidadMarchas;
            }
            set 
            {
                if (value > -1) 
                {
                    this.cantidadMarchas = value;
                }
            }
        }
        public int CantidadPasajeros
        {
            get
            {
                return this.cantidadPasajeros;
            }
            set
            {
                if (value > -1)
                {
                    this.cantidadPasajeros = value;
                }
            }
        }

        public string MostrarInformacion() 
        {
            StringBuilder informacion = new StringBuilder();
            informacion.Append("     -------[Auto]-------     ");
            informacion.Append(base.MostrarDatos());
            informacion.Append("\n[*] Pasajeros:     " + this.CantidadPasajeros);
            informacion.Append("\n[*] Marchas:     " + this.CantidadMarchas);

            return informacion.ToString();
        }
    }
}
