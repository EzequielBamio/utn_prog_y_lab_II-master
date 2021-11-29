using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        /*Los atributos área (base * altura) y perímetro ((base + altura)*2) se deberán calcular sólo
        una vez, al llamar por primera vez a su correspondiente método getter (GetArea y
        GetPerimetro de la clase Rectángulo creados en el punto anterior). Luego, cada vez que se
        invoque a los métodos Area y Perimetro, se deberá retornar siempre el valor calculado
        anteriormente.*/
        public float Area()
        {
            const float area = this.vertice1.GetY;
            
            return 0;
        }

        public float Perimetro()
        {
            return this.perimetro;
        }

        public float GetArea()
        {
            return this.area;
        }
        public float GetPerimetro()
        {
            return this.perimetro;
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
        }
    }

}
