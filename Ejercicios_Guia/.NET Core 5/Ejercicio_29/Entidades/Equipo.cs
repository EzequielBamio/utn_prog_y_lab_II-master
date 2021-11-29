using System;
using System.Collections.Generic;
namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo() 
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidadDeJugadores, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

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
    }
}
