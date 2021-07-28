using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaFinalSIM.Clases
{
    enum EstadoCliente
    {
        SA,
        EA,
    }
    class Cliente
    {
        public EstadoCliente estado;

        public Cliente(EstadoCliente estado)
        {
            this.estado = estado;
        }

        public Cliente()
        {

        }

        public Cliente SetEstado(EstadoCliente estado)
        {
            this.estado = estado;
            return this;
        }
    }
}
