using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    public class Kelvin
    {
        private double grados;

        #region Builders
        public Kelvin()
        {
            this.grados = 0;
        }

        public Kelvin(double grados)
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
        public static explicit operator Fahrenheit(Kelvin gKelvin)
        {
            return new Fahrenheit(gKelvin.GetGrados() * 9 / 5 - 459.67);
        }

        public static explicit operator Celsius(Kelvin gKelvin)
        {
            return new Celsius((((Fahrenheit)gKelvin).GetGrados() - 32) * 5 / 9);
        }

        public static implicit operator Kelvin(double gKelvin)
        {
            return new Kelvin(gKelvin);
        }
        #endregion

        #region Operators

        #region Operator_==

        public static bool operator ==(Kelvin gKelvin, Fahrenheit gFahrenheit)
        {
            return gKelvin.GetGrados() == gFahrenheit.GetGrados();
        }

        public static bool operator ==(Kelvin gKelvin, Celsius gCelsius)
        {
            return gKelvin.GetGrados() == gCelsius.GetGrados();
        }
        public static bool operator ==(Kelvin gKelvin1, Kelvin gKelvin2)
        {
            return gKelvin1 == gKelvin2;
        }
        #endregion

        #region Operator_!=
        public static bool operator !=(Kelvin gKelvin1, Kelvin gKelvin2)
        {
            return !(gKelvin1 == gKelvin2);
        }
        public static bool operator !=(Kelvin gKelvin, Fahrenheit gFahrenheit)
        {
            return !(gKelvin == gFahrenheit);
        }
        public static bool operator !=(Kelvin gKelvin, Celsius gCelsius)
        {
            return !(gKelvin == gCelsius);
        }
        #endregion

        #region Operator_+

        public static Kelvin operator +(Kelvin gKelvin, Fahrenheit gFahrenheit)
        {
            return new Kelvin(gKelvin.GetGrados() + ((Kelvin)gFahrenheit).GetGrados());
        }
        public static Kelvin operator +(Kelvin gKelvin, Celsius gCelsius)
        {
            return new Kelvin(gKelvin.GetGrados() + ((Kelvin)gCelsius).GetGrados());
        }

        #endregion

        #region Operator_-

        public static Kelvin operator -(Kelvin gKelvin, Fahrenheit gFahrenheit)
        {
            return new Kelvin(gKelvin.GetGrados() - ((Kelvin)gFahrenheit).GetGrados());
        }
        public static Kelvin operator -(Kelvin gKelvin, Celsius gCelsius)
        {
            return new Kelvin(gKelvin.GetGrados() - ((Kelvin)gCelsius).GetGrados());
        }

        #endregion

        #endregion
    }
}
