using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Testing_Truck_Movement
{
    public class Truck
    {
        public event InformacionAvance InformarAvance;
        public event InformacionEntregado InformarEntrega;

        public delegate void InformacionAvance();
        public delegate void InformacionEntregado(string mensaje, int estadoEntrega);

        private string patente;
        //private Cliente cliente;
        private int recorrido;
        private int cantidadPedidos;
        private int puntoPartida;
        private int ubicacion;
        private static int velocidad;

        public string Patente { get => patente; set => patente = value; }
        //public Cliente Cliente { get => cliente; set => cliente = value; }
        public int Ubicacion { get => ubicacion; set => ubicacion = value; }
        public static int Velocidad { get => velocidad; set => velocidad = value; }
        public int Recorrido { get => recorrido; set => recorrido = value; }
        public int CantidadPedidos { get => cantidadPedidos; set => cantidadPedidos = value; }
        public int PuntoPartida { get => puntoPartida; set => puntoPartida = value; }

        static Truck() 
        {
            velocidad = 3;
        }
        public Truck(string patente, int cantidadPedidos, int recorrido, int puntoPartida)
        {
            this.patente = patente;
            //this.cliente = cliente;
            this.Recorrido = recorrido;
            this.puntoPartida = puntoPartida;
            this.ubicacion = puntoPartida;
            this.cantidadPedidos = cantidadPedidos;
        }

        public void Acelerar() 
        {
            this.Ubicacion += velocidad;
        }
        public override string ToString()
        {
            return "Entregado al cliente Ezequiel";
        }

        public void InitializeDeliveries(CancellationToken cancellationToken) 
        {
            if (this.InformarAvance != null) 
            {
                while (!cancellationToken.IsCancellationRequested) 
                {

                    this.Acelerar();
                    this.InformarAvance.Invoke();
                    Thread.Sleep(20 + Truck.velocidad);
                    if (this.puntoPartida > this.Recorrido)
                    {
                        if (this.InformarEntrega != null)
                        {
                            this.InformarEntrega.Invoke(this.ToString(), new Random().Next(0, 2));
                            this.CantidadPedidos--;

                        }
                    }
                    this.puntoPartida++;

                }
            }
        }
    }
}
