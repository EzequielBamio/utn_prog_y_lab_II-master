using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 0.89;
        }
        public Euro() : this(0, cotizRespectoDolar)
        {

        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static void SetCotizacion(double cotizacion) 
        {
            cotizRespectoDolar = cotizacion;
        }

        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(((Dolar)e).GetCantidad() * Pesos.GetCotizacion());
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() * Euro.GetCotizacion());
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);

        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);

        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - (((Euro)d).GetCantidad()));
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.GetCantidad() - (((Euro)p).GetCantidad()));
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + (((Euro)d).GetCantidad()));
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.GetCantidad() + (((Euro)p).GetCantidad()));
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return e.GetCantidad() == d.GetCantidad();
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return e.GetCantidad() == p.GetCantidad();
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
    }
}
