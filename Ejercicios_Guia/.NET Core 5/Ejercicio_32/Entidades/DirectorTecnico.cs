using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        #region Builders
        public DirectorTecnico(string nombre) : base(nombre) 
        { }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre) 
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        #endregion

        #region Show
        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append(this.MostrarInformacion());
            datos.AppendLine($"\n[*] Fecha nacimieto: {this.fechaNacimiento.Year}\n");

            return datos.ToString();
        }
        #endregion

        #region Operators
        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2) 
        {
            return !(d1 == d2);
        }
        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            return d1.Nombre == d2.Nombre && d1.fechaNacimiento == d2.fechaNacimiento;
        }
        #endregion
    }
}
