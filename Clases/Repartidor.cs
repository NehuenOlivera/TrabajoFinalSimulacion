using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaFinalSIM.Clases
{
    enum EstadoRepartidor
    {
        Libre,
        Ocupado,
    }
    class Repartidor
    {
        public EstadoRepartidor estadoRepartidor;

        public Queue<Articulo> colaArtCredito = new Queue<Articulo>();
        public Queue<Articulo> colaArtContado = new Queue<Articulo>();
        public Queue<Articulo> colaArtRepartiendo = new Queue<Articulo>();

        public Repartidor(EstadoRepartidor estadoRepartidor)
        {
            this.estadoRepartidor = estadoRepartidor;
        }

        public Repartidor()
        {
        }

        public void SetEstado(EstadoRepartidor estado)
        {
            this.estadoRepartidor = estado;
        }

        public string GetEstado()
        {
            switch (this.estadoRepartidor)
            {
                case EstadoRepartidor.Libre:
                    return "Libre";
                case EstadoRepartidor.Ocupado:
                    return "Ocupado";
                default:
                    return "";
            }
        }
    }
}
