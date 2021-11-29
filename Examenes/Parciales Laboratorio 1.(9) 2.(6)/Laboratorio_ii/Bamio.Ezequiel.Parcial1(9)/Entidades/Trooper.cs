using System;
using System.Text;
using System.Collections.Generic;

namespace Entidades
{
    public enum Blaster { E11, EC17, DLT19 }

    public abstract class Trooper
    {
        protected Blaster armamento;
        protected bool esClon;

        #region Builders
        /// <summary>
        /// Constructor asigna el armamento. por defecto el atributo esClon es false
        /// </summary>
        /// <param name="armamento"></param>
        public Trooper(Blaster armamento) 
            : this(armamento, false)
        {
            
        }
        /// <summary>
        /// Constructor que asigna el armamento y si es Clon
        /// </summary>
        /// <param name="armamento"></param>
        /// <param name="esClon"></param>
        public Trooper(Blaster armamento, bool esClon)
        {
            this.armamento = armamento;
            this.EsClon = esClon;
        }
        #endregion

        #region Propierties

        /// <summary>
        /// Devuelve el armamento
        /// </summary>
        public Blaster Armamento 
        {
            get 
            {
                return this.armamento;
            }
        }
        /// <summary>
        /// devuelve y asgina esClon
        /// </summary>
        public bool EsClon
        {
            get
            {
                return this.esClon;
            }
            set 
            {
                this.esClon = value;
            }
        }
        
        public abstract string Tipo 
        {
            get;
        }
        #endregion

        #region Show
        /// <summary>
        /// Muestra los datos de la clase Trooper
        /// </summary>
        /// <returns>Un string cargado de los datos del Trooper</returns>
        public virtual string InfoTrooper()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"[{this.Tipo}] armado con [{this.Armamento}], [{this.EsClon}] es clone");

            return datos.ToString();
        }

        #endregion

        #region Methods
        /// <summary>
        /// Compara los dos tipos de datos que sean iguales
        /// </summary>
        /// <param name="obj">objeto a comparar</param>
        /// <returns>true si son iguales, false si no son iguales</returns>
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }

        #endregion

    }
}
