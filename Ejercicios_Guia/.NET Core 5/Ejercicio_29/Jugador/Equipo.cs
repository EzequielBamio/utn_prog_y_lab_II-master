using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        #region Builders
        private Equipo() 
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        #endregion
       
        #region Operator
        public static bool operator +(Equipo e, Jugador j) 
        {
            bool rtn = false;
            bool jugadorExistente = false;
            if (e.jugadores.Count == 0)
            {
                e.jugadores.Add(j);
                rtn = true;
            }
            else
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    if (jugador == j)
                    {
                        jugadorExistente = true;
                    }
                }
                if (!jugadorExistente)
                {
                    if (e.jugadores.Count < e.cantidadDeJugadores)
                    {
                        e.jugadores.Add(j);
                        rtn = true;
                    }
                }
            }

            return rtn;
        }
        #endregion
    }
}
