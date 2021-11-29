using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cR, short cP, Colores color, short cM, int pC) : base(cR, cP, color)
        {
            this.CantidadMarchas = cM;
            this.pesoCarga = pC;
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

        public int PesoCarga
        {
            get
            {
                return this.pesoCarga;
            }
            set
            {
                if (value > -1)
                {
                    this.pesoCarga = value;
                }
            }
        }
        public string MostrarInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.Append("     -------[Camion]-------     ");
            informacion.Append(base.MostrarDatos());
            informacion.Append("\n[*] Marchas:     " + this.CantidadMarchas);
            informacion.Append("\n[*] Peso carga:     " + this.PesoCarga);

            return informacion.ToString();
        }

    }
}
