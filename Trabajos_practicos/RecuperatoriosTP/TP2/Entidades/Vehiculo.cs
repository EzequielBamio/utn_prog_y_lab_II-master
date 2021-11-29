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

        /// <summary>
        /// Constructor que asigna los datos a los atributos.
        /// </summary>
        /// <param name="chasis">dato que se asigna al atributo chasis</param>
        /// <param name="marca">marca que se asigna al atributo marca</param>
        /// <param name="color">color que se asigna al atributo color</param>
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
            return (string)this;
        }

        #endregion

        #region Operators
        /// <summary>
        /// Casteo un vehiculo y retorna sus datos.
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"CHASIS: {p.chasis}");
            datos.AppendLine($"MARCA : {p.marca}");
            datos.AppendLine($"COLOR : {p.color}");
            datos.AppendLine("---------------------\n");
            datos.Append($"TAMAÑO : {p.Tamanio}");

            return datos.ToString();
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
