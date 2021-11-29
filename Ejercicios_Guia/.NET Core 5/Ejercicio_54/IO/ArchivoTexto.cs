using System;
using System.IO;
using System.Text;

namespace IO
{
    public static class ArchivoTexto
    {
        public static void Guardar(string rutaCompleta, string texto, bool append) 
        {
            StreamWriter streamWriter = null;

            try
            {
                streamWriter = new StreamWriter(rutaCompleta, append);

                streamWriter.WriteLine(texto);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        }

        public static string Leer(string rutaCompleta) 
        {
            StreamReader streamReader = null;
            if (File.Exists(rutaCompleta))
            {
                try
                {
                    streamReader = new StreamReader(rutaCompleta);

                    string rtnInfo = string.Empty;
                    string texto = streamReader.ReadLine();

                    while (texto != null)
                    {
                        rtnInfo += texto + "\n";
                        texto = streamReader.ReadLine();
                    }

                    return rtnInfo;

                }
                finally
                {
                    if (streamReader != null)
                    {
                        streamReader.Close();
                    }  
                }
            }
            else
            {
                throw new FileNotFoundException("El archivo no existe.");
            }
        }
    }
}
