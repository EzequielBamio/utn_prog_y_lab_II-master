using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace IO
{
    public class Serializacion<T> : IArchivos<T>
        where T : class 
    { 
        /// <summary>
        /// Guarda el objeto en la ruta pasada por parametro con una extesion XML
        /// </summary>
        /// <param name="rutaCompleta"></param>
        /// <param name="objeto"></param>
        /// <param name="incluir"></param>
        public void Escribir(string rutaCompleta, T objeto, bool incluir)
        {
            if (Path.GetExtension(rutaCompleta) == ".xml")
            {
                using (XmlTextWriter writer = new XmlTextWriter(rutaCompleta, Encoding.UTF8))
                {
                    writer.Formatting = Formatting.Indented;
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(writer, objeto);
                }
            }
            else
            {
                throw new ArchivoException("Extension invalida, pruebe con .XML");
            }
        }
        /// <summary>
        /// Lee el archivo de la ruta pasada por parametro y retorna su contenido
        /// </summary>
        /// <param name="rutaCompleta"></param>
        /// <returns>El objeto deserializado</returns>
        public T Leer(string rutaCompleta)
        {
            if (Path.GetExtension(rutaCompleta) == ".xml")
            {
                using (XmlTextReader reader = new XmlTextReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    return (T)xmlSerializer.Deserialize(reader);
                }
            }
            else
            {
                throw new ArchivoException("Extension invalida, pruebe con .XML");
            }
        }
        /// <summary>
        /// Guarda el objeto en la ruta pasada por parametro con una extesion Json
        /// </summary>
        /// <param name="rutaCompleta"></param>
        /// <param name="objeto"></param>
        /// <param name="incluir"></param>
        public void EscribirJson(string rutaCompleta, T objeto, bool incluir)
        {
            try
            {
                Archivo file = new Archivo();
                string jsonString = JsonSerializer.Serialize(objeto, typeof(T));
                file.Escribir(rutaCompleta, jsonString, incluir);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Lee el archivo de la ruta pasada por parametro y retorna su contenido
        /// </summary>
        /// <param name="rutaCompleta"></param>
        /// <returns>El objeto deserializado</returns>
        public T LeerJson(string rutaCompleta) 
        {
            try
            {
                Archivo file = new Archivo();
                string jsonString = file.Leer(rutaCompleta);

                return JsonSerializer.Deserialize<T>(jsonString);
            }
            catch (Exception) 
            {
                throw;
            }
        }
    }
}
