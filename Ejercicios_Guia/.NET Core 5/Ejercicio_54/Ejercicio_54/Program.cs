using System;
using System.IO;
using Entidades;
using IO;
namespace Ejercicio_54
{
    class Program
    {
        static void Main(string[] args)
        {
  
            string nombreArchivo = DateTime.Now.ToString("yyyyMMdd-HHmm");
            string rutaCompleta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + nombreArchivo + ".txt";

            try
            {
                OtraClase otraClase = new OtraClase();
                otraClase.MetodoInstancia();
            }
            catch (MiExcepcion e)
            {
                ArchivoTexto.Guardar(rutaCompleta, e.Message, false);

                Exception eInner = e.InnerException;
                while (eInner != null)
                {
                    ArchivoTexto.Guardar(rutaCompleta, eInner.Message, true);

                    eInner = eInner.InnerException;
                }
            }
            try
            {
                Console.WriteLine(ArchivoTexto.Leer(rutaCompleta));
            }
            catch (FileNotFoundException e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
