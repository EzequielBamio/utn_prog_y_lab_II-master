using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD
{
    public class Producto
    {
        private int id;
        private string nombre;
        private string descripcion;
        private string codigo;
        private float precio;

        public Producto(int id, string nombre, string descripcion, string codigo, float precio) 
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Codigo = codigo;
            this.Precio = precio;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }
        public string Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public string Mostrar() 
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"ID: {this.Id}");
            datos.AppendLine($"Nombre: {this.Nombre}");
            datos.AppendLine($"Codigo: {this.Codigo}");
            datos.AppendLine($"Precio: {this.Precio}");
            datos.AppendLine($"Descripcion: {this.Descripcion}");

            return datos.ToString();
        }

    }
}
