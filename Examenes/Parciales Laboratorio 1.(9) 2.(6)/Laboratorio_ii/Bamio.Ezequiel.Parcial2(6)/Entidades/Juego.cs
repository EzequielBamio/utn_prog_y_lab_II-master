using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void InformacionDeAvance(object sender, short movimiento);

    public class Juego
    {
        public event InformacionDeAvance InformarAvance;

        private static short velocidad;
        private short ubicacion;
        private object controlVisual;

        static Juego() 
        {
            velocidad = 8;
        }
        public Juego() { }
        public Juego(short ubicacion, object objetoVisual)
        {
            this.ubicacion = ubicacion;
            this.controlVisual = objetoVisual;
        }

        [System.Text.Json.Serialization.JsonIgnore]
        public object ControlVisual
        {
            get
            {
                return this.controlVisual;
            }
            set
            {
                this.controlVisual = value;
            }
        }

        public static short Velocidad { get => velocidad; set => velocidad = value; }
        public short Ubicacion { get => ubicacion; set => ubicacion = value; }

        public short Avanzar()
        {
            this.ubicacion += velocidad;
            return this.ubicacion;
        }

        /// <summary>
        /// Simular la animación del Carrusel
        /// </summary>
        public void IniciarCarrusel(CancellationToken cancellationToken)
        {
            while (cancellationToken.IsCancellationRequested)
            {
                this.InformarAvance.Invoke(this, Avanzar());
                System.Threading.Thread.Sleep(60 + Juego.velocidad);
                
            }
        }
    }
}
