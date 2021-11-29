using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        #region Builders
        public Persona(string nombre) 
        {
            this.Nombre = nombre;
        }
        public Persona(long dni, string nombre) : this(nombre)
        {
            this.Dni = dni;
        }
        #endregion

        #region Properties
        public long Dni 
        {
            get 
            {
                return this.dni;
            }

            set 
            {
                this.dni = value;
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
        #endregion

        #region Show
        public string MostrarInformacion() 
        {
            StringBuilder datos = new StringBuilder();
            datos.Append($"[*] Nombre: {this.Nombre} \n[*] Dni: {this.Dni}");
            return datos.ToString();
        }
        #endregion


    }
}
