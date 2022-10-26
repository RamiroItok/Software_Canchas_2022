namespace Software_Canchas_2022
{
    partial class Reserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Cliente1 = new System.Windows.Forms.Label();
            this.cmb_Cancha = new System.Windows.Forms.ComboBox();
            this.cmb_Cliente1 = new System.Windows.Forms.ComboBox();
            this.cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AltaCliente = new System.Windows.Forms.Button();
            this.lbl_EsCliente = new System.Windows.Forms.Label();
            this.rdb_Si = new System.Windows.Forms.RadioButton();
            this.rdb_No = new System.Windows.Forms.RadioButton();
            this.dtp_Fecha1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_IngreseFecha = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.cmb_Hora1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_Deuda = new System.Windows.Forms.TextBox();
            this.lbl_Deuda = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_Seña = new System.Windows.Forms.TextBox();
            this.lbl_Seña = new System.Windows.Forms.Label();
            this.cmb_FormaPago = new System.Windows.Forms.ComboBox();
            this.btn_Reservar = new System.Windows.Forms.Button();
            this.btn_ModificarReserva = new System.Windows.Forms.Button();
            this.btn_EliminarReserva = new System.Windows.Forms.Button();
            this.btn_CancelarReserva = new System.Windows.Forms.Button();
            this.dataGridReservas = new System.Windows.Forms.DataGridView();
            this.chk_Cliente = new System.Windows.Forms.CheckBox();
            this.cmb_Cliente2 = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.dtp_Fecha2 = new System.Windows.Forms.DateTimePicker();
            this.chk_Fecha = new System.Windows.Forms.CheckBox();
            this.lbl_IdReserva = new System.Windows.Forms.Label();
            this.txt_Pagado = new System.Windows.Forms.TextBox();
            this.lbl_Pagado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "lbl_Cancha";
            this.label1.Text = "Cancha";
            // 
            // lbl_Cliente1
            // 
            this.lbl_Cliente1.AutoSize = true;
            this.lbl_Cliente1.Location = new System.Drawing.Point(9, 115);
            this.lbl_Cliente1.Name = "lbl_Cliente1";
            this.lbl_Cliente1.Size = new System.Drawing.Size(78, 13);
            this.lbl_Cliente1.TabIndex = 1;
            this.lbl_Cliente1.Tag = "lbl_Cliente";
            this.lbl_Cliente1.Text = "Nombre cliente";
            // 
            // cmb_Cancha
            // 
            this.cmb_Cancha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cancha.FormattingEnabled = true;
            this.cmb_Cancha.Location = new System.Drawing.Point(167, 39);
            this.cmb_Cancha.Name = "cmb_Cancha";
            this.cmb_Cancha.Size = new System.Drawing.Size(137, 21);
            this.cmb_Cancha.TabIndex = 2;
            // 
            // cmb_Cliente1
            // 
            this.cmb_Cliente1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cliente1.Enabled = false;
            this.cmb_Cliente1.FormattingEnabled = true;
            this.cmb_Cliente1.Location = new System.Drawing.Point(12, 131);
            this.cmb_Cliente1.Name = "cmb_Cliente1";
            this.cmb_Cliente1.Size = new System.Drawing.Size(137, 21);
            this.cmb_Cliente1.TabIndex = 5;
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.Location = new System.Drawing.Point(12, 39);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(137, 21);
            this.cmb_Tipo.TabIndex = 1;
            this.cmb_Tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_Tipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Tag = "lbl_TipoCancha";
            this.label2.Text = "Tipo de cancha";
            // 
            // btn_AltaCliente
            // 
            this.btn_AltaCliente.Location = new System.Drawing.Point(167, 129);
            this.btn_AltaCliente.Name = "btn_AltaCliente";
            this.btn_AltaCliente.Size = new System.Drawing.Size(137, 23);
            this.btn_AltaCliente.TabIndex = 6;
            this.btn_AltaCliente.Tag = "btn_AltaCliente";
            this.btn_AltaCliente.Text = "Alta Cliente";
            this.btn_AltaCliente.UseVisualStyleBackColor = true;
            this.btn_AltaCliente.Click += new System.EventHandler(this.btn_AltaCliente_Click);
            // 
            // lbl_EsCliente
            // 
            this.lbl_EsCliente.AutoSize = true;
            this.lbl_EsCliente.Location = new System.Drawing.Point(9, 72);
            this.lbl_EsCliente.Name = "lbl_EsCliente";
            this.lbl_EsCliente.Size = new System.Drawing.Size(59, 13);
            this.lbl_EsCliente.TabIndex = 9;
            this.lbl_EsCliente.Tag = "lbl_EsCliente";
            this.lbl_EsCliente.Text = "Es cliente?";
            // 
            // rdb_Si
            // 
            this.rdb_Si.AutoSize = true;
            this.rdb_Si.Location = new System.Drawing.Point(12, 88);
            this.rdb_Si.Name = "rdb_Si";
            this.rdb_Si.Size = new System.Drawing.Size(34, 17);
            this.rdb_Si.TabIndex = 3;
            this.rdb_Si.TabStop = true;
            this.rdb_Si.Tag = "rdb_Si";
            this.rdb_Si.Text = "Si";
            this.rdb_Si.UseVisualStyleBackColor = true;
            this.rdb_Si.CheckedChanged += new System.EventHandler(this.rdb_Si_CheckedChanged);
            // 
            // rdb_No
            // 
            this.rdb_No.AutoSize = true;
            this.rdb_No.Location = new System.Drawing.Point(67, 88);
            this.rdb_No.Name = "rdb_No";
            this.rdb_No.Size = new System.Drawing.Size(39, 17);
            this.rdb_No.TabIndex = 4;
            this.rdb_No.TabStop = true;
            this.rdb_No.Tag = "rdb_No";
            this.rdb_No.Text = "No";
            this.rdb_No.UseVisualStyleBackColor = true;
            this.rdb_No.CheckedChanged += new System.EventHandler(this.rdb_No_CheckedChanged);
            // 
            // dtp_Fecha1
            // 
            this.dtp_Fecha1.Checked = false;
            this.dtp_Fecha1.Location = new System.Drawing.Point(12, 192);
            this.dtp_Fecha1.Name = "dtp_Fecha1";
            this.dtp_Fecha1.Size = new System.Drawing.Size(137, 20);
            this.dtp_Fecha1.TabIndex = 7;
            this.dtp_Fecha1.Tag = "";
            this.dtp_Fecha1.ValueChanged += new System.EventHandler(this.dtp_Fecha_ValueChanged);
            // 
            // lbl_IngreseFecha
            // 
            this.lbl_IngreseFecha.AutoSize = true;
            this.lbl_IngreseFecha.Location = new System.Drawing.Point(9, 176);
            this.lbl_IngreseFecha.Name = "lbl_IngreseFecha";
            this.lbl_IngreseFecha.Size = new System.Drawing.Size(83, 13);
            this.lbl_IngreseFecha.TabIndex = 13;
            this.lbl_IngreseFecha.Tag = "lbl_IngreseFecha";
            this.lbl_IngreseFecha.Text = "Ingrese la fecha";
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Location = new System.Drawing.Point(164, 176);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(30, 13);
            this.lbl_Hora.TabIndex = 14;
            this.lbl_Hora.Tag = "lbl_Hora";
            this.lbl_Hora.Text = "Hora";
            // 
            // cmb_Hora1
            // 
            this.cmb_Hora1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Hora1.FormattingEnabled = true;
            this.cmb_Hora1.Location = new System.Drawing.Point(167, 192);
            this.cmb_Hora1.Name = "cmb_Hora1";
            this.cmb_Hora1.Size = new System.Drawing.Size(137, 21);
            this.cmb_Hora1.TabIndex = 8;
            this.cmb_Hora1.SelectedIndexChanged += new System.EventHandler(this.cmb_Hora1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 16;
            this.label3.Tag = "lbl_Forma_Pago";
            this.label3.Text = "Forma de pago";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(92, 306);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(134, 23);
            this.btn_Calcular.TabIndex = 11;
            this.btn_Calcular.Tag = "btn_CalcularDeuda";
            this.btn_Calcular.Text = "Calcular deuda";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_Deuda
            // 
            this.txt_Deuda.Location = new System.Drawing.Point(167, 359);
            this.txt_Deuda.Name = "txt_Deuda";
            this.txt_Deuda.ReadOnly = true;
            this.txt_Deuda.Size = new System.Drawing.Size(137, 20);
            this.txt_Deuda.TabIndex = 23;
            // 
            // lbl_Deuda
            // 
            this.lbl_Deuda.AutoSize = true;
            this.lbl_Deuda.Location = new System.Drawing.Point(164, 343);
            this.lbl_Deuda.Name = "lbl_Deuda";
            this.lbl_Deuda.Size = new System.Drawing.Size(33, 13);
            this.lbl_Deuda.TabIndex = 22;
            this.lbl_Deuda.Tag = "lbl_Deuda";
            this.lbl_Deuda.Text = "Debe";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(12, 359);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(137, 20);
            this.txt_Total.TabIndex = 21;
            this.txt_Total.Tag = "";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(11, 343);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(31, 13);
            this.lbl_Total.TabIndex = 20;
            this.lbl_Total.Tag = "lbl_Total";
            this.lbl_Total.Text = "Total";
            // 
            // txt_Seña
            // 
            this.txt_Seña.Location = new System.Drawing.Point(167, 269);
            this.txt_Seña.Name = "txt_Seña";
            this.txt_Seña.Size = new System.Drawing.Size(137, 20);
            this.txt_Seña.TabIndex = 10;
            // 
            // lbl_Seña
            // 
            this.lbl_Seña.AutoSize = true;
            this.lbl_Seña.Location = new System.Drawing.Point(164, 253);
            this.lbl_Seña.Name = "lbl_Seña";
            this.lbl_Seña.Size = new System.Drawing.Size(32, 13);
            this.lbl_Seña.TabIndex = 18;
            this.lbl_Seña.Tag = "lbl_Seña";
            this.lbl_Seña.Text = "Seña";
            // 
            // cmb_FormaPago
            // 
            this.cmb_FormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FormaPago.FormattingEnabled = true;
            this.cmb_FormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cmb_FormaPago.Location = new System.Drawing.Point(12, 269);
            this.cmb_FormaPago.Name = "cmb_FormaPago";
            this.cmb_FormaPago.Size = new System.Drawing.Size(137, 21);
            this.cmb_FormaPago.TabIndex = 9;
            this.cmb_FormaPago.SelectedIndexChanged += new System.EventHandler(this.cmb_FormaPago_SelectedIndexChanged);
            // 
            // btn_Reservar
            // 
            this.btn_Reservar.Location = new System.Drawing.Point(18, 465);
            this.btn_Reservar.Name = "btn_Reservar";
            this.btn_Reservar.Size = new System.Drawing.Size(129, 40);
            this.btn_Reservar.TabIndex = 12;
            this.btn_Reservar.Tag = "btn_Reservar";
            this.btn_Reservar.Text = "Reservar";
            this.btn_Reservar.UseVisualStyleBackColor = true;
            this.btn_Reservar.Click += new System.EventHandler(this.btn_Reservar_Click);
            // 
            // btn_ModificarReserva
            // 
            this.btn_ModificarReserva.Location = new System.Drawing.Point(165, 465);
            this.btn_ModificarReserva.Name = "btn_ModificarReserva";
            this.btn_ModificarReserva.Size = new System.Drawing.Size(127, 40);
            this.btn_ModificarReserva.TabIndex = 13;
            this.btn_ModificarReserva.Tag = "btn_ModificarReserva";
            this.btn_ModificarReserva.Text = "Modificar reserva";
            this.btn_ModificarReserva.UseVisualStyleBackColor = true;
            this.btn_ModificarReserva.Click += new System.EventHandler(this.btn_ModificarReserva_Click);
            // 
            // btn_EliminarReserva
            // 
            this.btn_EliminarReserva.Location = new System.Drawing.Point(18, 519);
            this.btn_EliminarReserva.Name = "btn_EliminarReserva";
            this.btn_EliminarReserva.Size = new System.Drawing.Size(129, 40);
            this.btn_EliminarReserva.TabIndex = 14;
            this.btn_EliminarReserva.Tag = "btn_EliminarReserva";
            this.btn_EliminarReserva.Text = "Eliminar reserva";
            this.btn_EliminarReserva.UseVisualStyleBackColor = true;
            this.btn_EliminarReserva.Click += new System.EventHandler(this.btn_EliminarReserva_Click);
            // 
            // btn_CancelarReserva
            // 
            this.btn_CancelarReserva.Location = new System.Drawing.Point(165, 519);
            this.btn_CancelarReserva.Name = "btn_CancelarReserva";
            this.btn_CancelarReserva.Size = new System.Drawing.Size(127, 40);
            this.btn_CancelarReserva.TabIndex = 15;
            this.btn_CancelarReserva.Tag = "btn_Cancelar";
            this.btn_CancelarReserva.Text = "Cancelar";
            this.btn_CancelarReserva.UseVisualStyleBackColor = true;
            this.btn_CancelarReserva.Click += new System.EventHandler(this.btn_CancelarReserva_Click);
            // 
            // dataGridReservas
            // 
            this.dataGridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservas.Location = new System.Drawing.Point(310, 88);
            this.dataGridReservas.Name = "dataGridReservas";
            this.dataGridReservas.Size = new System.Drawing.Size(878, 473);
            this.dataGridReservas.TabIndex = 22;
            this.dataGridReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReservas_CellClick);
            // 
            // chk_Cliente
            // 
            this.chk_Cliente.AutoSize = true;
            this.chk_Cliente.Location = new System.Drawing.Point(871, 19);
            this.chk_Cliente.Name = "chk_Cliente";
            this.chk_Cliente.Size = new System.Drawing.Size(58, 17);
            this.chk_Cliente.TabIndex = 30;
            this.chk_Cliente.Tag = "chk_Cliente";
            this.chk_Cliente.Text = "Cliente";
            this.chk_Cliente.UseVisualStyleBackColor = true;
            // 
            // cmb_Cliente2
            // 
            this.cmb_Cliente2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cliente2.FormattingEnabled = true;
            this.cmb_Cliente2.Location = new System.Drawing.Point(871, 43);
            this.cmb_Cliente2.Name = "cmb_Cliente2";
            this.cmb_Cliente2.Size = new System.Drawing.Size(153, 21);
            this.cmb_Cliente2.TabIndex = 17;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(1052, 45);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(134, 23);
            this.btn_Cancelar.TabIndex = 19;
            this.btn_Cancelar.Tag = "btn_Cancelar";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(1052, 16);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(134, 23);
            this.btn_Filtrar.TabIndex = 18;
            this.btn_Filtrar.Tag = "btn_Filtrar";
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // dtp_Fecha2
            // 
            this.dtp_Fecha2.Checked = false;
            this.dtp_Fecha2.Location = new System.Drawing.Point(687, 44);
            this.dtp_Fecha2.Name = "dtp_Fecha2";
            this.dtp_Fecha2.Size = new System.Drawing.Size(153, 20);
            this.dtp_Fecha2.TabIndex = 16;
            this.dtp_Fecha2.Tag = "";
            // 
            // chk_Fecha
            // 
            this.chk_Fecha.AutoSize = true;
            this.chk_Fecha.Location = new System.Drawing.Point(687, 21);
            this.chk_Fecha.Name = "chk_Fecha";
            this.chk_Fecha.Size = new System.Drawing.Size(72, 17);
            this.chk_Fecha.TabIndex = 28;
            this.chk_Fecha.Tag = "chk_Fecha";
            this.chk_Fecha.Text = "Por fecha";
            this.chk_Fecha.UseVisualStyleBackColor = true;
            // 
            // lbl_IdReserva
            // 
            this.lbl_IdReserva.AutoSize = true;
            this.lbl_IdReserva.Location = new System.Drawing.Point(389, 40);
            this.lbl_IdReserva.Name = "lbl_IdReserva";
            this.lbl_IdReserva.Size = new System.Drawing.Size(0, 13);
            this.lbl_IdReserva.TabIndex = 31;
            this.lbl_IdReserva.Visible = false;
            // 
            // txt_Pagado
            // 
            this.txt_Pagado.Location = new System.Drawing.Point(167, 413);
            this.txt_Pagado.Name = "txt_Pagado";
            this.txt_Pagado.ReadOnly = true;
            this.txt_Pagado.Size = new System.Drawing.Size(137, 20);
            this.txt_Pagado.TabIndex = 32;
            this.txt_Pagado.Tag = "";
            // 
            // lbl_Pagado
            // 
            this.lbl_Pagado.AutoSize = true;
            this.lbl_Pagado.Location = new System.Drawing.Point(164, 397);
            this.lbl_Pagado.Name = "lbl_Pagado";
            this.lbl_Pagado.Size = new System.Drawing.Size(44, 13);
            this.lbl_Pagado.TabIndex = 33;
            this.lbl_Pagado.Tag = "lbl_Pagado";
            this.lbl_Pagado.Text = "Pagado";
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1205, 583);
            this.Controls.Add(this.lbl_Pagado);
            this.Controls.Add(this.txt_Pagado);
            this.Controls.Add(this.lbl_IdReserva);
            this.Controls.Add(this.chk_Cliente);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.cmb_Cliente2);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.dtp_Fecha2);
            this.Controls.Add(this.txt_Deuda);
            this.Controls.Add(this.chk_Fecha);
            this.Controls.Add(this.lbl_Deuda);
            this.Controls.Add(this.dataGridReservas);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.btn_CancelarReserva);
            this.Controls.Add(this.btn_EliminarReserva);
            this.Controls.Add(this.txt_Seña);
            this.Controls.Add(this.btn_ModificarReserva);
            this.Controls.Add(this.lbl_Seña);
            this.Controls.Add(this.btn_Reservar);
            this.Controls.Add(this.cmb_FormaPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Hora1);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.lbl_IngreseFecha);
            this.Controls.Add(this.dtp_Fecha1);
            this.Controls.Add(this.rdb_No);
            this.Controls.Add(this.rdb_Si);
            this.Controls.Add(this.lbl_EsCliente);
            this.Controls.Add(this.btn_AltaCliente);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Cliente1);
            this.Controls.Add(this.cmb_Cancha);
            this.Controls.Add(this.lbl_Cliente1);
            this.Controls.Add(this.label1);
            this.Name = "Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Cliente1;
        private System.Windows.Forms.ComboBox cmb_Cancha;
        private System.Windows.Forms.ComboBox cmb_Cliente1;
        private System.Windows.Forms.ComboBox cmb_Tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AltaCliente;
        private System.Windows.Forms.Label lbl_EsCliente;
        private System.Windows.Forms.RadioButton rdb_Si;
        private System.Windows.Forms.RadioButton rdb_No;
        private System.Windows.Forms.DateTimePicker dtp_Fecha1;
        private System.Windows.Forms.Label lbl_IngreseFecha;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.ComboBox cmb_Hora1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_FormaPago;
        private System.Windows.Forms.Label lbl_Seña;
        private System.Windows.Forms.TextBox txt_Seña;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_Deuda;
        private System.Windows.Forms.Label lbl_Deuda;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Reservar;
        private System.Windows.Forms.Button btn_ModificarReserva;
        private System.Windows.Forms.Button btn_EliminarReserva;
        private System.Windows.Forms.Button btn_CancelarReserva;
        private System.Windows.Forms.DataGridView dataGridReservas;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.DateTimePicker dtp_Fecha2;
        private System.Windows.Forms.CheckBox chk_Fecha;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox cmb_Cliente2;
        private System.Windows.Forms.CheckBox chk_Cliente;
        private System.Windows.Forms.Label lbl_IdReserva;
        private System.Windows.Forms.TextBox txt_Pagado;
        private System.Windows.Forms.Label lbl_Pagado;
    }
}