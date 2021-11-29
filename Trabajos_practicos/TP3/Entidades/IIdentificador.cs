using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IIdentificador<T>
    {
        public int OrdenarPorId(T objeto1, T objeto2);
        public int GenerarId();


    }
}
