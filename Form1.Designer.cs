namespace EntregaFinalSIM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gridSimulaciones = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRndLlegadaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempoEntreLlegadasCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProximaLlegadaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRndFinAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempoDeAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProximoFinAtencionV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProximoFinAtencionV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRndOpcionPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpcionDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinRepartoA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinRepartoA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinRepartoA3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinRepartoA4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoVendedor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoVendedor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColaDeClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoRepartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticulosAlContado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticulosCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticulosSiendoRepartidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcumTiemposDeRepartoCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadArticulosCreditoEntregados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLlegadaClienteMin = new System.Windows.Forms.TextBox();
            this.txtLlegadaClienteMax = new System.Windows.Forms.TextBox();
            this.txtFinAtencionMax = new System.Windows.Forms.TextBox();
            this.txtFinAtencionMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinReparto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBoxObjetos = new System.Windows.Forms.GroupBox();
            this.groupBoxEventos = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerarSimulacion = new System.Windows.Forms.Button();
            this.txtFilaHasta = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFilaDesde = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantidadSimulaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpcionDePago = new System.Windows.Forms.Button();
            this.txtProbCredito = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtProbContado = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.lblTituloResultado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gridArticulosCredito = new System.Windows.Forms.DataGridView();
            this.gridArticulosContado = new System.Windows.Forms.DataGridView();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSimulaciones)).BeginInit();
            this.groupBoxObjetos.SuspendLayout();
            this.groupBoxEventos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosContado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LlegadaCliente";
            // 
            // gridSimulaciones
            // 
            this.gridSimulaciones.AllowUserToAddRows = false;
            this.gridSimulaciones.AllowUserToDeleteRows = false;
            this.gridSimulaciones.AllowUserToResizeColumns = false;
            this.gridSimulaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridSimulaciones.ColumnHeadersHeight = 75;
            this.gridSimulaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colEvento,
            this.colReloj,
            this.colRndLlegadaCliente,
            this.colTiempoEntreLlegadasCliente,
            this.colProximaLlegadaCliente,
            this.colRndFinAtencion,
            this.colTiempoDeAtencion,
            this.colProximoFinAtencionV1,
            this.colProximoFinAtencionV2,
            this.colRndOpcionPago,
            this.colOpcionDePago,
            this.colFinRepartoA1,
            this.colFinRepartoA2,
            this.colFinRepartoA3,
            this.colFinRepartoA4,
            this.colEstadoVendedor1,
            this.colEstadoVendedor2,
            this.colColaDeClientes,
            this.colEstadoRepartidor,
            this.colArticulosAlContado,
            this.colArticulosCredito,
            this.colArticulosSiendoRepartidos,
            this.colAcumTiemposDeRepartoCredito,
            this.colCantidadArticulosCreditoEntregados});
            this.gridSimulaciones.EnableHeadersVisualStyles = false;
            this.gridSimulaciones.Location = new System.Drawing.Point(3, 386);
            this.gridSimulaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridSimulaciones.Name = "gridSimulaciones";
            this.gridSimulaciones.ReadOnly = true;
            this.gridSimulaciones.RowHeadersWidth = 20;
            this.gridSimulaciones.RowTemplate.Height = 24;
            this.gridSimulaciones.Size = new System.Drawing.Size(1125, 551);
            this.gridSimulaciones.TabIndex = 1;
            this.gridSimulaciones.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OnGridSimulacionesScroll);
            // 
            // colNro
            // 
            this.colNro.Frozen = true;
            this.colNro.HeaderText = "Nro";
            this.colNro.MinimumWidth = 6;
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            this.colNro.Width = 70;
            // 
            // colEvento
            // 
            this.colEvento.Frozen = true;
            this.colEvento.HeaderText = "Evento";
            this.colEvento.MinimumWidth = 6;
            this.colEvento.Name = "colEvento";
            this.colEvento.ReadOnly = true;
            this.colEvento.Width = 125;
            // 
            // colReloj
            // 
            this.colReloj.Frozen = true;
            this.colReloj.HeaderText = "Reloj (min)";
            this.colReloj.MinimumWidth = 6;
            this.colReloj.Name = "colReloj";
            this.colReloj.ReadOnly = true;
            this.colReloj.Width = 125;
            // 
            // colRndLlegadaCliente
            // 
            this.colRndLlegadaCliente.HeaderText = "RND llegada cliente";
            this.colRndLlegadaCliente.MinimumWidth = 6;
            this.colRndLlegadaCliente.Name = "colRndLlegadaCliente";
            this.colRndLlegadaCliente.ReadOnly = true;
            this.colRndLlegadaCliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colRndLlegadaCliente.Width = 45;
            // 
            // colTiempoEntreLlegadasCliente
            // 
            this.colTiempoEntreLlegadasCliente.HeaderText = "Tiempo entre llegadas";
            this.colTiempoEntreLlegadasCliente.MinimumWidth = 6;
            this.colTiempoEntreLlegadasCliente.Name = "colTiempoEntreLlegadasCliente";
            this.colTiempoEntreLlegadasCliente.ReadOnly = true;
            this.colTiempoEntreLlegadasCliente.Width = 70;
            // 
            // colProximaLlegadaCliente
            // 
            this.colProximaLlegadaCliente.HeaderText = "Proxima llegada cliente";
            this.colProximaLlegadaCliente.MinimumWidth = 6;
            this.colProximaLlegadaCliente.Name = "colProximaLlegadaCliente";
            this.colProximaLlegadaCliente.ReadOnly = true;
            this.colProximaLlegadaCliente.Width = 125;
            // 
            // colRndFinAtencion
            // 
            this.colRndFinAtencion.HeaderText = "RND fin atencion";
            this.colRndFinAtencion.MinimumWidth = 6;
            this.colRndFinAtencion.Name = "colRndFinAtencion";
            this.colRndFinAtencion.ReadOnly = true;
            this.colRndFinAtencion.Width = 45;
            // 
            // colTiempoDeAtencion
            // 
            this.colTiempoDeAtencion.HeaderText = "Tiempo de atencion";
            this.colTiempoDeAtencion.MinimumWidth = 6;
            this.colTiempoDeAtencion.Name = "colTiempoDeAtencion";
            this.colTiempoDeAtencion.ReadOnly = true;
            this.colTiempoDeAtencion.Width = 70;
            // 
            // colProximoFinAtencionV1
            // 
            this.colProximoFinAtencionV1.HeaderText = "Proximo fin atencion V1";
            this.colProximoFinAtencionV1.MinimumWidth = 6;
            this.colProximoFinAtencionV1.Name = "colProximoFinAtencionV1";
            this.colProximoFinAtencionV1.ReadOnly = true;
            this.colProximoFinAtencionV1.Width = 125;
            // 
            // colProximoFinAtencionV2
            // 
            this.colProximoFinAtencionV2.HeaderText = "Proximo fin atencion V2";
            this.colProximoFinAtencionV2.MinimumWidth = 6;
            this.colProximoFinAtencionV2.Name = "colProximoFinAtencionV2";
            this.colProximoFinAtencionV2.ReadOnly = true;
            this.colProximoFinAtencionV2.Width = 125;
            // 
            // colRndOpcionPago
            // 
            this.colRndOpcionPago.HeaderText = "RND opcion de pago";
            this.colRndOpcionPago.MinimumWidth = 6;
            this.colRndOpcionPago.Name = "colRndOpcionPago";
            this.colRndOpcionPago.ReadOnly = true;
            this.colRndOpcionPago.Width = 45;
            // 
            // colOpcionDePago
            // 
            this.colOpcionDePago.HeaderText = "Opcion de pago";
            this.colOpcionDePago.MinimumWidth = 6;
            this.colOpcionDePago.Name = "colOpcionDePago";
            this.colOpcionDePago.ReadOnly = true;
            this.colOpcionDePago.Width = 65;
            // 
            // colFinRepartoA1
            // 
            this.colFinRepartoA1.HeaderText = "Fin reparto Articulo 1";
            this.colFinRepartoA1.MinimumWidth = 6;
            this.colFinRepartoA1.Name = "colFinRepartoA1";
            this.colFinRepartoA1.ReadOnly = true;
            this.colFinRepartoA1.Width = 125;
            // 
            // colFinRepartoA2
            // 
            this.colFinRepartoA2.HeaderText = "Fin reparto Articulo 2";
            this.colFinRepartoA2.MinimumWidth = 6;
            this.colFinRepartoA2.Name = "colFinRepartoA2";
            this.colFinRepartoA2.ReadOnly = true;
            this.colFinRepartoA2.Width = 125;
            // 
            // colFinRepartoA3
            // 
            this.colFinRepartoA3.HeaderText = "Fin reparto Articulo 3";
            this.colFinRepartoA3.MinimumWidth = 6;
            this.colFinRepartoA3.Name = "colFinRepartoA3";
            this.colFinRepartoA3.ReadOnly = true;
            this.colFinRepartoA3.Width = 125;
            // 
            // colFinRepartoA4
            // 
            this.colFinRepartoA4.HeaderText = "Fin reparto Articulo 4";
            this.colFinRepartoA4.MinimumWidth = 6;
            this.colFinRepartoA4.Name = "colFinRepartoA4";
            this.colFinRepartoA4.ReadOnly = true;
            this.colFinRepartoA4.Width = 125;
            // 
            // colEstadoVendedor1
            // 
            this.colEstadoVendedor1.HeaderText = "Estado Vendedor 1";
            this.colEstadoVendedor1.MinimumWidth = 6;
            this.colEstadoVendedor1.Name = "colEstadoVendedor1";
            this.colEstadoVendedor1.ReadOnly = true;
            this.colEstadoVendedor1.Width = 70;
            // 
            // colEstadoVendedor2
            // 
            this.colEstadoVendedor2.HeaderText = "Estado Vendedor 2";
            this.colEstadoVendedor2.MinimumWidth = 6;
            this.colEstadoVendedor2.Name = "colEstadoVendedor2";
            this.colEstadoVendedor2.ReadOnly = true;
            this.colEstadoVendedor2.Width = 70;
            // 
            // colColaDeClientes
            // 
            this.colColaDeClientes.HeaderText = "Cola de clientes";
            this.colColaDeClientes.MinimumWidth = 6;
            this.colColaDeClientes.Name = "colColaDeClientes";
            this.colColaDeClientes.ReadOnly = true;
            this.colColaDeClientes.Width = 65;
            // 
            // colEstadoRepartidor
            // 
            this.colEstadoRepartidor.HeaderText = "Estado Repartidor";
            this.colEstadoRepartidor.MinimumWidth = 6;
            this.colEstadoRepartidor.Name = "colEstadoRepartidor";
            this.colEstadoRepartidor.ReadOnly = true;
            this.colEstadoRepartidor.Width = 70;
            // 
            // colArticulosAlContado
            // 
            this.colArticulosAlContado.HeaderText = "Cola de articulos al contado";
            this.colArticulosAlContado.MinimumWidth = 6;
            this.colArticulosAlContado.Name = "colArticulosAlContado";
            this.colArticulosAlContado.ReadOnly = true;
            this.colArticulosAlContado.Width = 65;
            // 
            // colArticulosCredito
            // 
            this.colArticulosCredito.HeaderText = "Cola de Articulos Credito";
            this.colArticulosCredito.MinimumWidth = 6;
            this.colArticulosCredito.Name = "colArticulosCredito";
            this.colArticulosCredito.ReadOnly = true;
            this.colArticulosCredito.Width = 65;
            // 
            // colArticulosSiendoRepartidos
            // 
            this.colArticulosSiendoRepartidos.HeaderText = "Articulos siendo repartidos";
            this.colArticulosSiendoRepartidos.MinimumWidth = 6;
            this.colArticulosSiendoRepartidos.Name = "colArticulosSiendoRepartidos";
            this.colArticulosSiendoRepartidos.ReadOnly = true;
            this.colArticulosSiendoRepartidos.Width = 50;
            // 
            // colAcumTiemposDeRepartoCredito
            // 
            this.colAcumTiemposDeRepartoCredito.HeaderText = "Acum tiempo de reparto (credito)";
            this.colAcumTiemposDeRepartoCredito.MinimumWidth = 6;
            this.colAcumTiemposDeRepartoCredito.Name = "colAcumTiemposDeRepartoCredito";
            this.colAcumTiemposDeRepartoCredito.ReadOnly = true;
            this.colAcumTiemposDeRepartoCredito.Width = 125;
            // 
            // colCantidadArticulosCreditoEntregados
            // 
            this.colCantidadArticulosCreditoEntregados.HeaderText = "Cantidad de Articulos a credito entregados";
            this.colCantidadArticulosCreditoEntregados.MinimumWidth = 6;
            this.colCantidadArticulosCreditoEntregados.Name = "colCantidadArticulosCreditoEntregados";
            this.colCantidadArticulosCreditoEntregados.ReadOnly = true;
            this.colCantidadArticulosCreditoEntregados.Width = 125;
            // 
            // txtLlegadaClienteMin
            // 
            this.txtLlegadaClienteMin.Location = new System.Drawing.Point(315, 30);
            this.txtLlegadaClienteMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLlegadaClienteMin.Name = "txtLlegadaClienteMin";
            this.txtLlegadaClienteMin.Size = new System.Drawing.Size(125, 30);
            this.txtLlegadaClienteMin.TabIndex = 2;
            this.txtLlegadaClienteMin.Text = "7";
            // 
            // txtLlegadaClienteMax
            // 
            this.txtLlegadaClienteMax.Location = new System.Drawing.Point(443, 30);
            this.txtLlegadaClienteMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLlegadaClienteMax.Name = "txtLlegadaClienteMax";
            this.txtLlegadaClienteMax.Size = new System.Drawing.Size(125, 30);
            this.txtLlegadaClienteMax.TabIndex = 3;
            this.txtLlegadaClienteMax.Text = "11";
            // 
            // txtFinAtencionMax
            // 
            this.txtFinAtencionMax.Location = new System.Drawing.Point(443, 71);
            this.txtFinAtencionMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFinAtencionMax.Name = "txtFinAtencionMax";
            this.txtFinAtencionMax.Size = new System.Drawing.Size(125, 30);
            this.txtFinAtencionMax.TabIndex = 6;
            this.txtFinAtencionMax.Text = "12";
            // 
            // txtFinAtencionMin
            // 
            this.txtFinAtencionMin.Location = new System.Drawing.Point(315, 71);
            this.txtFinAtencionMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFinAtencionMin.Name = "txtFinAtencionMin";
            this.txtFinAtencionMin.Size = new System.Drawing.Size(125, 30);
            this.txtFinAtencionMin.TabIndex = 5;
            this.txtFinAtencionMin.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "FinAtencion";
            // 
            // txtFinReparto
            // 
            this.txtFinReparto.Location = new System.Drawing.Point(315, 114);
            this.txtFinReparto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFinReparto.Name = "txtFinReparto";
            this.txtFinReparto.Size = new System.Drawing.Size(125, 30);
            this.txtFinReparto.TabIndex = 8;
            this.txtFinReparto.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "FinReparto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Vendedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Articulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Repartidor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "{ Libre | Ocupado }";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "{ Libre | Ocupado }";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(137, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(314, 31);
            this.label11.TabIndex = 16;
            this.label11.Text = "{ Esperando | Repartiendo }";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(137, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(363, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "{ EsperandoAtencion | SiendoAtendido }";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 25);
            this.label14.TabIndex = 22;
            this.label14.Text = "Constante";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 25);
            this.label15.TabIndex = 21;
            this.label15.Text = "Uniforme";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "Uniforme";
            // 
            // groupBoxObjetos
            // 
            this.groupBoxObjetos.Controls.Add(this.label9);
            this.groupBoxObjetos.Controls.Add(this.label10);
            this.groupBoxObjetos.Controls.Add(this.label11);
            this.groupBoxObjetos.Controls.Add(this.label12);
            this.groupBoxObjetos.Controls.Add(this.label8);
            this.groupBoxObjetos.Controls.Add(this.label5);
            this.groupBoxObjetos.Controls.Add(this.label6);
            this.groupBoxObjetos.Controls.Add(this.label7);
            this.groupBoxObjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxObjetos.Location = new System.Drawing.Point(723, 12);
            this.groupBoxObjetos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxObjetos.Name = "groupBoxObjetos";
            this.groupBoxObjetos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxObjetos.Size = new System.Drawing.Size(551, 223);
            this.groupBoxObjetos.TabIndex = 23;
            this.groupBoxObjetos.TabStop = false;
            this.groupBoxObjetos.Text = "Objetos";
            // 
            // groupBoxEventos
            // 
            this.groupBoxEventos.Controls.Add(this.label14);
            this.groupBoxEventos.Controls.Add(this.label15);
            this.groupBoxEventos.Controls.Add(this.label16);
            this.groupBoxEventos.Controls.Add(this.txtFinReparto);
            this.groupBoxEventos.Controls.Add(this.label3);
            this.groupBoxEventos.Controls.Add(this.txtFinAtencionMax);
            this.groupBoxEventos.Controls.Add(this.txtFinAtencionMin);
            this.groupBoxEventos.Controls.Add(this.label2);
            this.groupBoxEventos.Controls.Add(this.txtLlegadaClienteMax);
            this.groupBoxEventos.Controls.Add(this.txtLlegadaClienteMin);
            this.groupBoxEventos.Controls.Add(this.label1);
            this.groupBoxEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEventos.Location = new System.Drawing.Point(21, 46);
            this.groupBoxEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEventos.Name = "groupBoxEventos";
            this.groupBoxEventos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEventos.Size = new System.Drawing.Size(608, 190);
            this.groupBoxEventos.TabIndex = 24;
            this.groupBoxEventos.TabStop = false;
            this.groupBoxEventos.Text = "Eventos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerarSimulacion);
            this.groupBox1.Controls.Add(this.txtFilaHasta);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtFilaDesde);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCantidadSimulaciones);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 256);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1011, 112);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de simulacion";
            // 
            // btnGenerarSimulacion
            // 
            this.btnGenerarSimulacion.Location = new System.Drawing.Point(812, 30);
            this.btnGenerarSimulacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarSimulacion.Name = "btnGenerarSimulacion";
            this.btnGenerarSimulacion.Size = new System.Drawing.Size(169, 71);
            this.btnGenerarSimulacion.TabIndex = 29;
            this.btnGenerarSimulacion.Text = "Generar simulacion";
            this.btnGenerarSimulacion.UseVisualStyleBackColor = true;
            this.btnGenerarSimulacion.Click += new System.EventHandler(this.OnClickGenerar);
            // 
            // txtFilaHasta
            // 
            this.txtFilaHasta.Location = new System.Drawing.Point(552, 64);
            this.txtFilaHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilaHasta.Name = "txtFilaHasta";
            this.txtFilaHasta.Size = new System.Drawing.Size(156, 30);
            this.txtFilaHasta.TabIndex = 28;
            this.txtFilaHasta.Text = "10";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(612, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 25);
            this.label17.TabIndex = 27;
            this.label17.Text = "Fila hasta";
            // 
            // txtFilaDesde
            // 
            this.txtFilaDesde.Location = new System.Drawing.Point(328, 63);
            this.txtFilaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilaDesde.Name = "txtFilaDesde";
            this.txtFilaDesde.Size = new System.Drawing.Size(156, 30);
            this.txtFilaDesde.TabIndex = 26;
            this.txtFilaDesde.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(381, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "Fila desde";
            // 
            // txtCantidadSimulaciones
            // 
            this.txtCantidadSimulaciones.Location = new System.Drawing.Point(93, 63);
            this.txtCantidadSimulaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadSimulaciones.Name = "txtCantidadSimulaciones";
            this.txtCantidadSimulaciones.Size = new System.Drawing.Size(156, 30);
            this.txtCantidadSimulaciones.TabIndex = 24;
            this.txtCantidadSimulaciones.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cantidad de Simulaciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpcionDePago);
            this.groupBox2.Controls.Add(this.txtProbCredito);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.txtProbContado);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1295, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(307, 223);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opcion de pago";
            // 
            // btnOpcionDePago
            // 
            this.btnOpcionDePago.Location = new System.Drawing.Point(141, 126);
            this.btnOpcionDePago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpcionDePago.Name = "btnOpcionDePago";
            this.btnOpcionDePago.Size = new System.Drawing.Size(125, 49);
            this.btnOpcionDePago.TabIndex = 25;
            this.btnOpcionDePago.Text = "Calcular";
            this.btnOpcionDePago.UseVisualStyleBackColor = true;
            this.btnOpcionDePago.Click += new System.EventHandler(this.onBtnCalcularClick);
            // 
            // txtProbCredito
            // 
            this.txtProbCredito.Enabled = false;
            this.txtProbCredito.Location = new System.Drawing.Point(141, 78);
            this.txtProbCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProbCredito.Name = "txtProbCredito";
            this.txtProbCredito.Size = new System.Drawing.Size(125, 30);
            this.txtProbCredito.TabIndex = 24;
            this.txtProbCredito.Text = "0,80";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(27, 82);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 25);
            this.label24.TabIndex = 12;
            this.label24.Text = "Credito";
            // 
            // txtProbContado
            // 
            this.txtProbContado.Location = new System.Drawing.Point(141, 37);
            this.txtProbContado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProbContado.Name = "txtProbContado";
            this.txtProbContado.Size = new System.Drawing.Size(125, 30);
            this.txtProbContado.TabIndex = 23;
            this.txtProbContado.Text = "0,20";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(27, 41);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 25);
            this.label25.TabIndex = 11;
            this.label25.Text = "Contado";
            // 
            // lblTituloResultado
            // 
            this.lblTituloResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloResultado.Location = new System.Drawing.Point(1699, 46);
            this.lblTituloResultado.Name = "lblTituloResultado";
            this.lblTituloResultado.Size = new System.Drawing.Size(431, 94);
            this.lblTituloResultado.TabIndex = 19;
            this.lblTituloResultado.Text = "Tiempo promedio de reparto de paquetes pagados con credito:";
            this.lblTituloResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(1801, 109);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(251, 62);
            this.lblResultado.TabIndex = 26;
            // 
            // gridArticulosCredito
            // 
            this.gridArticulosCredito.AllowUserToAddRows = false;
            this.gridArticulosCredito.AllowUserToDeleteRows = false;
            this.gridArticulosCredito.AllowUserToResizeColumns = false;
            this.gridArticulosCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridArticulosCredito.ColumnHeadersHeight = 75;
            this.gridArticulosCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridArticulosCredito.EnableHeadersVisualStyles = false;
            this.gridArticulosCredito.Location = new System.Drawing.Point(1544, 386);
            this.gridArticulosCredito.Margin = new System.Windows.Forms.Padding(4);
            this.gridArticulosCredito.Name = "gridArticulosCredito";
            this.gridArticulosCredito.ReadOnly = true;
            this.gridArticulosCredito.RowHeadersVisible = false;
            this.gridArticulosCredito.RowHeadersWidth = 51;
            this.gridArticulosCredito.RowTemplate.Height = 24;
            this.gridArticulosCredito.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gridArticulosCredito.Size = new System.Drawing.Size(498, 551);
            this.gridArticulosCredito.TabIndex = 27;
            this.gridArticulosCredito.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.ColumnAddedGridCredito);
            // 
            // gridArticulosContado
            // 
            this.gridArticulosContado.AllowUserToAddRows = false;
            this.gridArticulosContado.AllowUserToDeleteRows = false;
            this.gridArticulosContado.AllowUserToResizeColumns = false;
            this.gridArticulosContado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridArticulosContado.ColumnHeadersHeight = 75;
            this.gridArticulosContado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridArticulosContado.EnableHeadersVisualStyles = false;
            this.gridArticulosContado.Location = new System.Drawing.Point(2050, 386);
            this.gridArticulosContado.Margin = new System.Windows.Forms.Padding(4);
            this.gridArticulosContado.Name = "gridArticulosContado";
            this.gridArticulosContado.ReadOnly = true;
            this.gridArticulosContado.RowHeadersVisible = false;
            this.gridArticulosContado.RowHeadersWidth = 51;
            this.gridArticulosContado.RowTemplate.Height = 24;
            this.gridArticulosContado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gridArticulosContado.Size = new System.Drawing.Size(519, 551);
            this.gridArticulosContado.TabIndex = 28;
            this.gridArticulosContado.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.ColumnAddedGridContado);
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.AllowUserToResizeColumns = false;
            this.gridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridClientes.ColumnHeadersHeight = 75;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridClientes.EnableHeadersVisualStyles = false;
            this.gridClientes.Location = new System.Drawing.Point(1135, 386);
            this.gridClientes.Margin = new System.Windows.Forms.Padding(4);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.RowHeadersVisible = false;
            this.gridClientes.RowHeadersWidth = 40;
            this.gridClientes.RowTemplate.Height = 24;
            this.gridClientes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gridClientes.Size = new System.Drawing.Size(401, 551);
            this.gridClientes.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1173, 357);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 17);
            this.label18.TabIndex = 19;
            this.label18.Text = "Clientes";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1720, 357);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 17);
            this.label19.TabIndex = 30;
            this.label19.Text = "Articulos Credito";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2165, 351);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 17);
            this.label20.TabIndex = 31;
            this.label20.Text = "Articulos Contado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2397, 948);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.gridArticulosContado);
            this.Controls.Add(this.gridArticulosCredito);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTituloResultado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEventos);
            this.Controls.Add(this.groupBoxObjetos);
            this.Controls.Add(this.gridSimulaciones);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridSimulaciones)).EndInit();
            this.groupBoxObjetos.ResumeLayout(false);
            this.groupBoxObjetos.PerformLayout();
            this.groupBoxEventos.ResumeLayout(false);
            this.groupBoxEventos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosContado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridSimulaciones;
        private System.Windows.Forms.TextBox txtLlegadaClienteMin;
        private System.Windows.Forms.TextBox txtLlegadaClienteMax;
        private System.Windows.Forms.TextBox txtFinAtencionMax;
        private System.Windows.Forms.TextBox txtFinAtencionMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinReparto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBoxObjetos;
        private System.Windows.Forms.GroupBox groupBoxEventos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFilaHasta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFilaDesde;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantidadSimulaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerarSimulacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProbCredito;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtProbContado;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnOpcionDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRndLlegadaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempoEntreLlegadasCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProximaLlegadaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRndFinAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempoDeAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProximoFinAtencionV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProximoFinAtencionV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRndOpcionPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpcionDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinRepartoA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinRepartoA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinRepartoA3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinRepartoA4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoVendedor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoVendedor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColaDeClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoRepartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticulosAlContado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticulosCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticulosSiendoRepartidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcumTiemposDeRepartoCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadArticulosCreditoEntregados;
        private System.Windows.Forms.Label lblTituloResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView gridArticulosCredito;
        private System.Windows.Forms.DataGridView gridArticulosContado;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

