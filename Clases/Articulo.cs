using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaFinalSIM.Clases
{

    

    enum EstadoArticulo
    {
        Repartiendo,
        Esperando,
    }

    enum TipoArticulo
    {
        Credito,
        Contado,
    }
    class Articulo
    {
        static Random rand = new Random();
       

        public EstadoArticulo estado;
        public TipoArticulo tipoArt;
        public double horaCreacion;

        public Articulo(EstadoArticulo estado, double horaCreacion, TipoArticulo tipoArticulo)
        {
            this.estado = estado;
            this.horaCreacion = horaCreacion;
            this.tipoArt = tipoArticulo;
        }

        public Articulo(double random, double horaCreacion, double contado)
        {

            this.estado = EstadoArticulo.Esperando;
            this.horaCreacion = horaCreacion;
            this.tipoArt = (random >= contado) ? TipoArticulo.Credito : TipoArticulo.Contado;
        }

        public Articulo SetEstado(EstadoArticulo estado)
        {
            this.estado = estado;
            return this;
        }

        public Articulo SetTipoArticulo(TipoArticulo tipoArticulo)
        {
            this.tipoArt = tipoArticulo;
            return this;
        }

        /*public Articulo DestruirArticulo()
        {
            this.estado = null;
            this.tipoArt = null;
            this.horaCreacion = null;
        }*/

        
    }
}
