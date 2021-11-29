using System;

using Entidades;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Excercise N° 22";

            NumeroDecimal decimalNumber = (NumeroDecimal)8;
            NumeroBinario binaryNumber = (NumeroBinario)"1111";

            Console.WriteLine("########## Convert ##########");
            NumeroDecimal decimalNumber2 = (NumeroDecimal)binaryNumber;
            NumeroBinario binaryNumber2 = (NumeroBinario)decimalNumber;

            Console.WriteLine($"Binary: {binaryNumber.GetNumero()} -> {decimalNumber2.GetNumero()}");
            Console.WriteLine($"Decimal: {decimalNumber.GetNumero()} -> {binaryNumber2.GetNumero()}");

            Console.WriteLine("\n########## Adition ##########");

            decimalNumber2 = (NumeroDecimal)((decimalNumber + binaryNumber));
            binaryNumber2 = (NumeroBinario)((binaryNumber + decimalNumber));
            Console.WriteLine($"D: {decimalNumber.GetNumero()} + B: {binaryNumber.GetNumero()} = {decimalNumber2.GetNumero()}");
            Console.WriteLine($"B: {binaryNumber.GetNumero()} + D: {decimalNumber.GetNumero()} = {binaryNumber2.GetNumero()}");


            Console.WriteLine("\n########## Subtraction ##########");
            decimalNumber2 = (NumeroDecimal)((decimalNumber - binaryNumber));
            binaryNumber2 = (NumeroBinario)(binaryNumber - decimalNumber);
            Console.WriteLine($"D: {decimalNumber.GetNumero()} - B: {binaryNumber.GetNumero()} = {decimalNumber2.GetNumero()}");
            Console.WriteLine($"B: {binaryNumber.GetNumero()} - D: {decimalNumber.GetNumero()} = {binaryNumber2.GetNumero()}");

            Console.ReadKey();
            /*########## Convert ##########
Binary: 111001 -> 57
Decimal: 30 -> 11110

########## Adition ##########
D: 30 + B: 111001 = 87
B: 111001 + D: 30 = 1010111

########## Subtraction ##########
D: 30 - B: 111001 = -27
B: 111001 - D: 30 = 11011
*/
        }
    }
}
