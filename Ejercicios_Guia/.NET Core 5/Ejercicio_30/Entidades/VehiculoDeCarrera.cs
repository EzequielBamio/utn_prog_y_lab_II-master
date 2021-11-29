using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        #region Builders
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }
        #endregion

        #region Properties

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                if (value > -1)
                {
                    this.cantidadCombustible = value;
                }
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                if (value > -1)
                {
                    this.vueltasRestantes = value;
                }
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public short Numero 
        {
            get 
            {
                return this.numero;
            }
            set 
            {
                if(value > -1)
                {
                    this.numero = value;
                }
            }
        }
        public string Escuderia 
        {
            get 
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }
        #endregion

        #region Show
        public string MostrarInformacion()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append($"\n#Numero: {this.Numero} \n#Combustible: {this.CantidadCombustible} \n#En competencia: {this.EnCompetencia} \n#Vueltas restantes: {this.VueltasRestantes}\n");

            return datos.ToString();
        }
        #endregion

        #region Operators
        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia;
        }
        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
