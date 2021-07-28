using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaFinalSIM.Clases
{
    enum EstadoVendedor
    {
        Libre,
        Ocupado,
    }
    class Vendedor
    {
        public EstadoVendedor estadoVendedor;

        // Existen 2 vendedores que atienden una misma fila de clientes

        public Vendedor(EstadoVendedor estadoVendedor)
        {
            this.estadoVendedor = estadoVendedor;
        }

        public Vendedor()
        {
        }
        public void SetEstado(EstadoVendedor estado)
        {
            this.estadoVendedor = estado;
        }
        public string GetEstado()
        {
            switch(this.estadoVendedor)
            {
                case EstadoVendedor.Libre:
                    return "Libre";
                case EstadoVendedor.Ocupado:
                    return "Ocupado";
                default:
                    return "";
            }
        }
    }
}
