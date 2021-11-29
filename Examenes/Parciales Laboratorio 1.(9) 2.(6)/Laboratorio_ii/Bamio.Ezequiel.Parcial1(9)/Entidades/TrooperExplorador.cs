using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperExplorador : Trooper 
    {
        private string vehiculo;

        #region Builders
        /// <summary>
        /// Constructor que asigna el vehiculo. Asigna el armamento, mediante el constructor de la clase base
        /// </summary>
        /// <param name="vehiculo">Cadena que se va asignar al atributo Vehiculo</param>
        public TrooperExplorador(string vehiculo)
            : base(Blaster.EC17)
        {
            this.Vehiculo = vehiculo;
        }

        #endregion

        #region Propierties
        /// <summary>
        /// retorna el Tipo del Trooper
        /// </summary>
        public override string Tipo 
        {
            get 
            {
                return "Soldado de exploración";
            }
        }

        /// <summary>
        /// retorna el vehiculo, o asigna un valor al atributo si dicho valor es distinto a vacio("")
        /// </summary>
        public string Vehiculo 
        {
            get 
            {
                return this.vehiculo;
            }
            set 
            {
                if (value != "")
                {
                    this.vehiculo = value;
                }
                else 
                {
                    this.vehiculo = "Indefinido";
                }
            }
        }
        #endregion

        #region Show
        /// <summary>
        /// Muestra los datos de la clase base y el vehiculo
        /// </summary>
        /// <returns>Una cadena cargada con los datos</returns>
        public override string InfoTrooper()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.InfoTrooper());
            datos.AppendLine($"--Vehiculo: [{this.Vehiculo}]");


            return datos.ToString();
        }

        #endregion


    }
}
