using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IO
{
    public class Serializacion<T> : IArchivos<T>
        where T : class 
    {
        public void Escribir(string rutaCompleta, T objeto, bool incluir)
        {
            Archivo file = new Archivo();
            string jsonString = JsonSerializer.Serialize(objeto, typeof(T));
            file.Escribir(rutaCompleta, jsonString, incluir);
        }

        public T Leer(string rutaCompleta)
        {
            Archivo file = new Archivo();
            string jsonString = file.Leer(rutaCompleta);

            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}
