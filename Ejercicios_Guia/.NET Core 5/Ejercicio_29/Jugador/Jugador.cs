using System;
using System.Text;

namespace Entiades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        #region Builders
        private Jugador()
        {
            this.dni = 0;
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre) 
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        #endregion

        #region Properties
        public int PartidosJugados 
        {
            get 
            {
                return this.partidosJugados;
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
        }
        public string Nombre 
        {
            get 
            {
                return this.nombre;
            }
            set 
            {
                this.nombre = value;
            }
        }
        public int Dni 
        {
            get 
            {
                return this.dni;
            }
            set 
            {
                if(dni > -1)
                {
                    this.dni = value;
                }
            }
        }
        #endregion

        #region Show
        public string MostrarDatos() 
        {
            StringBuilder informacion = new StringBuilder();

            informacion.Append("\n\n[*] Nombre: " + this.Nombre);
            informacion.Append("\n[*] DNI: " + this.Dni);
            informacion.Append("\n[*] Partidos jugados: " + this.PartidosJugados);
            informacion.Append("\n[*] Total goles: " + this.TotalGoles);
            informacion.Append("\n[*] Promedio goles: " + this.PromedioGoles);

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
