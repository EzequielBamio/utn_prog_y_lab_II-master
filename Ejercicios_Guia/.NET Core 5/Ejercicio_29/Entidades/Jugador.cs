using System;
using System.Text;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador() 
        {
            this.dni = 0;
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) 
            : this(dni, nombre, 0, 0)
        {
        
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        public float GetPromedioGoles() 
        {
            return (float)this.totalGoles / this.partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder informacion = new StringBuilder();

            informacion.Append("\n\n[*] Nombre: " + this.nombre);
            informacion.Append("\n[*] DNI: " + this.dni);
            informacion.Append("\n[*] Partidos jugados: " + this.partidosJugados);
            informacion.Append("\n[*] Total goles: " + this.totalGoles);
            informacion.Append("\n[*] Promedio goles: " + GetPromedioGoles());

            return informacion.ToString();
        }


        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
