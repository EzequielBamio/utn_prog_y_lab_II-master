using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        #region Builders
        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        { }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }
        #endregion

        #region Properties
        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                if (value > 0)
                {
                    this.caballosDeFuerza = value;
                }
            }
        }
        #endregion

        #region Show
        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(this.MostrarInformacion());
            datos.Append($"#Caballos de fuerza: {this.CaballosDeFuerza}");

            return datos.ToString();
        }
        #endregion

        #region Operators
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.CaballosDeFuerza == a2.CaballosDeFuerza;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion

    }
}

