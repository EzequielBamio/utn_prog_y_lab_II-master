using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    public class Celsius
    {
        private double grados;

        #region Builders
        public Celsius()
        {
            this.grados = 0;
        }

        public Celsius(double grados)
        {
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
        public static explicit operator Fahrenheit(Celsius gCelsius)
        {
            return new Fahrenheit(gCelsius.GetGrados() * (9 / 5) + 32);
        }

        public static explicit operator Kelvin(Celsius gCelsius)
        {
            return new Kelvin((((Fahrenheit)gCelsius).GetGrados() + 459.67) * 5 / 9);
        }

        public static implicit operator Celsius(double gCelsius)
        {
            return new Celsius(gCelsius);
        }

        public static bool operator ==(Celsius gCelsius1, Celsius gCelsius2)
        {
            return gCelsius1 == gCelsius2;
        }
        #endregion

        #region Operators

        #region Operator_==

        public static bool operator ==(Celsius gCelsius, Fahrenheit gFahrenheit)
        {
            return gFahrenheit.GetGrados() == gCelsius.GetGrados();
        }

        public static bool operator ==(Celsius gCelsius, Kelvin gKelvin)
        {
            return gCelsius.GetGrados() == gKelvin.GetGrados();
        }
        #endregion

        #region Operator_!=
        public static bool operator !=(Celsius gCelsius1, Celsius gCelsius2)
        {
            return !(gCelsius1 == gCelsius2);
        }
        public static bool operator !=(Celsius gCelsius, Fahrenheit gFahrenheit)
        {
            return !(gCelsius == gFahrenheit);
        }
        public static bool operator !=(Celsius gCelsius, Kelvin gKelvin)
        {
            return !(gCelsius == gKelvin);
        }
        #endregion

        #region Operator_+

        public static Celsius operator +(Celsius gCelsius, Fahrenheit gFahrenheit)
        {
            return new Celsius(gCelsius.GetGrados() + ((Celsius)gFahrenheit).GetGrados());
        }
        public static Celsius operator +(Celsius gCelsius, Kelvin gKelvin)
        {
            return new Celsius(gCelsius.GetGrados() + ((Celsius)gKelvin).GetGrados());
        }

        #endregion

        #region Operator_-

        public static Celsius operator -(Celsius gCelsius, Fahrenheit gFahrenheit)
        {
            return new Celsius(gCelsius.GetGrados() - ((Celsius)gFahrenheit).GetGrados());
        }
        public static Celsius operator -(Celsius gCelsius, Kelvin gKelvin)
        {
            return new Celsius(gCelsius.GetGrados() - ((Celsius)gKelvin).GetGrados());
        }

        #endregion

        #endregion
    }
}
