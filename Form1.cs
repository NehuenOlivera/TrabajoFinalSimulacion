using EntregaFinalSIM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregaFinalSIM
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

            this.gridSimulaciones.Columns[5].HeaderCell.Style.BackColor = Color.Aquamarine;
            this.gridSimulaciones.Columns[8].HeaderCell.Style.BackColor = Color.Aquamarine;
            this.gridSimulaciones.Columns[9].HeaderCell.Style.BackColor = Color.Aquamarine;
            this.gridSimulaciones.Columns[12].HeaderCell.Style.BackColor = Color.Aquamarine;
            this.gridSimulaciones.Columns[13].HeaderCell.Style.BackColor = Color.Aquamarine;
            this.gridSimulaciones.Columns[14].HeaderCell.Style.BackColor = Color.Aquamarine;
            this.gridSimulaciones.Columns[15].HeaderCell.Style.BackColor = Color.Aquamarine;
            this.gridSimulaciones.RowsDefaultCellStyle.BackColor = Color.White;
            this.gridSimulaciones.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            this.gridArticulosCredito.RowsDefaultCellStyle.BackColor = Color.White;
            this.gridArticulosCredito.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            this.gridArticulosContado.RowsDefaultCellStyle.BackColor = Color.White;
            this.gridArticulosContado.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            this.gridClientes.RowsDefaultCellStyle.BackColor = Color.White;
            this.gridClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

        }

        private Tuple<double, double> generarRandomUniforme(double a, double b)
        {
            double random = rnd.NextDouble();
            return new Tuple<double, double>(random, (b - a) * random + a);
        }
        private void OnClickGenerar(object sender, EventArgs e)
        {
            try
            {
                if (!Int32.TryParse(txtCantidadSimulaciones.Text, out int cantidadSimulaciones))
                {
                    throw new ArgumentException("Debes ingresar un numero valido para la cantidad de simulaciones");
                }
                if (!Int32.TryParse(txtFilaDesde.Text, out int filaDesde))
                {
                    throw new ArgumentException("Debes ingresar un numero valido para la cantidad de filas desde");
                }
                if (!Int32.TryParse(txtFilaHasta.Text, out int filaHasta))
                {
                    throw new ArgumentException("Debes ingresar un numero valido para la cantidad de filas hasta");
                }

                if (filaDesde >= filaHasta)
                {
                    throw new ArgumentException("La fila desde debe ser menor a la fila hasta");
                }

                if (filaDesde < 0 || filaHasta < 0 || cantidadSimulaciones <= 0)
                {
                    throw new ArgumentException("No puedes ingresar parametros negativos");
                }

                if (!Double.TryParse(txtLlegadaClienteMin.Text, out double llegadaClienteMin))
                {
                    throw new ArgumentException("Debes ingresar un valor adecuado para la distribución uniforme");
                }

                if (!Double.TryParse(txtLlegadaClienteMax.Text, out double llegadaClienteMax))
                {
                    throw new ArgumentException("Debes ingresar un valor adecuado para la distribución uniforme");
                }
                if (llegadaClienteMin >= llegadaClienteMax)
                {
                    throw new ArgumentException("El valor desde no puede ser mayor o igual al valor hasta en la distribución uniforme");
                }

                if (!Double.TryParse(txtFinAtencionMin.Text, out double uniformeAtencionMin))
                {
                    throw new ArgumentException("Debes ingresar un valor adecuado para la distribución uniforme");
                }

                if (!Double.TryParse(txtFinAtencionMax.Text, out double uniformeAtencionMax))
                {
                    throw new ArgumentException("Debes ingresar un valor adecuado para la distribución uniforme");
                }
                if (uniformeAtencionMin >= uniformeAtencionMax)
                {
                    throw new ArgumentException("El valor desde no puede ser mayor o igual al valor hasta en la distribución uniforme");
                }

                if (!Double.TryParse(txtFinReparto.Text, out double tiempoFinReparto))
                {
                    throw new ArgumentException("Debes ingresar un tiempo valido para el fin de reparto");
                }
                if (tiempoFinReparto <= 0 )
                {
                    throw new ArgumentException("Debes ingresar un tiempo valido para el fin de reparto");
                }

                if (filaHasta - filaDesde > 500) throw new ArgumentException("No se pueden mostrar mas de 500 filas");

                ////////////////////////////////////////////////////////////////////////////////////

                gridSimulaciones.Rows.Clear();

                gridArticulosCredito.Rows.Clear();
                gridArticulosCredito.Columns.Clear();

                gridArticulosContado.Rows.Clear();
                gridArticulosContado.Columns.Clear();

                gridClientes.Rows.Clear();
                gridClientes.Columns.Clear();

                DataGridViewColumn columnaInicialArtCredito = new DataGridViewColumn();
                columnaInicialArtCredito.Visible = false;
                DataGridViewTextBoxCell celdaArtContado = new DataGridViewTextBoxCell();
                columnaInicialArtCredito.CellTemplate = celdaArtContado;
                gridArticulosCredito.Columns.Add(columnaInicialArtCredito);

                DataGridViewColumn columnaInicialArtContado = new DataGridViewColumn();
                columnaInicialArtContado.Visible = false;
                DataGridViewTextBoxCell celdaArtCredito = new DataGridViewTextBoxCell();
                columnaInicialArtContado.CellTemplate = celdaArtCredito;
                gridArticulosContado.Columns.Add(columnaInicialArtContado);

                DataGridViewColumn columnaInicialCliente = new DataGridViewColumn();
                columnaInicialCliente.Visible = false;
                DataGridViewTextBoxCell celdaCliente = new DataGridViewTextBoxCell();
                columnaInicialCliente.CellTemplate = celdaCliente;
                gridClientes.Columns.Add(columnaInicialCliente);

                Dictionary<Eventos, Nullable<double>> dict = new Dictionary<Eventos, Nullable<double>>();

                Tuple<double, double> randomLlegadaCliente = generarRandomUniforme(llegadaClienteMin, llegadaClienteMax);
                Tuple<double, double> randomFinAtencion = generarRandomUniforme(uniformeAtencionMin, uniformeAtencionMax);
                double randomTipoArticulo;

                // Cola de clientes
                Queue<Cliente> colaClientes = new Queue<Cliente>();

                Vendedor vendedor1 = new Vendedor()
                {
                    estadoVendedor = EstadoVendedor.Libre,
                };

                Vendedor vendedor2 = new Vendedor()
                {
                    estadoVendedor = EstadoVendedor.Libre,
                };

                Repartidor repartidor = new Repartidor()
                {
                    estadoRepartidor = EstadoRepartidor.Libre,
                };

                Fila anterior = new Fila()
                {
                    evento = Eventos.EventoInicial,
                    reloj = 0,
                    rnd_LlegadaCliente = randomLlegadaCliente.Item1,
                    tiempoEntreLlegadasCliente = randomLlegadaCliente.Item2,
                    proxLlegadaCliente = randomLlegadaCliente.Item2 + 0,
                    rnd_FinAtencion = null,
                    tiempoDeAtencion = null,
                    V1_ProxFinAtencion = null,
                    V2_ProxFinAtencion = null,
                    rnd_TipoArticulo = null,
                    tipoArticulo = null,
                    finReparto_A1 = null,
                    finReparto_A2 = null,
                    finReparto_A3 = null,
                    finReparto_A4 = null,
                    vendedor1 = vendedor1,
                    vendedor2 = vendedor2,
                    repartidor = repartidor,
                    acumTiemposDeRepartoCredito = 0,
                    cantArticulosCreditoEntregados = 0
                };
                Fila actual = null;

                dict.Add(Eventos.LlegadaCliente, anterior.proxLlegadaCliente);
                dict.Add(Eventos.FinAtencionV1, null);
                dict.Add(Eventos.FinAtencionV2, null);
                dict.Add(Eventos.FinRepartoArticulo1, null);
                dict.Add(Eventos.FinRepartoArticulo2, null);
                dict.Add(Eventos.FinRepartoArticulo3, null);
                dict.Add(Eventos.FinRepartoArticulo4, null);

                if (filaDesde == 0) gridSimulaciones.Rows.Add(anterior.crearFila());

                int cantidadFinRepartoArtCredito = 0;
                int cantidadFinRepartoArtContado = 0;
                int cantClientesAtendidos = 0;


                for (int i = 0; i < cantidadSimulaciones; i++)
                {
                    List<string> listaClientes = new List<string>();
                    List<string> listaArticulosCredito = new List<string>();
                    List<string> listaArticulosContado = new List<string>();

                    KeyValuePair<Eventos, Nullable<double>> proximoEvento = buscarProximoEvento(actual == null ? 0 : actual.reloj, dict);

                    actual = new Fila()
                    {
                        evento = proximoEvento.Key,
                        reloj = proximoEvento.Value.GetValueOrDefault(0),
                        rnd_LlegadaCliente = null,
                        tiempoEntreLlegadasCliente = null,
                        proxLlegadaCliente = anterior.proxLlegadaCliente,
                        rnd_FinAtencion = null,
                        tiempoDeAtencion = null,
                        V1_ProxFinAtencion = anterior.V1_ProxFinAtencion,
                        V2_ProxFinAtencion = anterior.V2_ProxFinAtencion,
                        rnd_TipoArticulo = null,
                        tipoArticulo = null,
                        finReparto_A1 = anterior.finReparto_A1,
                        finReparto_A2 = anterior.finReparto_A2,
                        finReparto_A3 = anterior.finReparto_A3,
                        finReparto_A4 = anterior.finReparto_A4,
                        vendedor1 = vendedor1,
                        vendedor2 = vendedor2,
                        repartidor = repartidor,
                        acumTiemposDeRepartoCredito = anterior.acumTiemposDeRepartoCredito,
                        cantArticulosCreditoEntregados = anterior.cantArticulosCreditoEntregados,
                    };

                    // EVENTO LLEGADA CLIENTE
                    if (proximoEvento.Key == Eventos.LlegadaCliente)
                    {
                        // Crear cliente que llego
                        Cliente cliente = new Cliente();

                        // Calcular la llegada del cliente que sigue
                        randomLlegadaCliente = generarRandomUniforme(llegadaClienteMin, llegadaClienteMax);

                        actual.rnd_LlegadaCliente = randomLlegadaCliente.Item1;
                        actual.tiempoEntreLlegadasCliente = randomLlegadaCliente.Item2;
                        actual.proxLlegadaCliente = randomLlegadaCliente.Item2 + actual.reloj;

                        // Actualizar el diccionario
                        dict[Eventos.LlegadaCliente] = actual.proxLlegadaCliente;

                        // Ver si lo atienden o si va a la cola
                        if (vendedor1.estadoVendedor == EstadoVendedor.Libre)
                        {
                            // Lo atiende el vendedor 1
                            vendedor1.estadoVendedor = EstadoVendedor.Ocupado;
                            cliente.estado = EstadoCliente.SA;

                            // Calcular tiempo de atencion del vendedor 1
                            randomFinAtencion = generarRandomUniforme(uniformeAtencionMin, uniformeAtencionMax);

                            actual.rnd_FinAtencion = randomFinAtencion.Item1;
                            actual.tiempoDeAtencion = randomFinAtencion.Item2;
                            actual.V1_ProxFinAtencion = randomFinAtencion.Item2 + actual.reloj;

                            // Actualizar diccionario
                            dict[Eventos.FinAtencionV1] = actual.V1_ProxFinAtencion;
                        }
                        else if (vendedor2.estadoVendedor == EstadoVendedor.Libre)
                        {
                            // Lo atiende el vendedor 2
                            vendedor2.estadoVendedor = EstadoVendedor.Ocupado;
                            cliente.estado = EstadoCliente.SA;

                            // Calcular tiempo de atencion del vendedor 2
                            randomFinAtencion = generarRandomUniforme(uniformeAtencionMin, uniformeAtencionMax);

                            actual.rnd_FinAtencion = randomFinAtencion.Item1;
                            actual.tiempoDeAtencion = randomFinAtencion.Item2;
                            actual.V2_ProxFinAtencion = randomFinAtencion.Item2 + actual.reloj;

                            // Actualizar diccionario
                            dict[Eventos.FinAtencionV2] = actual.V2_ProxFinAtencion;
                        }
                        else
                        {
                            // No lo atienden, va a la cola
                            cliente.estado = EstadoCliente.EA;
                            colaClientes.Enqueue(cliente);
                        }
                    }

                    // EVENTO FIN ATENCION V1 O V2
                    else if (proximoEvento.Key == Eventos.FinAtencionV1 || proximoEvento.Key == Eventos.FinAtencionV2)
                    {
                        // El cliente que estaba atendiendo se destruye

                        // El vendedor se fija si hay mas clientes para atender
                        cantClientesAtendidos++;

                        if (colaClientes.Count > 0) // Hay mas clientes que atender
                        {
                            Cliente clienteAtendido = colaClientes.Dequeue();
                            clienteAtendido.SetEstado(EstadoCliente.SA);
                            // Calcular tiempo de atencion del vendedor 1
                            randomFinAtencion = generarRandomUniforme(uniformeAtencionMin, uniformeAtencionMax);

                            actual.rnd_FinAtencion = randomFinAtencion.Item1;
                            actual.tiempoDeAtencion = randomFinAtencion.Item2;

                            if (proximoEvento.Key == Eventos.FinAtencionV1)
                            {
                                actual.V1_ProxFinAtencion = randomFinAtencion.Item2 + actual.reloj;
                                // Actualizar diccionario
                                dict[Eventos.FinAtencionV1] = actual.V1_ProxFinAtencion;
                            }
                            else
                            {
                                actual.V2_ProxFinAtencion = randomFinAtencion.Item2 + actual.reloj;
                                // Actualizar diccionario
                                dict[Eventos.FinAtencionV2] = actual.V2_ProxFinAtencion;
                            }
                        }
                        else // No hay mas clientes para atender
                        {
                            if (proximoEvento.Key == Eventos.FinAtencionV1)
                            {
                                vendedor1.estadoVendedor = EstadoVendedor.Libre;
                                actual.V1_ProxFinAtencion = null;
                                dict[Eventos.FinAtencionV1] = null;
                            }
                            else
                            {
                                vendedor2.estadoVendedor = EstadoVendedor.Libre;
                                actual.V2_ProxFinAtencion = null;
                                dict[Eventos.FinAtencionV2] = null;
                            }
                        }

                        // Se crea un articulo y hay que ver que tipo es
                        double contado = exportarContado();
                        randomTipoArticulo = rnd.NextDouble();
                        Articulo articulo = new Articulo(randomTipoArticulo, actual.reloj, contado);
                        actual.rnd_TipoArticulo = randomTipoArticulo;
                        actual.tipoArticulo = articulo.tipoArt.ToString();

                        // El repartidor estaba libre
                        if(repartidor.estadoRepartidor == EstadoRepartidor.Libre)
                        {
                            // El articulo es tipo CONTADO
                            if (articulo.tipoArt == TipoArticulo.Contado)
                            {
                                // Sale a repartir el articulo 1
                                actual.finReparto_A1 = actual.reloj + tiempoFinReparto;
                                articulo.estado = EstadoArticulo.Repartiendo;
                                repartidor.estadoRepartidor = EstadoRepartidor.Ocupado;
                                repartidor.colaArtRepartiendo.Enqueue(articulo);

                                // Actualizar el diccionario
                                dict[Eventos.FinRepartoArticulo1] = actual.finReparto_A1;
                            }
                            // El articulo es tipo CREDITO
                            if (articulo.tipoArt == TipoArticulo.Credito)
                            {
                                repartidor.colaArtCredito.Enqueue(articulo);

                                if (repartidor.colaArtCredito.Count() == 4) // Se fija si llegan a 4 y tiene que salir
                                {
                                    // Desencolar los que estaban esperando
                                    Articulo articulo1 = repartidor.colaArtCredito.Dequeue();
                                    Articulo articulo2 = repartidor.colaArtCredito.Dequeue();
                                    Articulo articulo3 = repartidor.colaArtCredito.Dequeue();
                                    Articulo articulo4 = repartidor.colaArtCredito.Dequeue();

                                    // Cambian estado a REPARTIENDO
                                    articulo1.SetEstado(EstadoArticulo.Repartiendo);
                                    articulo2.SetEstado(EstadoArticulo.Repartiendo);
                                    articulo3.SetEstado(EstadoArticulo.Repartiendo);
                                    articulo4.SetEstado(EstadoArticulo.Repartiendo);

                                    // Encolarlos en cola de reparticion
                                    repartidor.colaArtRepartiendo.Enqueue(articulo1);
                                    repartidor.colaArtRepartiendo.Enqueue(articulo2);
                                    repartidor.colaArtRepartiendo.Enqueue(articulo3);
                                    repartidor.colaArtRepartiendo.Enqueue(articulo4);

                                    repartidor.estadoRepartidor = EstadoRepartidor.Ocupado;
                                    // Sale a repartir los 4 art CREDITO
                                    actual.finReparto_A1 = actual.reloj + tiempoFinReparto;
                                    actual.finReparto_A2 = actual.finReparto_A1 + tiempoFinReparto;
                                    actual.finReparto_A3 = actual.finReparto_A2 + tiempoFinReparto;
                                    actual.finReparto_A4 = actual.finReparto_A3 + tiempoFinReparto;

                                    // Actualizar diccionario
                                    dict[Eventos.FinRepartoArticulo1] = actual.finReparto_A1;
                                    dict[Eventos.FinRepartoArticulo2] = actual.finReparto_A2;
                                    dict[Eventos.FinRepartoArticulo3] = actual.finReparto_A3;
                                    dict[Eventos.FinRepartoArticulo4] = actual.finReparto_A4;
                                }
                            }
                        }
                            // El repartidor esta ocupado
                        else if(repartidor.estadoRepartidor == EstadoRepartidor.Ocupado)
                        {
                            // CONTADO
                            if (articulo.tipoArt == TipoArticulo.Contado) repartidor.colaArtContado.Enqueue(articulo);
                            // CREDITO
                            else repartidor.colaArtCredito.Enqueue(articulo);
                        }
                    }
                    // EVENTO FIN REPARTO A1 A2 A3 O A4
                    else if (proximoEvento.Key == Eventos.FinRepartoArticulo1 || proximoEvento.Key == Eventos.FinRepartoArticulo2 || proximoEvento.Key == Eventos.FinRepartoArticulo3 || proximoEvento.Key == Eventos.FinRepartoArticulo4)
                    {
                        // Hay que hacer la destruccion del articulo que fue entregado
                        Articulo articuloRepartido = repartidor.colaArtRepartiendo.Dequeue();
                        if (articuloRepartido.tipoArt == TipoArticulo.Credito)
                        {
                            cantidadFinRepartoArtCredito++;
                            actual.acumTiemposDeRepartoCredito += actual.reloj - articuloRepartido.horaCreacion;
                            actual.cantArticulosCreditoEntregados++;
                        }
                        else cantidadFinRepartoArtContado++;
                        
                        if (proximoEvento.Key == Eventos.FinRepartoArticulo1)
                        {
                            actual.finReparto_A1 = null;
                            dict[Eventos.FinRepartoArticulo1] = null;
                        }
                        else if (proximoEvento.Key == Eventos.FinRepartoArticulo2)
                        {
                            actual.finReparto_A2 = null;
                            dict[Eventos.FinRepartoArticulo2] = null;
                        }
                        else if (proximoEvento.Key == Eventos.FinRepartoArticulo3)
                        {
                            actual.finReparto_A3 = null;
                            dict[Eventos.FinRepartoArticulo3] = null;
                        }
                        else if (proximoEvento.Key == Eventos.FinRepartoArticulo4)
                        {
                            actual.finReparto_A4 = null;
                            dict[Eventos.FinRepartoArticulo4] = null;
                        }

                        if (repartidor.colaArtRepartiendo.Count() == 0) // No quedan articulos por repartir en el camion. Vuelve
                        {
                            if (repartidor.colaArtContado.Count() == 1) // Tiene que salir a repartir  1 CONTADO
                            {
                                Articulo articuloARepartir = repartidor.colaArtContado.Dequeue();
                                articuloARepartir.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articuloARepartir);
                                actual.finReparto_A1 = actual.reloj + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo1] = actual.finReparto_A1;
                            }
                            else if (repartidor.colaArtContado.Count() == 2) // Tiene que salir a repartir  2 CONTADO
                            {
                                // Articulo 1
                                Articulo articulo1 = repartidor.colaArtContado.Dequeue();
                                articulo1.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articulo1);
                                actual.finReparto_A1 = actual.reloj + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo1] = actual.finReparto_A1;

                                // Articulo 2
                                Articulo articulo2 = repartidor.colaArtContado.Dequeue();
                                articulo2.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articulo2);
                                actual.finReparto_A2 = actual.finReparto_A1 + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo2] = actual.finReparto_A2;
                            }
                            else if (repartidor.colaArtContado.Count() == 3) // Tiene que salir a repartir  3 CONTADO
                            {
                                // Articulo 1
                                Articulo articulo1 = repartidor.colaArtContado.Dequeue();
                                articulo1.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articulo1);
                                actual.finReparto_A1 = actual.reloj + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo1] = actual.finReparto_A1;

                                // Articulo 2
                                Articulo articulo2 = repartidor.colaArtContado.Dequeue();
                                articulo2.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articulo2);
                                actual.finReparto_A2 = actual.finReparto_A1 + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo2] = actual.finReparto_A2;

                                // Articulo 3
                                Articulo articulo3 = repartidor.colaArtContado.Dequeue();
                                articulo3.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articulo3);
                                actual.finReparto_A3 = actual.finReparto_A2 + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo3] = actual.finReparto_A3;
                            }
                            else if (repartidor.colaArtContado.Count() >= 4) // Tiene que salir a repartir 4 CONTADO
                            {
                                // Articulo 1
                                Articulo articulo1 = repartidor.colaArtContado.Dequeue();
                                articulo1.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articulo1);
                                actual.finReparto_A1 = actual.reloj + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo1] = actual.finReparto_A1;

                                // Articulo 2
                                Articulo articulo2 = repartidor.colaArtContado.Dequeue();
                                articulo2.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articulo2);
                                actual.finReparto_A2 = actual.finReparto_A1 + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo2] = actual.finReparto_A2;

                                // Articulo 3
                                Articulo articulo3 = repartidor.colaArtContado.Dequeue();
                                articulo3.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articulo3);
                                actual.finReparto_A3 = actual.finReparto_A2 + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo3] = actual.finReparto_A3;

                                // Articulo 4
                                Articulo articulo4 = repartidor.colaArtContado.Dequeue();
                                articulo4.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articulo4);
                                actual.finReparto_A4 = actual.finReparto_A3 + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo4] = actual.finReparto_A4;
                            }
                            else if (repartidor.colaArtCredito.Count() >= 4) // Tiene que salir a repartir 4 de CREDITO
                            {
                                // Articulo 1
                                Articulo articulo1 = repartidor.colaArtCredito.Dequeue();
                                articulo1.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articulo1);
                                actual.finReparto_A1 = actual.reloj + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo1] = actual.finReparto_A1;

                                // Articulo 2
                                Articulo articulo2 = repartidor.colaArtCredito.Dequeue();
                                articulo2.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articulo2);
                                actual.finReparto_A2 = actual.finReparto_A1 + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo2] = actual.finReparto_A2;

                                // Articulo 3
                                Articulo articulo3 = repartidor.colaArtCredito.Dequeue();
                                articulo3.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articulo3);
                                actual.finReparto_A3 = actual.finReparto_A2 + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo3] = actual.finReparto_A3;

                                // Articulo 4
                                Articulo articulo4 = repartidor.colaArtCredito.Dequeue();
                                articulo4.SetEstado(EstadoArticulo.Repartiendo);
                                repartidor.colaArtRepartiendo.Enqueue(articulo4);
                                actual.finReparto_A4 = actual.finReparto_A3 + tiempoFinReparto;
                                dict[Eventos.FinRepartoArticulo4] = actual.finReparto_A4;
                            }
                            else
                            {
                                repartidor.SetEstado(EstadoRepartidor.Libre); // No tiene que salir, pasa de ocupado a libre
                            }
                        }
                    }

                    // Cargar grid
                    if ((i >= filaDesde && i < filaHasta) || i == cantidadSimulaciones - 1)
                    {
                        // Mostrar fila
                        this.gridSimulaciones.Rows.Add();
                        int fila = this.gridSimulaciones.Rows.Count - 1;
                        this.gridSimulaciones.Rows[fila].Cells[0].Value = i;
                        this.gridSimulaciones.Rows[fila].Cells[1].Value = actual.evento;
                        this.gridSimulaciones.Rows[fila].Cells[2].Value = actual.reloj.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[3].Value = actual.rnd_LlegadaCliente?.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[4].Value = actual.tiempoEntreLlegadasCliente?.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[5].Value = actual.proxLlegadaCliente.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[6].Value = actual.rnd_FinAtencion?.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[7].Value = actual.tiempoDeAtencion?.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[8].Value = actual.V1_ProxFinAtencion?.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[9].Value = actual.V2_ProxFinAtencion?.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[10].Value = actual.rnd_TipoArticulo?.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[11].Value = actual.tipoArticulo;
                        this.gridSimulaciones.Rows[fila].Cells[12].Value = actual.finReparto_A1?.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[13].Value = actual.finReparto_A2?.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[14].Value = actual.finReparto_A3?.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[15].Value = actual.finReparto_A4?.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[16].Value = actual.vendedor1.GetEstado();
                        this.gridSimulaciones.Rows[fila].Cells[17].Value = actual.vendedor2.GetEstado();
                        this.gridSimulaciones.Rows[fila].Cells[18].Value = colaClientes.Count();
                        this.gridSimulaciones.Rows[fila].Cells[19].Value = actual.repartidor.GetEstado();
                        this.gridSimulaciones.Rows[fila].Cells[20].Value = actual.repartidor.colaArtContado.Count();
                        this.gridSimulaciones.Rows[fila].Cells[21].Value = actual.repartidor.colaArtCredito.Count();
                        this.gridSimulaciones.Rows[fila].Cells[22].Value = actual.repartidor.colaArtRepartiendo.Count();
                        this.gridSimulaciones.Rows[fila].Cells[23].Value = actual.acumTiemposDeRepartoCredito.ToString("F4");
                        this.gridSimulaciones.Rows[fila].Cells[24].Value = actual.cantArticulosCreditoEntregados;

                        if (i == cantidadSimulaciones - 1) continue;

                        for (int k = 0; k < cantidadFinRepartoArtCredito; k++)
                        {   // por cada fin reparto del articulo CREDITO agrego una cadena vacia "matar objeto"
                            listaArticulosCredito.Add("");
                            listaArticulosCredito.Add("");
                            listaArticulosCredito.Add("");
                        }

                        for (int k = 0; k < cantidadFinRepartoArtContado; k++)
                        {   // por cada fin reparto del articulo CONTADO agrego una cadena vacia "matar objeto"
                            listaArticulosContado.Add("");
                            listaArticulosContado.Add("");
                            listaArticulosContado.Add("");
                        }

                        for (int k = 0; k < cantClientesAtendidos; k++)
                        {
                            listaClientes.Add("");
                        }

                        // Agregar los que estan siendo repartidos DEL TIPO CREDITO
                        if (repartidor.colaArtRepartiendo.Count > 0 && repartidor.colaArtRepartiendo.Peek().tipoArt == TipoArticulo.Credito)
                        {
                            List<Articulo> tempArticulosSiendoRepartidos = repartidor.colaArtRepartiendo.ToList();
                            for (int y = 0; y < tempArticulosSiendoRepartidos.Count; y++)
                            {
                                //por cada elemento de la cola agrego TODOS LOS DATOS como string a la lista...
                                listaArticulosCredito.Add(tempArticulosSiendoRepartidos[y].estado.ToString());
                                listaArticulosCredito.Add(tempArticulosSiendoRepartidos[y].tipoArt.ToString());
                                listaArticulosCredito.Add(tempArticulosSiendoRepartidos[y].horaCreacion.ToString("F4"));
                            }
                        }
                        // Agregar los que estan siendo repartidos DEL TIPO CONTADO
                        if (repartidor.colaArtRepartiendo.Count > 0 && repartidor.colaArtRepartiendo.Peek().tipoArt == TipoArticulo.Contado)
                        {
                            List<Articulo> tempArticulosSiendoRepartidos = repartidor.colaArtRepartiendo.ToList();
                            for (int y = 0; y < tempArticulosSiendoRepartidos.Count; y++)
                            {
                                //por cada elemento de la cola agrego TODOS LOS DATOS como string a la lista...
                                listaArticulosContado.Add(tempArticulosSiendoRepartidos[y].estado.ToString());
                                listaArticulosContado.Add(tempArticulosSiendoRepartidos[y].tipoArt.ToString());
                                listaArticulosContado.Add(tempArticulosSiendoRepartidos[y].horaCreacion.ToString("F4"));
                            }
                        }
                        // Agregar cliente que esta siendo atendido por el Vendedor1
                        if (vendedor1.estadoVendedor == EstadoVendedor.Ocupado)
                        {
                            listaClientes.Add("SA");
                        }
                        if (vendedor2.estadoVendedor == EstadoVendedor.Ocupado)
                        {
                            listaClientes.Add("SA");
                        }


                        // Agregar los que estan esperando reparticion de CREDITO
                        List<Articulo> tempArticulosCreditoEspReparticion = repartidor.colaArtCredito.ToList();
                        for (int k = 0; k < tempArticulosCreditoEspReparticion.Count; k++)
                        {
                            //por cada elemento de la cola agrego TODOS LOS DATOS como string a la lista...
                            listaArticulosCredito.Add(tempArticulosCreditoEspReparticion[k].estado.ToString());
                            listaArticulosCredito.Add(tempArticulosCreditoEspReparticion[k].tipoArt.ToString());
                            listaArticulosCredito.Add(tempArticulosCreditoEspReparticion[k].horaCreacion.ToString("F4"));
                        }
                        // Agregar los que estan esperando reparticion de CONTADO
                        List<Articulo> tempArticulosContadoEspReparticion = repartidor.colaArtContado.ToList();
                        for (int k = 0; k < tempArticulosContadoEspReparticion.Count; k++)
                        {
                            //por cada elemento de la cola agrego TODOS LOS DATOS como string a la lista...
                            listaArticulosContado.Add(tempArticulosContadoEspReparticion[k].estado.ToString());
                            listaArticulosContado.Add(tempArticulosContadoEspReparticion[k].tipoArt.ToString());
                            listaArticulosContado.Add(tempArticulosContadoEspReparticion[k].horaCreacion.ToString("F4"));
                        }

                        // Agregar a los clientes que estan esperando ser atendidos
                        List<Cliente> tempClientesEsperandoAtencion = colaClientes.ToList();
                        for (int k = 0; k < tempClientesEsperandoAtencion.Count(); k++)
                        {
                            listaClientes.Add(tempClientesEsperandoAtencion[k].estado.ToString());
                        }

                        while (gridArticulosCredito.Columns.Count - 1 < listaArticulosCredito.Count)
                        {
                            int nroDeArticulo = gridArticulosCredito.Columns.Count/3 + 1;
                            // ESTADO
                            DataGridViewColumn nuevaColumnaEstado = new DataGridViewColumn();
                            nuevaColumnaEstado.Width = 70;
                            nuevaColumnaEstado.HeaderText = $" Estado Articulo-{nroDeArticulo} credito ";
                            DataGridViewTextBoxCell celdaEstado = new DataGridViewTextBoxCell();
                            nuevaColumnaEstado.CellTemplate = celdaEstado;
                            gridArticulosCredito.Columns.Add(nuevaColumnaEstado);
                            // TIPO DE PAGO
                            DataGridViewColumn nuevaColumnaTipoPago = new DataGridViewColumn();
                            nuevaColumnaTipoPago.Width = 55;
                            nuevaColumnaTipoPago.HeaderText = $" Tipo de pago Articulo-{nroDeArticulo} credito ";
                            DataGridViewTextBoxCell celdaTipoPago = new DataGridViewTextBoxCell();
                            nuevaColumnaTipoPago.CellTemplate = celdaTipoPago;
                            gridArticulosCredito.Columns.Add(nuevaColumnaTipoPago);
                            // HORA DE CREACION
                            DataGridViewColumn nuevaColumnaHoraCreacion = new DataGridViewColumn();
                            nuevaColumnaHoraCreacion.HeaderText = $" Hora creacion Articulo-{nroDeArticulo} credito ";
                            DataGridViewTextBoxCell celdaHoraCreacion = new DataGridViewTextBoxCell();
                            nuevaColumnaHoraCreacion.CellTemplate = celdaHoraCreacion;
                            gridArticulosCredito.Columns.Add(nuevaColumnaHoraCreacion);
                        }
                        while (gridArticulosContado.Columns.Count - 1 < listaArticulosContado.Count)
                        {
                            int nroDeArticulo = gridArticulosContado.Columns.Count / 3 + 1;
                            // ESTADO
                            DataGridViewColumn nuevaColumnaEstado = new DataGridViewColumn();
                            nuevaColumnaEstado.Width = 70;
                            nuevaColumnaEstado.HeaderText = $" Estado Articulo-{nroDeArticulo} contado ";
                            DataGridViewTextBoxCell celdaEstado = new DataGridViewTextBoxCell();
                            nuevaColumnaEstado.CellTemplate = celdaEstado;
                            gridArticulosContado.Columns.Add(nuevaColumnaEstado);
                            // TIPO DE PAGO
                            DataGridViewColumn nuevaColumnaTipoPago = new DataGridViewColumn();
                            nuevaColumnaTipoPago.Width = 55;
                            nuevaColumnaTipoPago.HeaderText = $" Tipo de pago Articulo-{nroDeArticulo} contado ";
                            DataGridViewTextBoxCell celdaTipoPago = new DataGridViewTextBoxCell();
                            nuevaColumnaTipoPago.CellTemplate = celdaTipoPago;
                            gridArticulosContado.Columns.Add(nuevaColumnaTipoPago);
                            // HORA DE CREACION
                            DataGridViewColumn nuevaColumnaHoraCreacion = new DataGridViewColumn();
                            nuevaColumnaHoraCreacion.HeaderText = $" Hora creacion Articulo-{nroDeArticulo} contado ";
                            DataGridViewTextBoxCell celdaHoraCreacion = new DataGridViewTextBoxCell();
                            nuevaColumnaHoraCreacion.CellTemplate = celdaHoraCreacion;
                            gridArticulosContado.Columns.Add(nuevaColumnaHoraCreacion);
                        }
                        
                        while (gridClientes.Columns.Count - 1 < listaClientes.Count)
                        {
                            int nroCliente = gridClientes.Columns.Count;
                            // ESTADO
                            DataGridViewColumn nuevaColumnaEstado = new DataGridViewColumn();
                            nuevaColumnaEstado.Width = 55;
                            nuevaColumnaEstado.HeaderText = $" Estado Cliente {nroCliente} ";
                            DataGridViewTextBoxCell celdaEstado = new DataGridViewTextBoxCell();
                            nuevaColumnaEstado.CellTemplate = celdaEstado;
                            gridClientes.Columns.Add(nuevaColumnaEstado);
                        }

                            if ((i == 0 || i == filaDesde) && filaDesde == 0)
                        {
                            this.gridArticulosCredito.Rows.Add();
                            this.gridArticulosContado.Rows.Add();
                            this.gridClientes.Rows.Add();
                        }
                        this.gridArticulosCredito.Rows.Add();
                        this.gridArticulosContado.Rows.Add();
                        this.gridClientes.Rows.Add();

                        for (int p = 0; p < listaArticulosCredito.Count; p++)
                        {
                            gridArticulosCredito.Rows[gridArticulosCredito.Rows.Count - 1].Cells[p+1].Value = listaArticulosCredito[p];
                        }
                        for (int p = 0; p < listaArticulosContado.Count; p++)
                        {
                            gridArticulosContado.Rows[gridArticulosContado.Rows.Count - 1].Cells[p+1].Value = listaArticulosContado[p];
                        }
                        for (int p = 0; p < listaClientes.Count; p++)
                        {
                            gridClientes.Rows[gridClientes.Rows.Count - 1].Cells[p+1].Value = listaClientes[p];
                        }

                        proximoEvento = buscarProximoEvento(actual.reloj, dict); 
                        if (proximoEvento.Key == Eventos.LlegadaCliente) gridSimulaciones.Rows[fila].Cells[5].Style.ForeColor = Color.Red;
                        if (proximoEvento.Key == Eventos.FinAtencionV1) gridSimulaciones.Rows[fila].Cells[8].Style.ForeColor = Color.Red;
                        if (proximoEvento.Key == Eventos.FinAtencionV2) gridSimulaciones.Rows[fila].Cells[9].Style.ForeColor = Color.Red;
                        if (proximoEvento.Key == Eventos.FinRepartoArticulo1) gridSimulaciones.Rows[fila].Cells[12].Style.ForeColor = Color.Red;
                        if (proximoEvento.Key == Eventos.FinRepartoArticulo2) gridSimulaciones.Rows[fila].Cells[13].Style.ForeColor = Color.Red;
                        if (proximoEvento.Key == Eventos.FinRepartoArticulo3) gridSimulaciones.Rows[fila].Cells[14].Style.ForeColor = Color.Red;
                        if (proximoEvento.Key == Eventos.FinRepartoArticulo4) gridSimulaciones.Rows[fila].Cells[15].Style.ForeColor = Color.Red;
                    }
                    anterior = actual;
                }
                this.gridArticulosCredito.Rows.Add();
                this.gridArticulosContado.Rows.Add();
                this.gridClientes.Rows.Add();

                this.gridSimulaciones.Rows[this.gridSimulaciones.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gold;
                lblResultado.Text = (actual.cantArticulosCreditoEntregados > 0 ? (actual.acumTiemposDeRepartoCredito / actual.cantArticulosCreditoEntregados).ToString("F4")+" min" : "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public KeyValuePair<Eventos, Nullable<double>> buscarProximoEvento(double reloj, Dictionary<Eventos, Nullable<double>> dictionary)
        {
            return dictionary.OrderBy(kvp => kvp.Value).Where(kvp => kvp.Value != null && kvp.Value != reloj).First();
        }

      
        public void onBtnCalcularClick(object sender, EventArgs e)
        {
            try
            {
                if (!Double.TryParse(txtProbContado.Text, out double probCredito))
                {
                    throw new ArgumentException("Debes ingresar un valor adecuado para la probabilidad de credito");
                }
                if (probCredito <= 0)
                {
                    throw new ArgumentException("El valor de la probabilidad credito no puede ser menor o igual a cero");
                }
                if (probCredito >= 1)
                {
                    throw new ArgumentException("El valor de la probabilidad credito no puede ser mayor o igual a uno");
                }
                txtProbCredito.Text = (1 - double.Parse(txtProbContado.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error con el calculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public double exportarContado()
        {
            string d = txtProbContado.Text.Replace(",", ".");
            double a = double.Parse(d, CultureInfo.InvariantCulture);
            return a; 
        }

        private void ColumnAddedGridCredito(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.FillWeight = 1;
        }

        private void ColumnAddedGridContado(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.FillWeight = 1;
        }

        private void OnGridSimulacionesScroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                this.gridArticulosCredito.FirstDisplayedScrollingRowIndex = this.gridSimulaciones.FirstDisplayedScrollingRowIndex;
                this.gridArticulosContado.FirstDisplayedScrollingRowIndex = this.gridSimulaciones.FirstDisplayedScrollingRowIndex;
                this.gridClientes.FirstDisplayedScrollingRowIndex = this.gridSimulaciones.FirstDisplayedScrollingRowIndex;
            }
        }
    }
}
