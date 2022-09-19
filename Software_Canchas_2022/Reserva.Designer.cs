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
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.cmb_Cancha = new System.Windows.Forms.ComboBox();
            this.cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AltaCliente = new System.Windows.Forms.Button();
            this.lbl_EsCliente = new System.Windows.Forms.Label();
            this.rdb_Si = new System.Windows.Forms.RadioButton();
            this.rdb_No = new System.Windows.Forms.RadioButton();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_IngreseFecha = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.cmb_Hora1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpb_Pago = new System.Windows.Forms.GroupBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
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
            this.gbp_Filtros = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chk_Fecha = new System.Windows.Forms.CheckBox();
            this.chk_Horario = new System.Windows.Forms.CheckBox();
            this.cmb_Hora2 = new System.Windows.Forms.ComboBox();
            this.gpb_Pago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservas)).BeginInit();
            this.gbp_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "lbl_Cancha";
            this.label1.Text = "Cancha";
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Location = new System.Drawing.Point(27, 116);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(78, 13);
            this.lbl_Cliente.TabIndex = 1;
            this.lbl_Cliente.Tag = "lbl_Cliente";
            this.lbl_Cliente.Text = "Nombre cliente";
            // 
            // cmb_Cancha
            // 
            this.cmb_Cancha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cancha.FormattingEnabled = true;
            this.cmb_Cancha.Location = new System.Drawing.Point(206, 40);
            this.cmb_Cancha.Name = "cmb_Cancha";
            this.cmb_Cancha.Size = new System.Drawing.Size(153, 21);
            this.cmb_Cancha.TabIndex = 2;
            // 
            // cmb_Cliente
            // 
            this.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cliente.FormattingEnabled = true;
            this.cmb_Cliente.Location = new System.Drawing.Point(30, 132);
            this.cmb_Cliente.Name = "cmb_Cliente";
            this.cmb_Cliente.Size = new System.Drawing.Size(153, 21);
            this.cmb_Cliente.TabIndex = 3;
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.Location = new System.Drawing.Point(30, 40);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(153, 21);
            this.cmb_Tipo.TabIndex = 5;
            this.cmb_Tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_Tipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Tag = "lbl_TipoCancha";
            this.label2.Text = "Tipo de cancha";
            // 
            // btn_AltaCliente
            // 
            this.btn_AltaCliente.Location = new System.Drawing.Point(206, 130);
            this.btn_AltaCliente.Name = "btn_AltaCliente";
            this.btn_AltaCliente.Size = new System.Drawing.Size(153, 23);
            this.btn_AltaCliente.TabIndex = 6;
            this.btn_AltaCliente.Tag = "btn_AltaCliente";
            this.btn_AltaCliente.Text = "Alta Cliente";
            this.btn_AltaCliente.UseVisualStyleBackColor = true;
            this.btn_AltaCliente.Click += new System.EventHandler(this.btn_AltaCliente_Click);
            // 
            // lbl_EsCliente
            // 
            this.lbl_EsCliente.AutoSize = true;
            this.lbl_EsCliente.Location = new System.Drawing.Point(27, 73);
            this.lbl_EsCliente.Name = "lbl_EsCliente";
            this.lbl_EsCliente.Size = new System.Drawing.Size(59, 13);
            this.lbl_EsCliente.TabIndex = 9;
            this.lbl_EsCliente.Tag = "lbl_EsCliente";
            this.lbl_EsCliente.Text = "Es cliente?";
            // 
            // rdb_Si
            // 
            this.rdb_Si.AutoSize = true;
            this.rdb_Si.Location = new System.Drawing.Point(30, 89);
            this.rdb_Si.Name = "rdb_Si";
            this.rdb_Si.Size = new System.Drawing.Size(34, 17);
            this.rdb_Si.TabIndex = 10;
            this.rdb_Si.TabStop = true;
            this.rdb_Si.Tag = "rdb_Si";
            this.rdb_Si.Text = "Si";
            this.rdb_Si.UseVisualStyleBackColor = true;
            this.rdb_Si.CheckedChanged += new System.EventHandler(this.rdb_Si_CheckedChanged);
            // 
            // rdb_No
            // 
            this.rdb_No.AutoSize = true;
            this.rdb_No.Location = new System.Drawing.Point(85, 89);
            this.rdb_No.Name = "rdb_No";
            this.rdb_No.Size = new System.Drawing.Size(39, 17);
            this.rdb_No.TabIndex = 11;
            this.rdb_No.TabStop = true;
            this.rdb_No.Tag = "rdb_No";
            this.rdb_No.Text = "No";
            this.rdb_No.UseVisualStyleBackColor = true;
            this.rdb_No.CheckedChanged += new System.EventHandler(this.rdb_No_CheckedChanged);
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Checked = false;
            this.dtp_Fecha.Location = new System.Drawing.Point(30, 193);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(153, 20);
            this.dtp_Fecha.TabIndex = 12;
            this.dtp_Fecha.Tag = "";
            this.dtp_Fecha.ValueChanged += new System.EventHandler(this.dtp_Fecha_ValueChanged);
            // 
            // lbl_IngreseFecha
            // 
            this.lbl_IngreseFecha.AutoSize = true;
            this.lbl_IngreseFecha.Location = new System.Drawing.Point(27, 177);
            this.lbl_IngreseFecha.Name = "lbl_IngreseFecha";
            this.lbl_IngreseFecha.Size = new System.Drawing.Size(83, 13);
            this.lbl_IngreseFecha.TabIndex = 13;
            this.lbl_IngreseFecha.Tag = "lbl_IngreseFecha";
            this.lbl_IngreseFecha.Text = "Ingrese la fecha";
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Location = new System.Drawing.Point(203, 177);
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
            this.cmb_Hora1.Location = new System.Drawing.Point(206, 193);
            this.cmb_Hora1.Name = "cmb_Hora1";
            this.cmb_Hora1.Size = new System.Drawing.Size(153, 21);
            this.cmb_Hora1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 16;
            this.label3.Tag = "lbl_Hora";
            this.label3.Text = "Forma de pago";
            // 
            // gpb_Pago
            // 
            this.gpb_Pago.Controls.Add(this.btn_Aceptar);
            this.gpb_Pago.Controls.Add(this.txt_Deuda);
            this.gpb_Pago.Controls.Add(this.lbl_Deuda);
            this.gpb_Pago.Controls.Add(this.txt_Total);
            this.gpb_Pago.Controls.Add(this.lbl_Total);
            this.gpb_Pago.Controls.Add(this.txt_Seña);
            this.gpb_Pago.Controls.Add(this.lbl_Seña);
            this.gpb_Pago.Controls.Add(this.cmb_FormaPago);
            this.gpb_Pago.Controls.Add(this.label3);
            this.gpb_Pago.Location = new System.Drawing.Point(30, 241);
            this.gpb_Pago.Name = "gpb_Pago";
            this.gpb_Pago.Size = new System.Drawing.Size(329, 177);
            this.gpb_Pago.TabIndex = 17;
            this.gpb_Pago.TabStop = false;
            this.gpb_Pago.Tag = "gpb_Pago";
            this.gpb_Pago.Text = "Pago";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(91, 87);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(134, 23);
            this.btn_Aceptar.TabIndex = 18;
            this.btn_Aceptar.Tag = "btn_Aceptar";
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_Deuda
            // 
            this.txt_Deuda.Location = new System.Drawing.Point(166, 140);
            this.txt_Deuda.Name = "txt_Deuda";
            this.txt_Deuda.ReadOnly = true;
            this.txt_Deuda.Size = new System.Drawing.Size(144, 20);
            this.txt_Deuda.TabIndex = 23;
            // 
            // lbl_Deuda
            // 
            this.lbl_Deuda.AutoSize = true;
            this.lbl_Deuda.Location = new System.Drawing.Point(163, 124);
            this.lbl_Deuda.Name = "lbl_Deuda";
            this.lbl_Deuda.Size = new System.Drawing.Size(33, 13);
            this.lbl_Deuda.TabIndex = 22;
            this.lbl_Deuda.Tag = "lbl_Deuda";
            this.lbl_Deuda.Text = "Debe";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(6, 140);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(144, 20);
            this.txt_Total.TabIndex = 21;
            this.txt_Total.Tag = "";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(3, 124);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(31, 13);
            this.lbl_Total.TabIndex = 20;
            this.lbl_Total.Tag = "lbl_Total";
            this.lbl_Total.Text = "Total";
            // 
            // txt_Seña
            // 
            this.txt_Seña.Location = new System.Drawing.Point(166, 50);
            this.txt_Seña.Name = "txt_Seña";
            this.txt_Seña.Size = new System.Drawing.Size(144, 20);
            this.txt_Seña.TabIndex = 19;
            // 
            // lbl_Seña
            // 
            this.lbl_Seña.AutoSize = true;
            this.lbl_Seña.Location = new System.Drawing.Point(163, 34);
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
            this.cmb_FormaPago.Location = new System.Drawing.Point(6, 49);
            this.cmb_FormaPago.Name = "cmb_FormaPago";
            this.cmb_FormaPago.Size = new System.Drawing.Size(147, 21);
            this.cmb_FormaPago.TabIndex = 17;
            // 
            // btn_Reservar
            // 
            this.btn_Reservar.Location = new System.Drawing.Point(30, 455);
            this.btn_Reservar.Name = "btn_Reservar";
            this.btn_Reservar.Size = new System.Drawing.Size(150, 40);
            this.btn_Reservar.TabIndex = 18;
            this.btn_Reservar.Tag = "btn_Reservar";
            this.btn_Reservar.Text = "Reservar";
            this.btn_Reservar.UseVisualStyleBackColor = true;
            this.btn_Reservar.Click += new System.EventHandler(this.btn_Reservar_Click);
            // 
            // btn_ModificarReserva
            // 
            this.btn_ModificarReserva.Location = new System.Drawing.Point(209, 455);
            this.btn_ModificarReserva.Name = "btn_ModificarReserva";
            this.btn_ModificarReserva.Size = new System.Drawing.Size(150, 40);
            this.btn_ModificarReserva.TabIndex = 19;
            this.btn_ModificarReserva.Tag = "btn_ModificarReserva";
            this.btn_ModificarReserva.Text = "Modificar reserva";
            this.btn_ModificarReserva.UseVisualStyleBackColor = true;
            this.btn_ModificarReserva.Click += new System.EventHandler(this.btn_ModificarReserva_Click);
            // 
            // btn_EliminarReserva
            // 
            this.btn_EliminarReserva.Location = new System.Drawing.Point(30, 519);
            this.btn_EliminarReserva.Name = "btn_EliminarReserva";
            this.btn_EliminarReserva.Size = new System.Drawing.Size(150, 40);
            this.btn_EliminarReserva.TabIndex = 20;
            this.btn_EliminarReserva.Tag = "btn_EliminarReserva";
            this.btn_EliminarReserva.Text = "Eliminar reserva";
            this.btn_EliminarReserva.UseVisualStyleBackColor = true;
            this.btn_EliminarReserva.Click += new System.EventHandler(this.btn_EliminarReserva_Click);
            // 
            // btn_CancelarReserva
            // 
            this.btn_CancelarReserva.Location = new System.Drawing.Point(209, 519);
            this.btn_CancelarReserva.Name = "btn_CancelarReserva";
            this.btn_CancelarReserva.Size = new System.Drawing.Size(150, 40);
            this.btn_CancelarReserva.TabIndex = 21;
            this.btn_CancelarReserva.Tag = "btn_CancelarReserva";
            this.btn_CancelarReserva.Text = "Cancelar reserva";
            this.btn_CancelarReserva.UseVisualStyleBackColor = true;
            this.btn_CancelarReserva.Click += new System.EventHandler(this.btn_CancelarReserva_Click);
            // 
            // dataGridReservas
            // 
            this.dataGridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservas.Location = new System.Drawing.Point(422, 116);
            this.dataGridReservas.Name = "dataGridReservas";
            this.dataGridReservas.Size = new System.Drawing.Size(1047, 443);
            this.dataGridReservas.TabIndex = 22;
            this.dataGridReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReservas_CellClick);
            // 
            // gbp_Filtros
            // 
            this.gbp_Filtros.Controls.Add(this.btn_Cancelar);
            this.gbp_Filtros.Controls.Add(this.btn_Filtrar);
            this.gbp_Filtros.Controls.Add(this.dateTimePicker1);
            this.gbp_Filtros.Controls.Add(this.chk_Fecha);
            this.gbp_Filtros.Controls.Add(this.chk_Horario);
            this.gbp_Filtros.Controls.Add(this.cmb_Hora2);
            this.gbp_Filtros.Location = new System.Drawing.Point(422, 24);
            this.gbp_Filtros.Name = "gbp_Filtros";
            this.gbp_Filtros.Size = new System.Drawing.Size(544, 82);
            this.gbp_Filtros.TabIndex = 23;
            this.gbp_Filtros.TabStop = false;
            this.gbp_Filtros.Tag = "gbp_Filtros";
            this.gbp_Filtros.Text = "Filtros";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(391, 49);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(134, 23);
            this.btn_Cancelar.TabIndex = 29;
            this.btn_Cancelar.Tag = "btn_Cancelar";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(391, 20);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(134, 23);
            this.btn_Filtrar.TabIndex = 24;
            this.btn_Filtrar.Tag = "btn_Filtrar";
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Tag = "";
            // 
            // chk_Fecha
            // 
            this.chk_Fecha.AutoSize = true;
            this.chk_Fecha.Location = new System.Drawing.Point(24, 18);
            this.chk_Fecha.Name = "chk_Fecha";
            this.chk_Fecha.Size = new System.Drawing.Size(56, 17);
            this.chk_Fecha.TabIndex = 28;
            this.chk_Fecha.Tag = "chk_Fecha";
            this.chk_Fecha.Text = "Fecha";
            this.chk_Fecha.UseVisualStyleBackColor = true;
            // 
            // chk_Horario
            // 
            this.chk_Horario.AutoSize = true;
            this.chk_Horario.Location = new System.Drawing.Point(211, 18);
            this.chk_Horario.Name = "chk_Horario";
            this.chk_Horario.Size = new System.Drawing.Size(49, 17);
            this.chk_Horario.TabIndex = 26;
            this.chk_Horario.Tag = "chk_Horario";
            this.chk_Horario.Text = "Hora";
            this.chk_Horario.UseVisualStyleBackColor = true;
            // 
            // cmb_Hora2
            // 
            this.cmb_Hora2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Hora2.FormattingEnabled = true;
            this.cmb_Hora2.Location = new System.Drawing.Point(211, 41);
            this.cmb_Hora2.Name = "cmb_Hora2";
            this.cmb_Hora2.Size = new System.Drawing.Size(153, 21);
            this.cmb_Hora2.TabIndex = 25;
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 578);
            this.Controls.Add(this.gbp_Filtros);
            this.Controls.Add(this.dataGridReservas);
            this.Controls.Add(this.btn_CancelarReserva);
            this.Controls.Add(this.btn_EliminarReserva);
            this.Controls.Add(this.btn_ModificarReserva);
            this.Controls.Add(this.btn_Reservar);
            this.Controls.Add(this.gpb_Pago);
            this.Controls.Add(this.cmb_Hora1);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.lbl_IngreseFecha);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.rdb_No);
            this.Controls.Add(this.rdb_Si);
            this.Controls.Add(this.lbl_EsCliente);
            this.Controls.Add(this.btn_AltaCliente);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Cliente);
            this.Controls.Add(this.cmb_Cancha);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.label1);
            this.Name = "Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.gpb_Pago.ResumeLayout(false);
            this.gpb_Pago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservas)).EndInit();
            this.gbp_Filtros.ResumeLayout(false);
            this.gbp_Filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.ComboBox cmb_Cancha;
        private System.Windows.Forms.ComboBox cmb_Cliente;
        private System.Windows.Forms.ComboBox cmb_Tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AltaCliente;
        private System.Windows.Forms.Label lbl_EsCliente;
        private System.Windows.Forms.RadioButton rdb_Si;
        private System.Windows.Forms.RadioButton rdb_No;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Label lbl_IngreseFecha;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.ComboBox cmb_Hora1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpb_Pago;
        private System.Windows.Forms.ComboBox cmb_FormaPago;
        private System.Windows.Forms.Label lbl_Seña;
        private System.Windows.Forms.TextBox txt_Seña;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_Deuda;
        private System.Windows.Forms.Label lbl_Deuda;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Reservar;
        private System.Windows.Forms.Button btn_ModificarReserva;
        private System.Windows.Forms.Button btn_EliminarReserva;
        private System.Windows.Forms.Button btn_CancelarReserva;
        private System.Windows.Forms.DataGridView dataGridReservas;
        private System.Windows.Forms.GroupBox gbp_Filtros;
        private System.Windows.Forms.CheckBox chk_Horario;
        private System.Windows.Forms.ComboBox cmb_Hora2;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chk_Fecha;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}