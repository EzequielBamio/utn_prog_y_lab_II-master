using System;
using System.IO;
using System.Text.Json;

namespace Archivos
{
    public class JsonFiler<T> : IMetodosArchivos<T>
    {
        public string GenerarRutaCompleta
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            }
        }

        public bool ExisteArchivo(string nombreArchivo)
        {
            return File.Exists(nombreArchivo);
        }
        /// <summary>
        /// Guarda el objeto pasado por parametro en un archivo .json
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="objeto"></param>
        public void Guardar(string archivo, T objeto)
        {
            string ruta = this.GenerarRutaCompleta + archivo;
            if (this.ExisteArchivo(ruta))
            {
                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(ruta))
                    {
                        streamWriter.WriteLine(JsonSerializer.Serialize(objeto, typeof(T)));
                    }

                }
                catch (Exception)
                {
                    throw new ErrorArchivosException("Error al querer guardar el archivo");
                }
            }
            else 
            {
                throw new ErrorArchivosException("Error el archivo no existe");
            }
        }
        /// <summary>
        /// Deserializa el archivo pasado por parametro y lo carga en "objeto"
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="objeto"></param>
        public void Leer(string archivo, out T objeto)
        {
            
            string texto = string.Empty;
            string ruta = this.GenerarRutaCompleta + archivo;
            if (this.ExisteArchivo(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    while (!streamReader.EndOfStream)
                    {
                        texto += $"{streamReader.ReadLine()}\n";
                    }

                }

                objeto = JsonSerializer.Deserialize<T>(texto);

            }
            else
            {
                throw new ErrorArchivosException("Error el archivo no existe");
            }

        }
    }
}
