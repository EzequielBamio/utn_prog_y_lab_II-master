using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiAtributo 
        {
            get;
        }

        public abstract string MiMetodo();
        public override string ToString() 
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            return obj is Sobrescrito;
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
