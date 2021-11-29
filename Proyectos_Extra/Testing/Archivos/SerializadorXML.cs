using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    [Serializable]
    public class SerializadorXML<T> : IArchivos<T>
        where T : class
    {
        public void Escribir(string rutaCompleta, T objeto, bool incluir) 
        {
            using (XmlTextWriter writer = new XmlTextWriter(rutaCompleta, Encoding.UTF8)) 
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                writer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, objeto);
            }
        }

        public T Leer(string rutaCompleta) 
        {
            //using cumple la misma funcion que el try-finally.
            using (XmlTextReader reader = new XmlTextReader(rutaCompleta))
            { 
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                return (T)serializer.Deserialize(reader);
            }
        }

        
    }
}
