using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion
    {
        public event InformacionAvance InformarAvance;
        public event InformacionEntregado InformarEntrega;
        public event PedidoEntregado CobraPedido;

        public delegate void PedidoEntregado(Factura factura);
        public delegate void InformacionAvance();
        public delegate void InformacionEntregado(string mensaje);

        private string patente;
        private int recorrido;
        private int kms;
        private int ubicacion;
        private static int velocidad;
        private List<Factura> facturas;

        public string Patente { get => patente; set => patente = value; }
        public int Ubicacion { get => ubicacion; set => ubicacion = value; }
        public static int Velocidad { get => velocidad; set => velocidad = value; }
        public int Recorrido { get => recorrido; set => recorrido = value; }
        public int Kms { get => kms; set => kms = value; }

        static Camion()
        {
            velocidad = 3;
        }
        public Camion(string patente, List<Factura> facturas, int kms, int puntoPartida)
        {
            this.facturas = facturas;
            this.patente = patente;
            this.kms = kms;
            this.Ubicacion = puntoPartida;
        }

        /// <summary>
        /// Simula la aceleracion del camion
        /// </summary>
        public void Acelerar()
        {
            this.Ubicacion += velocidad;
        }

        public override string ToString()
        {
            return "Entregas finalizadas!";
        }

        /// <summary>
        /// Inicializa el camion. Se invoca al evento CobrarPedido si hay facturas en la lista, y una vez que el camion haga
        /// el recorrido se invocara el evento InformarEntrega
        /// </summary>
        /// <param name="cancellationToken">Cancela la tarea</param>
        public void InitializeDeliveries(CancellationToken cancellationToken)
        {
            int count = this.facturas.Count;
            if (this.InformarAvance != null)
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    this.Acelerar();
                    this.InformarAvance.Invoke();
                    Thread.Sleep(20 + Camion.velocidad);

                    count--;
                    if (count >= 0) 
                    {
                        this.CobraPedido.Invoke(this.facturas[count]);
                    }

                    if (this.Recorrido > 400 && count < 1)
                    {

                        if (this.InformarEntrega != null)
                        {
                            this.InformarEntrega.Invoke(this.ToString());

                        }
                    }
                    this.Recorrido++;

                }
            }
        }
    }
}
