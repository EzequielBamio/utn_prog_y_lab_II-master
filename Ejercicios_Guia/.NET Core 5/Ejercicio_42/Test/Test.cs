using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ConstructorMiClase()
        {
            //Asseger
            MiClase miClase = new MiClase("Hola");
            //Act
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void ConstructorOtraClase()
        {
            //Asseger
            OtraClase otraClase = new OtraClase();
            //Act
            otraClase.MetodoInstancia();
            //Assert
        }
    }
}
