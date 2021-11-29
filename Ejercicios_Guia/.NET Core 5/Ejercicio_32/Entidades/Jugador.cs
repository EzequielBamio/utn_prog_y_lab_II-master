using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        #region Builders
        public Jugador(int dni, string nombre) : base(dni, nombre)
        {
            
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.TotalGoles = totalGoles;
            this.PartidosJugados = totalPartidos;
        }
        #endregion

        #region Properties
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }

            set 
            {
                this.partidosJugados = value;
            }
        }
        public float PromedioGoles
        {
            get
            {
                return (float)this.TotalGoles / this.PartidosJugados;
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set 
            {
                this.totalGoles = value;
            }
        }
        #endregion

        #region Show
        public string MostrarDatos()
        {
            StringBuilder informacion = new StringBuilder();

            informacion.Append(this.MostrarInformacion());
            informacion.AppendLine($"\n[*] Partidos jugados: {this.PartidosJugados} \n[*] Total goles: {this.TotalGoles} \n[*] Promedio goles: {this.PromedioGoles} ");
            return informacion.ToString();
        }
        #endregion

        #region Operators
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}
