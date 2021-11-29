using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosException))]
        public void ArchivoInvalido()
        {
           
            JsonFiler<Juego> json = new JsonFiler<Juego>();
            Juego juego = new Juego(3, new Juego());
            json.Leer("test.txt", out juego);

        }

    }
}
