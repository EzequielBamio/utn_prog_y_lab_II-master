using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta, string objeto) 
        {
            if (this.ValidarArchivo(ruta, true)) 
            {
                using (StreamWriter writer = new StreamWriter(ruta)) 
                {
                    writer.WriteLine(objeto);
                    return true;
                }
            }
            return false;
        }
        public bool GuardarComo(string ruta, string objeto)
        {
            return this.Guardar(ruta, objeto);
        }
        public string Leer(string ruta)
        {
            string rtn = string.Empty;
            if (this.ValidarArchivo(ruta, true))
            {
                using (StreamReader reader = new StreamReader(ruta))
                {
                    rtn = reader.ReadToEnd();
                }
            }

            return rtn;
        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool rtn = false;
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == ".txt")
                    {
                        rtn = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un txt.");
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es un txt.", e);
            }
            catch (ArchivoIncorrectoException e) 
            {
                throw new ArchivoIncorrectoException("El archivo no es un txt.", e);
            }
            return rtn;
        }
    }
}
