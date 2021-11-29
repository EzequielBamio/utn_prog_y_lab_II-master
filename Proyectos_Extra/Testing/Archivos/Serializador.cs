using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    [Serializable]
    public class Serializador<T> : IArchivos<T>
        where T : class //Que tenga un constructor por defecto
    {
        public void Escribir(string rutaCompleta, T objeto, bool incluir) 
        {
            FileManager file = new FileManager();
            string jsonString = JsonSerializer.Serialize(objeto, typeof(T));
            file.Escribir(rutaCompleta, jsonString, append);
  
        }

        public T Leer(string rutaCompleta) 
        {
            FileManager file = new FileManager();
            string jsonString = file.Leer(rutaCompleta);

            return JsonSerializer.Deserialize<T>(jsonString);
        }


    }
}
