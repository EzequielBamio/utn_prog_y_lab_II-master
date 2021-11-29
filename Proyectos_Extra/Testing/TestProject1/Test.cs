using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
namespace TestProject1
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        [ExpectedException(typeof(LimiteEdadExcepcion))]
        public void ValidarEdad()
        {
            //Assenger
            Persona persona = new Persona("Ezequiel", "Bamio", 15);
            //Act
            Console.WriteLine(persona.MostrarDatos());
            //Assert
        }
    }
}
