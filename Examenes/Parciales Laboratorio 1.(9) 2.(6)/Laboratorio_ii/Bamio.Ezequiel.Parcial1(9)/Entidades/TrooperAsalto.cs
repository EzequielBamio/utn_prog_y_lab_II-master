using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperAsalto : Trooper
    {

        #region Builders
        /// <summary>
        /// Constructor que asigna el armamento y si es clon, mediante el constructor de la clase base
        /// </summary>
        /// <param name="armamento"></param>
        public TrooperAsalto(Blaster armamento) 
            : base(armamento, true)
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
                return "Comando para misiones de infiltración";
            }
        }
        #endregion

    }
}
