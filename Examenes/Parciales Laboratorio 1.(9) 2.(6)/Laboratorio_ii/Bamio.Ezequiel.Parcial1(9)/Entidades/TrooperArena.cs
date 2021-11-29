using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperArena : Trooper
    {

        #region Builders
        /// <summary>
        /// Constructor que asigna el armamento, mediante el constructor de la clase base
        /// </summary>
        /// <param name="armamento"></param>
        public TrooperArena(Blaster armamento) 
            : base(armamento)
        { }

        #endregion

        #region Propierties

        /// <summary>
        /// retorna el Tipo del Trooper
        /// </summary>
        public override string Tipo 
        {
            get 
            {
                return "Soldados de asalto de terrenos desérticos";
            }
        } 

        #endregion

    }
}
