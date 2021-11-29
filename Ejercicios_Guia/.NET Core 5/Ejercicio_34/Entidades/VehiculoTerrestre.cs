using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre
    {
        public enum Colores {Rojo, Amarillo, Verde, Blanco, Negro }

        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;

        public VehiculoTerrestre() { }

        public VehiculoTerrestre(short cR, short cP, Colores color) : this()
        {
            this.cantidadRuedas = cR;
            this.cantidadPuertas = cP;
            this.color = color;
        }

        public short CantidadRuedas 
        {
            get 
            {
                return this.cantidadRuedas;
            }
            set 
            {
                if (value > -1) 
                {
                    this.cantidadRuedas = value;
                }
            }
        }

        public short CantidadPuertas
        {
            get
            {
                return this.cantidadPuertas;
            }
            set
            {
                if (value > -1)
                {
                    this.cantidadPuertas = value;
                }
            }
        }

        public Colores Color
        {
            get
            {
                return this.color;
            }
            set
            {  
                this.color = value;
            }
        }
        public string MostrarDatos() 
        {
            StringBuilder informacion = new StringBuilder();

            informacion.Append("\n[*] Puertas:     " + this.CantidadPuertas);
            informacion.Append("\n[*] Ruedas:     " + this.CantidadRuedas);
            informacion.Append("\n[*] Color:     " + this.Color);

            return informacion.ToString();
        }
    }
}
