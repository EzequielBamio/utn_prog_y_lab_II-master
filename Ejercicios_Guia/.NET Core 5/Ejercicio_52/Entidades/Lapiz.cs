using System;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }

        ConsoleColor IAcciones.Color 
        {
            get 
            {
                return ConsoleColor.Gray;
            }
            set 
            {
                throw new NotImplementedException(); 
            }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get 
            {
                return this.tamanioMina;
            }
            set 
            {
                this.tamanioMina = value;
            }
        }
        public override string ToString()
        {
            return $"# Lapiz #\n\n Color: {((IAcciones)this).Color}\n Nivel tinta: {((IAcciones)this).UnidadesDeEscritura}";
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            EscrituraWrapper escritura = new EscrituraWrapper(texto, ((IAcciones)this).Color);
            float minaGastada = (float)texto.Length / 100;
            ((IAcciones)this).UnidadesDeEscritura -= minaGastada;

            return escritura;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
    }
}
