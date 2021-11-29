using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Contabilidad<T,U>
        where T : Documento
        where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingreso;

        public Contabilidad() 
        {
            this.egresos = new List<T>();
            this.ingreso = new List<U>();
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T,U> c, T egreso) 
        {
            c.egresos.Add(egreso);
            return c;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T,U> c, U ingreso) 
        {
            c.ingreso.Add(ingreso);
            return c;
        }

        public string Mostrar() 
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Egresos:\n");
            foreach (T item in this.egresos) 
            {
                datos.AppendLine($"Numero: {item.Numero}");
            }
            datos.AppendLine("\nIngresos:\n");
            foreach (U item in this.ingreso)
            {
                datos.AppendLine($"Numero: {item.Numero}");
            }

            return datos.ToString();
        }


    }
}
