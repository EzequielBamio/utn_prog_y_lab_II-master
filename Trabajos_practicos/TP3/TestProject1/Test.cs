using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;

namespace TestProject1
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Verifica que no se pueda agregar 2 veces el mismo cliente 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ClienteInvalidoException))]
        public void AgregarCliente()
        {
            Fabrica fabrica = new Fabrica("Test");
            Cliente cliente = new Cliente(3, "test", "test", "test", 54578781);

            fabrica += cliente;
            fabrica += cliente;
        }

        /// <summary>
        /// Verifica que no se pueda eliminar un cliente que no esta en la lista
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ClienteInvalidoException))]
        public void EliminarCliente()
        {
            Fabrica fabrica = new Fabrica("Test");
            Cliente cliente = new Cliente(3, "test", "test", "test", 54578781);
            Cliente cliente2 = new Cliente(2, "asd", "2ws", "sdq", 54578781);

            fabrica += cliente;
            fabrica -= cliente2;
        }

        /// <summary>
        /// Verifica que la id no sea invalida
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(IdInvalidaException))]
        public void AsignarleIdInvalida()
        {
            Cliente cliente = new Cliente(-2, "test", "test", "test", 54578781);

        }

        /// <summary>
        /// Verifica que no se agreguen 2 productos iguales a la lista
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ProductoInvalidoException))]
        public void AgregarProducto()
        {
            Fabrica fabrica = new Fabrica("Test");
            Producto producto = new Producto(5000, "test", 520, ETamanioEnvase.Grande, ETipoEnvase.Botella, EProducto.Gaseosa);

            fabrica += producto;
            fabrica += producto;
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
