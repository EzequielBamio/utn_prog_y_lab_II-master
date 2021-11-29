using Entidades;
using System;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear el código necesario para:
                a. Crear 2 excepciones propias (nuevas clases que herede de excepción) con los nombres
                UnaExcepcion y MiExcepcion.
                b. Crear una clase llamada MiClase y dentro colocar un método estático y 2 constructores de
                instancia.
                c. Dentro del método estático lanzar una excepción DivideByZeroException (sólo lanzarla).
                d. Capturar la excepción del punto anterior en un constructor de instancia y relanzarla hacia
                otro constructor de instancia.
                e. En este segundo constructor instanciará otro objeto del tipo MiClase capturando su
                excepción. Crear una excepción propia llamada UnaException (utilizar innerException para
                almacenar la excepción original) y volver a lanzarla.
                f. Generar la clase OtraClase con un método de instancia, donde se instancie un objeto
                MiClase y se capture la excepción anterior. Este método generará una excepción propia
                llamada MiException y la lanzará.
                g. MiException será capturada en el Main, mostrando el mensaje de error que esta almacena
                por pantalla y los mensajes de todas las excepciones almacenadas en sus innerException.
             */
            try
            {
                OtraClase otraClase = new OtraClase();
                otraClase.MetodoInstancia();
            }
            catch (MiExcepcion e)
            {
                Console.WriteLine(e.Message);

                Exception eInner = e.InnerException;
                while (eInner != null)
                {
                    Console.WriteLine(eInner.Message);
                    eInner = eInner.InnerException;
                }
            }

            Console.ReadLine();
        }
    }
}
