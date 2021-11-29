using System;
using Entidades;
namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Documento, Recibo> contabilidad = new Contabilidad<Documento, Recibo>();
            Recibo recibo = new Recibo(25);
            Documento factura = new Factura(55);
            Factura factura2 = new Factura(33);

            contabilidad += factura;
            contabilidad += factura2;
            contabilidad += recibo;

            //Console.WriteLine(contabilidad.Mostrar());

            
        }
    }
}
