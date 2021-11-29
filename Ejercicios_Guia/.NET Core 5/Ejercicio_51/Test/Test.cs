using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using System;

namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void ValidarListaLlamadas()
        {
            //Arrange
            Centralita testCentralita = new Centralita("Test");

            //Act
            //Assert
            Assert.IsNotNull(testCentralita.Llamadas);
        }

        [TestMethod]
        public void ValidarSegundaCargaLocal()
        {
            //Arrange
            Centralita testCentralita = new Centralita("Test");
            Llamada testPrimeraLlamada = new Local("1145574", 20, "5487752", 6);
            Llamada testSegundaLlamada = new Local("1145574", 20, "5487752", 6);

            //Act
            testCentralita += testPrimeraLlamada;
            testCentralita += testSegundaLlamada;

            //Assert
        }

        [TestMethod]
        public void ValidarSegundaCargaProvincial()
        {
            //Arrange
            Centralita testCentralita = new Centralita("Test");
            Llamada testPrimeraLlamada = new Provincial("45875223", Provincial.Franja.Franja_1, 55, "213658");
            Llamada testSegundaLlamada = new Provincial("45875223", Provincial.Franja.Franja_1, 55, "213658");

            //Act
            testCentralita += testPrimeraLlamada;
            testCentralita += testSegundaLlamada;

            //Assert
        }

        [TestMethod]
        public void ValidarInstancia()
        {
            /*Dentro de un método de test unitario crear dos llamadas Local y dos Provincial, todos con
            los mismos datos de origen y destino. Luego comparar cada uno de estos cuatro objetos
            contra los demás, debiendo ser iguales solamente las instancias de Local y de Provincial
            entre sí.*/

            //Arrange
            Llamada testPrimeraLlamadaLoc = new Local("1145574", 20, "5487752", 6);
            Llamada testSegundaLlamadaLoc = new Local("1145574", 20, "5487752", 6);

            Llamada testPrimeraLlamadaPro = new Provincial("1145574", Provincial.Franja.Franja_1, 55, "5487752");
            Llamada testSegundaLlamadaPro = new Provincial("1145574", Provincial.Franja.Franja_1, 55, "5487752");

            //Act

            //Assert
            Assert.AreNotSame(testPrimeraLlamadaLoc, testSegundaLlamadaPro, "Son iguales");
            Assert.AreNotSame(testPrimeraLlamadaPro, testSegundaLlamadaLoc, "Son iguales");
        }
    }
}
