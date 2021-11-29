using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 0.023;
        }
        public Pesos() : this(0, cotizRespectoDolar)
        {

        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        public static void SetCotizacion(double cotizacion)
        {
            cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Euro(Pesos p)
        {
            return new Euro(((Euro)(Dolar)p).GetCantidad());
        }

        public static implicit operator Pesos(double p)
        {
            return new Pesos(p);
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad() / Pesos.GetCotizacion());
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);

        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);

        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() - (((Pesos)d).GetCantidad()));
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.GetCantidad() - (((Pesos)e).GetCantidad()));
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() + (((Pesos)d).GetCantidad()));
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.GetCantidad() + (((Pesos)e).GetCantidad()));
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            return p.GetCantidad() == ((Pesos)d).GetCantidad();
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return p.GetCantidad() == ((Pesos)e).GetCantidad();
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }
    }
}
