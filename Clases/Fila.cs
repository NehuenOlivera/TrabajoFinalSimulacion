using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregaFinalSIM.Clases
{
    public enum Eventos
    {
        EventoInicial,
        LlegadaCliente,
        FinAtencionV1,
        FinAtencionV2,
        FinRepartoArticulo1,
        FinRepartoArticulo2,
        FinRepartoArticulo3,
        FinRepartoArticulo4,
    }
    class Fila
    {
        public string fila { get; set; }
        public Eventos evento { get; set; }
        public double reloj { get; set; }
        public Nullable<double> rnd_LlegadaCliente { get; set; }
        public Nullable<double> tiempoEntreLlegadasCliente { get; set; }
        public double proxLlegadaCliente { get; set; }
        public Nullable<double> rnd_FinAtencion { get; set; }
        public Nullable<double> tiempoDeAtencion { get; set; }
        public Nullable<double> V1_ProxFinAtencion { get; set; }
        public Nullable<double> V2_ProxFinAtencion { get; set; }
        public Nullable<double> rnd_TipoArticulo { get; set; }
        public string tipoArticulo { get; set; }
        public Nullable<double> finReparto_A1 { get; set; }
        public Nullable<double> finReparto_A2 { get; set; }
        public Nullable<double> finReparto_A3 { get; set; }
        public Nullable<double> finReparto_A4 { get; set; }
        public Vendedor vendedor1 { get; set; }
        public Vendedor vendedor2 { get; set; }
        public int colaDeClientes { get; set; }
        public Repartidor repartidor { get; set; }
        public double acumTiemposDeRepartoCredito { get; set; }
        public int cantArticulosCreditoEntregados { get; set; }



        public Fila(Eventos evento, double reloj, double rnd_LlegadaCliente, double tiempoEntreLlegadasCliente, double proxLlegadaCliente,
                double rnd_FinAtencion,
                double tiempoDeAtencion,
                double V1_ProxFinAtencion,
                double V2_ProxFinAtencion,
                double rnd_TipoArticulo,
                string tipoArticulo,
                double finReparto_A1,
                double finReparto_A2,
                double finReparto_A3,
                double finReparto_A4,
                Vendedor vendedor1,
                Vendedor vendedor2,
                int colaDeClientes,
                Repartidor repartidor,
                double acumTiemposDeRepartoCredito,
                int cantArticulosCreditoEntregados)
        {
            this.evento = evento;
            this.reloj = reloj;
            this.rnd_LlegadaCliente = rnd_LlegadaCliente;
            this.tiempoEntreLlegadasCliente = tiempoEntreLlegadasCliente;
            this.proxLlegadaCliente = proxLlegadaCliente;
            this.rnd_FinAtencion = rnd_FinAtencion;
            this.tiempoDeAtencion = tiempoDeAtencion;
            this.V1_ProxFinAtencion = V1_ProxFinAtencion;
            this.V2_ProxFinAtencion = V2_ProxFinAtencion;
            this.rnd_TipoArticulo = rnd_TipoArticulo;
            this.tipoArticulo = tipoArticulo;
            this.finReparto_A1 = finReparto_A1;
            this.finReparto_A2 = finReparto_A2;
            this.finReparto_A3 = finReparto_A3;
            this.finReparto_A4 = finReparto_A4;
            this.vendedor1 = vendedor1;
            this.vendedor2 = vendedor2;
            this.colaDeClientes = colaDeClientes;
            this.repartidor = repartidor;
            this.acumTiemposDeRepartoCredito = acumTiemposDeRepartoCredito;
            this.cantArticulosCreditoEntregados = cantArticulosCreditoEntregados;
        }
        public Fila()
        {
        }

        public DataGridViewRow crearFila()
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell filaCell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell evento = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell reloj = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell rnd_LlegadaCliente = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell tiempoEntreLlegadasCliente = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell proxLlegadaCliente = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell rnd_FinAtencion = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell tiempoDeAtencion = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell V1_ProxFinAtencion = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell V2_ProxFinAtencion = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell rnd_TipoArticulo = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell tipoArticulo = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell finReparto_A1 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell finReparto_A2 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell finReparto_A3 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell finReparto_A4 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell vendedor1_estado = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell vendedor2_estado = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colaDeClientes = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell repartidor_estado = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell repartidor_colaArticulosContado = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell repartidor_colaArticulosCredito = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell repartidor_colaArticulosSiendoRepartidos = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell acumTiemposDeRepartoCredito = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell cantArticulosCreditoEntregados = new DataGridViewTextBoxCell();

            filaCell.Value = this.fila;
            evento.Value = this.evento;
            reloj.Value = this.reloj.ToString("F4");
            rnd_LlegadaCliente.Value = this.rnd_LlegadaCliente?.ToString("F4");
            tiempoEntreLlegadasCliente.Value = this.tiempoEntreLlegadasCliente?.ToString("F4");
            proxLlegadaCliente.Value = this.proxLlegadaCliente.ToString("F4");
            rnd_FinAtencion.Value = this.rnd_FinAtencion?.ToString("F4");
            tiempoDeAtencion.Value = this.tiempoDeAtencion?.ToString("F4");
            V1_ProxFinAtencion.Value = this.V1_ProxFinAtencion?.ToString("F4");
            V2_ProxFinAtencion.Value = this.V2_ProxFinAtencion?.ToString("F4");
            rnd_TipoArticulo.Value = this.rnd_TipoArticulo?.ToString("F4");
            tipoArticulo.Value = this.tipoArticulo;
            finReparto_A1.Value = this.finReparto_A1?.ToString("F4");
            finReparto_A2.Value = this.finReparto_A2?.ToString("F4");
            finReparto_A3.Value = this.finReparto_A3?.ToString("F4");
            finReparto_A4.Value = this.finReparto_A4?.ToString("F4");

            vendedor1_estado.Value = this.vendedor1.GetEstado();
            vendedor2_estado.Value = this.vendedor2.GetEstado();
            colaDeClientes.Value = this.colaDeClientes;

            repartidor_estado.Value = this.repartidor.GetEstado();
            repartidor_colaArticulosContado.Value = this.repartidor.colaArtContado.Count;
            repartidor_colaArticulosCredito.Value = this.repartidor.colaArtCredito.Count;
            repartidor_colaArticulosSiendoRepartidos.Value = this.repartidor.colaArtRepartiendo.Count;

            acumTiemposDeRepartoCredito.Value = this.acumTiemposDeRepartoCredito;
            cantArticulosCreditoEntregados.Value = this.cantArticulosCreditoEntregados;

            //
            fila.Cells.Add(filaCell);
            fila.Cells.Add(evento);
            fila.Cells.Add(reloj);
            fila.Cells.Add(rnd_LlegadaCliente);
            fila.Cells.Add(tiempoEntreLlegadasCliente);
            fila.Cells.Add(proxLlegadaCliente);
            fila.Cells.Add(rnd_FinAtencion);
            fila.Cells.Add(tiempoDeAtencion);
            fila.Cells.Add(V1_ProxFinAtencion);
            fila.Cells.Add(V2_ProxFinAtencion);
            fila.Cells.Add(rnd_TipoArticulo);
            fila.Cells.Add(tipoArticulo);
            fila.Cells.Add(finReparto_A1);
            fila.Cells.Add(finReparto_A2);
            fila.Cells.Add(finReparto_A3);
            fila.Cells.Add(finReparto_A4);
            fila.Cells.Add(vendedor1_estado);
            fila.Cells.Add(vendedor2_estado);
            fila.Cells.Add(colaDeClientes);
            fila.Cells.Add(repartidor_estado);
            fila.Cells.Add(repartidor_colaArticulosContado);
            fila.Cells.Add(repartidor_colaArticulosCredito);
            fila.Cells.Add(repartidor_colaArticulosSiendoRepartidos);
            fila.Cells.Add(acumTiemposDeRepartoCredito);
            fila.Cells.Add(cantArticulosCreditoEntregados);

            return fila;





        }
    }
}
