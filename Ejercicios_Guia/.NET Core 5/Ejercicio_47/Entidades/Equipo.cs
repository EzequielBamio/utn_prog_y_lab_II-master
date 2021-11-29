using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;
        public Equipo(string nombre, DateTime fechaCreacion) 
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre 
        {
            get 
            {
                return this.nombre;
            }
        }
        public DateTime FechaCreacion
        {
            get 
            {
                return this.fechaCreacion;
            }
        }

        public virtual string Ficha() 
        {
            StringBuilder ficha = new StringBuilder();
            ficha.AppendLine($"[{this.Nombre}] fundado el [{this.FechaCreacion.ToString("yyyy/MM/dd")}]");

            return ficha.ToString();
        }

        public static bool operator ==(Equipo e1, Equipo e2) 
        {
            return e1.Nombre == e2.Nombre && e1.FechaCreacion == e2.FechaCreacion;
        }
        public static bool operator !=(Equipo e1, Equipo e2) 
        {
            return !(e1 == e2);
        }

    }
}
