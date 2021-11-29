using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Torneo<T>
        where T : Equipo
    {
        private string nombre;
        private List<T> equipos;

        private Torneo() 
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public string JugarPartido 
        {
            get 
            {
                Random random = new Random();
                int cantidadEquipos = this.equipos.Count;
                int equipo1 = random.Next(0, cantidadEquipos);
                int equipo2;
                T t1 = this.equipos[equipo1];
                do
                {
                    equipo2 = random.Next(0, cantidadEquipos);

                } while (equipo1 == equipo2);

                T t2 = this.equipos[equipo2];

                return CalcularPartido(t1, t2);
                
            }
        }
        private string CalcularPartido(T t1, T t2) 
        {
            Random random = new Random();
            StringBuilder resultado = new StringBuilder();
            int resultadoT1 = random.Next(0, 6);
            int resultadoT2 = random.Next(0, 6);

            resultado.AppendLine($"{t1.Nombre} [{resultadoT1}] - [{resultadoT2}] {t2.Nombre}");

            return resultado.ToString();
        }
        public string Mostrar() 
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"### TORNEO {this.nombre} ###\n");
            foreach (T item in this.equipos)
            {
                datos.AppendLine(item.Ficha());
                
            }

            return datos.ToString();
        }
        public static bool operator +(Torneo<T> ts, T e) 
        {
            bool rtn = false;
            if (ts != e) 
            {
                ts.equipos.Add(e);
                rtn = true;
            }

            return rtn;
        }
        public static bool operator ==(Torneo<T> ts, T e) 
        {
            bool rtn = false;
            foreach (T item in ts.equipos) 
            {
                if (item == e) 
                {
                    rtn = true;
                    break;
                }
            }
            return rtn;
        }
        public static bool operator !=(Torneo<T> ts, T e)
        {
            return !(ts == e);
        }
    }
}
