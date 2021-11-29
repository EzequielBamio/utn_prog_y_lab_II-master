using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void ValidarInstanciaVehiculos()
        {
            //Asseger
            Competencia competencia = new Competencia(5, 7, Competencia.TipoCompetencia.F1);
            //Act

            //Assert
            Assert.IsNotNull(competencia.Competidores);
        }

        [TestMethod]
        public void ValidarCargaAutoF1() 
        {
            //Asseger
            Competencia competencia = new Competencia(5, 7, Competencia.TipoCompetencia.MotoCross);
            AutoF1 autoF1 = new AutoF1(16, "TR");
            bool rtn;
            //Act
            rtn = competencia + autoF1;
            //Assert
            Assert.IsTrue(rtn);
        }

        [TestMethod]
        public void ValidarCargaMotoCross()
        {
            //Asseger
            Competencia competencia = new Competencia(5, 7, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(18, "TR");
            bool rtn;
            //Act
            rtn = competencia + motoCross;
            //Assert
            Assert.IsTrue(rtn);
        }

        [TestMethod]
        public void ValidarExistenciaVehiculo()
        {
            //Asseger
            Competencia competencia = new Competencia(5, 7, Competencia.TipoCompetencia.F1);
            AutoF1 auto = new AutoF1(18, "XR3");
            AutoF1 auto2 = new AutoF1(22, "SDE");
            bool rtnAux;

            //Act
            rtnAux = competencia + auto;
            rtnAux = competencia + auto2;

            bool rtn = competencia == auto;

            //Assert
            Assert.IsTrue(rtn);
        }

        [TestMethod]
        public void ValidarEliminarVehiculo()
        {
            //Asseger
            Competencia competencia = new Competencia(5, 7, Competencia.TipoCompetencia.F1);
            AutoF1 auto = new AutoF1(18, "XR3");
            AutoF1 auto2 = new AutoF1(22, "SDE");
            bool rtnAux;

            //Act
            rtnAux = competencia + auto;
            rtnAux = competencia + auto2;
            rtnAux = competencia - auto;
            bool rtn = competencia != auto;

            //Assert
            Assert.IsTrue(rtn);
        }
    }
}
