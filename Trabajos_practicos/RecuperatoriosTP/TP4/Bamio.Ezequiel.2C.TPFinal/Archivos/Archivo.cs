using System;
using System.IO;

namespace IO
{
    public class Archivo : IArchivos<string>
    {
        /// <summary>
        /// Guarda en un archivo el texto pasado por parametro en la ruta pasada por parametro
        /// </summary>
        /// <param name="rutaCompleta"></param>
        /// <param name="texto"></param>
        /// <param name="incluir"></param>
        public void Escribir(string rutaCompleta, string texto, bool incluir)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(rutaCompleta, incluir))
                {
                    streamWriter.WriteLine(texto);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Lee el archivo pasado por parametro
        /// </summary>
        /// <param name="rutaCompleta"></param>
        /// <returns>Un string cargado con lo leido en el archivo</returns>
        public string Leer(string rutaCompleta)
        {
            string rtn = string.Empty;

            try
            {
                using (StreamReader streamReader = new StreamReader(rutaCompleta))
                {

                    while (!streamReader.EndOfStream)
                    {
                        rtn += streamReader.ReadLine() + "\n";
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return rtn;

        }
    
    }
}
