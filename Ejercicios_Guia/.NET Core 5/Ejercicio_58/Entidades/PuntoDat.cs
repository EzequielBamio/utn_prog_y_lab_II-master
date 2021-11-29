using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;
        public PuntoDat() { }
        public string Contenido 
        {
            get 
            {
                return this.contenido;
            }
            set 
            {
                this.contenido = value;
            }
        }
        public bool Guardar(string ruta, PuntoDat objeto)
        {
            if (this.ValidarArchivo(ruta, true)) 
            {
                using (FileStream writer = new FileStream(ruta, FileMode.OpenOrCreate)) 
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    binary.Serialize(writer, objeto);
                    return true;
                }
            }
            return false;
        }
        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            return this.Guardar(ruta, objeto);
        }
        public PuntoDat Leer(string ruta)
        {
            PuntoDat puntoDat = null;
            if (this.ValidarArchivo(ruta, true))
            {
                using (FileStream reader = new FileStream(ruta, FileMode.Open))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    puntoDat = (PuntoDat) binary.Deserialize(reader);
                }
            }
            return puntoDat;
        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == ".dat")
                    {
                        return true;
                    }
                    else 
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un dat.");
                    }
                }
            }
            catch (Exception e) 
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", e);
            }

            return false;
        }
    }
}
