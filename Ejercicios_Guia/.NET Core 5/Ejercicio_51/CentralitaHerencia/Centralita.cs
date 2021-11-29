using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static CentralitaHerencia.Llamada;
using IO;

namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
    {
        private List<Llamada> listaDeLlamada;
        protected string razonSocial;

        #region Builders
        public Centralita() 
        {
            this.listaDeLlamada = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()  
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Propierties
        public float GananciasPorLocal 
        {
            get 
            {
                return this.CalcularGanancias(TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancias(TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancias(TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas 
        {
            get 
            {
                return this.listaDeLlamada;
            }
        }

        #endregion

        #region Show
        public override string ToString()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"***** {this.razonSocial} *****");
            informacion.AppendLine($"Ganacia total: {this.GananciasPorTotal}");
            informacion.AppendLine($"Ganacia local: {this.GananciasPorLocal}");
            informacion.AppendLine($"Ganacia provincial: {this.GananciasPorProvincial}");
            informacion.AppendLine("\n***** Listado de llamadas *****");

            foreach (Llamada llamada in this.Llamadas)
            {
                informacion.AppendLine(llamada.ToString());
            }

            return informacion.ToString();
        }
        #endregion

        #region Methods
        private float CalcularGanancias(TipoLlamada tipo) 
        {
            float gananciaProvincial = 0;
            float gananciaLocal = 0;
            float rtn = 0;

            foreach (Llamada llamada in this.Llamadas) 
            {
                if (llamada is Local) 
                {
                    gananciaLocal += ((Local)llamada).CostoLlamada;
                }
                if (llamada is Provincial)
                {
                    gananciaProvincial += ((Provincial)llamada).CostoLlamada;
                }

                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        rtn = gananciaLocal;
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        rtn = gananciaProvincial;
                        break;
                    case Llamada.TipoLlamada.Todas:
                        rtn = gananciaLocal + gananciaProvincial;
                        break;
                }
            }
            
            return rtn;
        }
        public void OrdenarLlamadas() 
        {
            this.Llamadas.Sort(Llamada.OrdernarPorDuracion); 
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }

        #region Operators
        public static bool operator !=(Centralita c, Llamada llamada) 
        {
            return !(c == llamada);
        }
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool rtn = false;
            foreach (Llamada item in c.Llamadas) 
            {
                if (item == llamada) 
                {
                    rtn = true;
                    break;
                }
            }
            return rtn;
        }
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {

            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            else 
            {
                throw new CentralitaException("La llamada ya existe", "Centralita", "Agregar llamada a Centralita");
            }
            
            return c;
        }
        #endregion

        #endregion

        string IGuardar<string>.RutaDeArchivo 
        {
            get 
            {
                return "RutaDeArchivo";
            }
            set 
            {
            }
        }

        bool IGuardar<string>.Guardar()
        {
            bool rtn = false;
            string rutaCompleta = $"{ Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Bitacora.txt";

            string mensaje = DateTime.Now.ToString("dddd dd de MMMM de yyyy HH:mm - Se realizo una llamada");

            if (File.Exists(rutaCompleta))
            {
                ArchivoTexto.Guardar(rutaCompleta, mensaje, true);
                rtn = true;
            }
            else 
            {
                ArchivoTexto.Guardar(rutaCompleta, mensaje, false);
                rtn = true;
            }


            return rtn;

        }

        string IGuardar<string>.Leer()
        {
            string rutaCompleta = $"{ Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Bitacora.txt";
            string mensaje = string.Empty;

            mensaje = ArchivoTexto.Leer(rutaCompleta);
            
            return mensaje;
        }

    }
}
