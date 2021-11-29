using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    public class Fahrenheit
    {
        private double grados;

        #region Builders
        public Fahrenheit() 
        {
            this.grados = 0;
        }

        public Fahrenheit(double grados) {
            this.grados = grados;
        }

        #endregion

        #region Getters
        public double GetGrados() 
        {
            return this.grados;
        }
        #endregion

        #region Conversor
        public static explicit operator Celsius(Fahrenheit gFahrenheit) 
        {
            return new Celsius((gFahrenheit.GetGrados() - 32) * 5 / 9);
        }

        public static explicit operator Kelvin(Fahrenheit gFahrenheit) 
        {
            return new Kelvin((gFahrenheit.GetGrados() + 459.67) * 5 / 9);
        }

        public static implicit operator Fahrenheit(double gFahrenheit) 
        {
            return new Fahrenheit(gFahrenheit);
        }
        #endregion

        #region Operators

        #region Operator_==

        public static bool operator ==(Fahrenheit gFahrenheit, Celsius gCelsius)
        {
            return gFahrenheit.GetGrados() == gCelsius.GetGrados();
        }

        public static bool operator ==(Fahrenheit gFahrenheit, Kelvin gKelvin)
        {
            return gFahrenheit.GetGrados() == gKelvin.GetGrados();
        }
        public static bool operator ==(Fahrenheit gFahrenheit1, Fahrenheit gFahrenheit2)
        {
            return gFahrenheit1 == gFahrenheit2;
        }
        #endregion

        #region Operator_!=
        public static bool operator !=(Fahrenheit gFahrenheit, Celsius gCelsius)
        {
            return !(gFahrenheit == gCelsius);
        }
        public static bool operator !=(Fahrenheit gFahrenheit, Kelvin gKelvin)
        {
            return !(gFahrenheit == gKelvin);
        }
        public static bool operator !=(Fahrenheit gFahrenheit1, Fahrenheit gFahrenheit2)
        {
            return !(gFahrenheit1 == gFahrenheit2);
        }
        #endregion

        #region Operator_+

        public static Fahrenheit operator +(Fahrenheit gFahrenheit, Celsius gCelsius) 
        {
            return new Fahrenheit(gFahrenheit.GetGrados() + ((Fahrenheit)gCelsius).GetGrados());
        }
        public static Fahrenheit operator +(Fahrenheit gFahrenheit, Kelvin gKelvin)
        {
            return new Fahrenheit(gFahrenheit.GetGrados() + ((Fahrenheit)gKelvin).GetGrados());
        }

        #endregion

        #region Operator_-

        public static Fahrenheit operator -(Fahrenheit gFahrenheit, Celsius gCelsius)
        {
            return new Fahrenheit(gFahrenheit.GetGrados() - ((Fahrenheit)gCelsius).GetGrados());
        }
        public static Fahrenheit operator -(Fahrenheit gFahrenheit, Kelvin gKelvin)
        {
            return new Fahrenheit(gFahrenheit.GetGrados() - ((Fahrenheit)gKelvin).GetGrados());
        }

        #endregion

        #endregion
    }
}
