using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca { Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson }
        public enum ETamanio { Chico, Mediano, Grande }

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        #region Builders
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color) 
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }

        #endregion

        #region Propierties

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get;}

        #endregion

        #region Show

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"MARCA: {this.marca}\r\n");
            datos.AppendLine($"CHASIS: {this.chasis}\r\n");
            datos.AppendLine($"COLOR: {this.color}\r\n");
            datos.AppendLine("---------------------");

            return datos.ToString();
        }

        #endregion

        #region Operators

        public static explicit operator string(Vehiculo p)
        {
            return p.Mostrar();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }
        #endregion
    }
}
