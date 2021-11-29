using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        #region Builders
        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        { }
        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }
        #endregion

        #region Properties
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                if (value > 0)
                {
                    this.cilindrada = value;
                }
            }
        }
        #endregion

        #region Show
        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(this.MostrarInformacion());
            datos.Append($"#Cilindrada: {this.Cilindrada}");

            return datos.ToString();
        }
        #endregion

        #region Operators
        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return m1.Cilindrada == m2.Cilindrada;
        }
        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
        #endregion
    }
}
