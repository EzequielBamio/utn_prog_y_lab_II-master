using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using IO;
using BD;
using System.Collections.Generic;

namespace Test_Proyecto
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArchivoException))]
        public void GuardarArchivoExtesionInvalida()
        {
            Fabrica testFabrica = new Fabrica("TestInvalidoValido");
            Serializacion<Fabrica> serializacionTest = new Serializacion<Fabrica>();
            serializacionTest.Escribir("Test.json", testFabrica, false);
            
        }

        [TestMethod]
        public void GuardarArchivo()
        {
            Fabrica testFabrica = new Fabrica("TestValido");
            Serializacion<Fabrica> serializacionTest = new Serializacion<Fabrica>();
            serializacionTest.Escribir("Test.xml", testFabrica, false);
            //-----------
            Fabrica testingFabrica = serializacionTest.Leer("Test.xml");

            Assert.AreEqual(testFabrica.Nombre, testingFabrica.Nombre);
        }

        [TestMethod]
        public void VerificarDatosGuardadosBD()
        {
            bool rtn = false;
            Reporte testReporte = new Reporte(7, 3, 4, 500);
            GestorBaseDeDatos gestorBD = new GestorBaseDeDatos();
            gestorBD.Guardar(testReporte);
            //------------------
            List<Reporte> testingReportes = gestorBD.Leer();


            foreach (Reporte reporte in testingReportes) 
            {
                if (testReporte.Fecha == reporte.Fecha) 
                {
                    rtn = true;
                }
            }
            Assert.AreEqual(true, rtn);
        }
        /// <summary>
        /// Verifica que no se pueda agregar 2 veces el mismo cliente 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ClienteInvalidoException))]
        public void AgregarCliente()
        {
            Fabrica fabrica = new Fabrica("Test");
            Cliente cliente = new Cliente(3, "test", "test", "test", "test", 54578781);

            fabrica += cliente;
            fabrica += cliente;
        }

        /// <summary>
        /// Verifica que no se pueda eliminar un producto que no esta en la lista
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ProductoInvalidoException))]
        public void EliminarProducto()
        {
            Fabrica fabrica = new Fabrica("Test");
            Producto producto = new Producto("test", 520, ETamanioEnvase.Grande, ETipoEnvase.Botella, EProducto.Gaseosa);
            Producto producto2 = new Producto("test", 520, ETamanioEnvase.Grande, ETipoEnvase.Botella, EProducto.Gaseosa);

            fabrica += producto;
            fabrica -= producto2;
        }
    }
}
