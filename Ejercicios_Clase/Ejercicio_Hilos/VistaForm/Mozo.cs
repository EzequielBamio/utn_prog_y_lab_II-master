using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VistaForm
{
    public class Mozo
    {
        public Task<Cerveza> ServirCerveza(string nombre) 
        {
            return new Task<Cerveza>( () => 
            {
                Thread.Sleep(25000);

                return new Cerveza(nombre);
            });
        }
    }
}
