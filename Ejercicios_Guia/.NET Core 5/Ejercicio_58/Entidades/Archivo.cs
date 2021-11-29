using System;
using System.IO;

namespace IO
{
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta, bool validarExistencia) 
        {
            bool rtn = false;
            if (validarExistencia)
            {
                if (!File.Exists(ruta)) 
                {
                    using (File.Create(ruta))
                    {
                        rtn = true;
                    }
                }else 
                {
                    throw new FileNotFoundException();
                }
            }
            
            return rtn;
        }
    }
}
