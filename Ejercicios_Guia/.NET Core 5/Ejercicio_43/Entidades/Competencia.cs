using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        public enum TipoCompetencia { F1, MotoCross }
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        #region Builders
        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.CantidadVueltas = cantidadVueltas;
            this.CantidadCompetidores = cantidadCompetidores;
            this.Tipo = tipo;
        }
        #endregion

        #region Properties
        public List<VehiculoDeCarrera> Competidores 
        {
            get 
            {
                return this.competidores;
            }
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                if (value > 0)
                {
                    this.cantidadCompetidores = value;
                }
            }
        }
        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                if (value > 0)
                {
                    this.cantidadVueltas = value;
                }
            }
        }
        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }
        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        #endregion

        #region Show
        public string MostrarDatos()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine("### Competencia ###");
            informacion.AppendLine("Cantidad de competidores: " + this.cantidadCompetidores);
            informacion.AppendLine("Cantidad de vueltas: " + this.cantidadVueltas);
            foreach (VehiculoDeCarrera auto in this.competidores)
            {
                informacion.AppendLine(auto.MostrarInformacion());
            }


            return informacion.ToString();
        }
        #endregion

        #region Operators
        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            bool rtn = false;
            if (c == v)
            {
                c.competidores.Remove(v);
                rtn = true;
            }
            return rtn;
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            bool rtn = false;
            Random combustible = new Random();
            
            try
            {
                if (c.cantidadCompetidores > c.competidores.Count)
                {
                    if (c != v)
                    {
                        c.competidores.Add(v);
                        v.EnCompetencia = true;
                        v.VueltasRestantes = c.cantidadVueltas;
                        v.CantidadCombustible = (short)combustible.Next(15, 100);
                        rtn = true;
                    }
                }
            }
            catch (CompetenciaNoDisponibleException e) 
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "Sobrecarga '+'", e);
            }
            
            return rtn;
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool rtn = false;
            if (c.Tipo == Competencia.TipoCompetencia.F1 && v is AutoF1 || (c.Tipo == Competencia.TipoCompetencia.MotoCross && v is MotoCross))
            {
                foreach (VehiculoDeCarrera auto in c.competidores)
                {
                    if (auto == v)
                    {
                        rtn = true;
                        break;
                    }
                }
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "Sobrecarga '=='");
            }

            return rtn;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }
        #endregion
    }
}
