using System;
using System.IO;

namespace IO
{
    public class Archivo : IArchivos<string>
    {
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
