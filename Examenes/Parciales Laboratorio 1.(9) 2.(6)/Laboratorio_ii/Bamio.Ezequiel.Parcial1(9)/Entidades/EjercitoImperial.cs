using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EjercitoImperial
    {
        private int capacidad;
        private List<Trooper> troopers;

        #region Builders
        /// <summary>
        /// Constructor privado que instancia la lista de troopers
        /// </summary>
        private EjercitoImperial() 
        {
            this.troopers = new List<Trooper>();
        }
        /// <summary>
        /// Constructor que asgina la capacidad
        /// </summary>
        /// <param name="capacidad">capacidad que se va asignar</param>
        public EjercitoImperial(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        #region Propierties
        /// <summary>
        /// devuelve la lista de troopers
        /// </summary>
        public List<Trooper> Troopers 
        {
            get 
            {
                return this.troopers;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Elimina el soldado pasado por paremetro
        /// </summary>
        /// <param name="ejercito">Ejercito donde esta la lista de toopers</param>
        /// <param name="soldado">soldado que se quiere eliminar</param>
        /// <returns></returns>
        public static EjercitoImperial operator -(EjercitoImperial ejercito, Trooper soldado) 
        {
            if (!(ejercito is null || soldado is null))
            {
                foreach (Trooper trooper in ejercito.Troopers) 
                {
                    if (soldado.Equals(trooper)) 
                    {
                        ejercito.Troopers.Remove(soldado);
                        break;
                    }
                }
            }

                return ejercito;
        }

        /// <summary>
        /// Agrega un soldado al ejercito solo si hay capacidad
        /// </summary>
        /// <param name="ejercito">ejercito donde se va a agregar el soldado</param>
        /// <param name="soldado">soldado para agregar</param>
        /// <returns>el ejercito</returns>
        public static EjercitoImperial operator +(EjercitoImperial ejercito, Trooper soldado)
        {
            if (!(ejercito is null || soldado is null)) 
            {
                if (ejercito.Troopers.Count < ejercito.capacidad) 
                {
                    ejercito.Troopers.Add(soldado);
                }
            }

            return ejercito;
        }
        #endregion
    }
}