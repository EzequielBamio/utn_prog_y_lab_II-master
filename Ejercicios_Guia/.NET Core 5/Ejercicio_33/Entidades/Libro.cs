using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Libro
    {
        private List<string> paginas;

        public Libro() 
        {
            this.paginas = new List<string>();
        }

        public string this[int i] 
        {
            get 
            {
                if (i < paginas.Count) 
                {
                    return paginas[i];
                }

                return "";
            }
            set 
            {
                paginas.Add(value);
            }
        }
    }
}
