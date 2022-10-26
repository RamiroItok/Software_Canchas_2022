namespace Software_Canchas_2022
{
    partial class Bitacora
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
            this.lbl_FechaDesde = new System.Windows.Forms.Label();
            this.chk_Fecha = new System.Windows.Forms.CheckBox();
            this.dtp_FechaDesde1 = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaHasta1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaHasta = new System.Windows.Forms.Label();
            this.chk_Usuario = new System.Windows.Forms.CheckBox();
            this.cmb_Usuarios = new System.Windows.Forms.ComboBox();
            this.cmb_Criticidad = new System.Windows.Forms.ComboBox();
            this.chk_Criticidad = new System.Windows.Forms.CheckBox();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.btn_Cancelar1 = new System.Windows.Forms.Button();
            this.dataGridBitacora = new System.Windows.Forms.DataGridView();
            this.lbl_EliminarBitacora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_FechaDesde2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaHasta2 = new System.Windows.Forms.DateTimePicker();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FechaDesde
            // 
            this.lbl_FechaDesde.AutoSize = true;
            this.lbl_FechaDesde.Location = new System.Drawing.Point(32, 42);
            this.lbl_FechaDesde.Name = "lbl_FechaDesde";
            this.lbl_FechaDesde.Size = new System.Drawing.Size(69, 13);
            this.lbl_FechaDesde.TabIndex = 0;
            this.lbl_FechaDesde.Tag = "lbl_FechaDesde";
            this.lbl_FechaDesde.Text = "Fecha desde";
            // 
            // chk_Fecha
            // 
            this.chk_Fecha.AutoSize = true;
            this.chk_Fecha.Location = new System.Drawing.Point(35, 24);
            this.chk_Fecha.Name = "chk_Fecha";
            this.chk_Fecha.Size = new System.Drawing.Size(56, 17);
            this.chk_Fecha.TabIndex = 1;
            this.chk_Fecha.Tag = "chk_Fecha";
            this.chk_Fecha.Text = "Fecha";
            this.chk_Fecha.UseVisualStyleBackColor = true;
            // 
            // dtp_FechaDesde1
            // 
            this.dtp_FechaDesde1.Location = new System.Drawing.Point(35, 56);
            this.dtp_FechaDesde1.Name = "dtp_FechaDesde1";
            this.dtp_FechaDesde1.Size = new System.Drawing.Size(192, 20);
            this.dtp_FechaDesde1.TabIndex = 2;
            // 
            // dtp_FechaHasta1
            // 
            this.dtp_FechaHasta1.Location = new System.Drawing.Point(260, 55);
            this.dtp_FechaHasta1.Name = "dtp_FechaHasta1";
            this.dtp_FechaHasta1.Size = new System.Drawing.Size(192, 20);
            this.dtp_FechaHasta1.TabIndex = 4;
            // 
            // lbl_FechaHasta
            // 
            this.lbl_FechaHasta.AutoSize = true;
            this.lbl_FechaHasta.Location = new System.Drawing.Point(257, 39);
            this.lbl_FechaHasta.Name = "lbl_FechaHasta";
            this.lbl_FechaHasta.Size = new System.Drawing.Size(66, 13);
            this.lbl_FechaHasta.TabIndex = 3;
            this.lbl_FechaHasta.Tag = "lbl_FechaHasta";
            this.lbl_FechaHasta.Text = "Fecha hasta";
            // 
            // chk_Usuario
            // 
            this.chk_Usuario.AutoSize = true;
            this.chk_Usuario.Location = new System.Drawing.Point(496, 32);
            this.chk_Usuario.Name = "chk_Usuario";
            this.chk_Usuario.Size = new System.Drawing.Size(62, 17);
            this.chk_Usuario.TabIndex = 5;
            this.chk_Usuario.Text = "Usuario";
            this.chk_Usuario.UseVisualStyleBackColor = true;
            // 
            // cmb_Usuarios
            // 
            this.cmb_Usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Usuarios.FormattingEnabled = true;
            this.cmb_Usuarios.Location = new System.Drawing.Point(496, 55);
            this.cmb_Usuarios.Name = "cmb_Usuarios";
            this.cmb_Usuarios.Size = new System.Drawing.Size(173, 21);
            this.cmb_Usuarios.TabIndex = 7;
            // 
            // cmb_Criticidad
            // 
            this.cmb_Criticidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Criticidad.FormattingEnabled = true;
            this.cmb_Criticidad.Items.AddRange(new object[] {
            "ALTA",
            "MEDIA",
            "BAJA"});
            this.cmb_Criticidad.Location = new System.Drawing.Point(708, 55);
            this.cmb_Criticidad.Name = "cmb_Criticidad";
            this.cmb_Criticidad.Size = new System.Drawing.Size(173, 21);
            this.cmb_Criticidad.TabIndex = 10;
            // 
            // chk_Criticidad
            // 
            this.chk_Criticidad.AutoSize = true;
            this.chk_Criticidad.Location = new System.Drawing.Point(708, 32);
            this.chk_Criticidad.Name = "chk_Criticidad";
            this.chk_Criticidad.Size = new System.Drawing.Size(69, 17);
            this.chk_Criticidad.TabIndex = 8;
            this.chk_Criticidad.Tag = "chk_Criticidad";
            this.chk_Criticidad.Text = "Criticidad";
            this.chk_Criticidad.UseVisualStyleBackColor = true;
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(626, 92);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(119, 28);
            this.btn_Filtrar.TabIndex = 11;
            this.btn_Filtrar.Tag = "btn_Filtrar";
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // btn_Cancelar1
            // 
            this.btn_Cancelar1.Location = new System.Drawing.Point(762, 92);
            this.btn_Cancelar1.Name = "btn_Cancelar1";
            this.btn_Cancelar1.Size = new System.Drawing.Size(119, 28);
            this.btn_Cancelar1.TabIndex = 12;
            this.btn_Cancelar1.Tag = "btn_Cancelar";
            this.btn_Cancelar1.Text = "Cancelar";
            this.btn_Cancelar1.UseVisualStyleBackColor = true;
            this.btn_Cancelar1.Click += new System.EventHandler(this.btn_Cancelar1_Click);
            // 
            // dataGridBitacora
            // 
            this.dataGridBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBitacora.Location = new System.Drawing.Point(23, 131);
            this.dataGridBitacora.Name = "dataGridBitacora";
            this.dataGridBitacora.Size = new System.Drawing.Size(852, 306);
            this.dataGridBitacora.TabIndex = 13;
            // 
            // lbl_EliminarBitacora
            // 
            this.lbl_EliminarBitacora.AutoSize = true;
            this.lbl_EliminarBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EliminarBitacora.Location = new System.Drawing.Point(32, 456);
            this.lbl_EliminarBitacora.Name = "lbl_EliminarBitacora";
            this.lbl_EliminarBitacora.Size = new System.Drawing.Size(120, 18);
            this.lbl_EliminarBitacora.TabIndex = 14;
            this.lbl_EliminarBitacora.Tag = "lbl_EliminarBitacora";
            this.lbl_EliminarBitacora.Text = "Eliminar Bitacora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 15;
            this.label1.Tag = "lbl_FechaDesde";
            this.label1.Text = "Fecha desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 16;
            this.label2.Tag = "lbl_FechaHasta";
            this.label2.Text = "Fecha hasta";
            // 
            // dtp_FechaDesde2
            // 
            this.dtp_FechaDesde2.Location = new System.Drawing.Point(35, 503);
            this.dtp_FechaDesde2.Name = "dtp_FechaDesde2";
            this.dtp_FechaDesde2.Size = new System.Drawing.Size(210, 20);
            this.dtp_FechaDesde2.TabIndex = 17;
            // 
            // dtp_FechaHasta2
            // 
            this.dtp_FechaHasta2.Location = new System.Drawing.Point(274, 503);
            this.dtp_FechaHasta2.Name = "dtp_FechaHasta2";
            this.dtp_FechaHasta2.Size = new System.Drawing.Size(204, 20);
            this.dtp_FechaHasta2.TabIndex = 18;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(514, 496);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(92, 27);
            this.btn_Eliminar.TabIndex = 19;
            this.btn_Eliminar.Tag = "btn_Eliminar";
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Cancelar2
            // 
            this.btn_Cancelar2.Location = new System.Drawing.Point(626, 497);
            this.btn_Cancelar2.Name = "btn_Cancelar2";
            this.btn_Cancelar2.Size = new System.Drawing.Size(92, 26);
            this.btn_Cancelar2.TabIndex = 20;
            this.btn_Cancelar2.Tag = "btn_Cancelar";
            this.btn_Cancelar2.Text = "Cancelar";
            this.btn_Cancelar2.UseVisualStyleBackColor = true;
            this.btn_Cancelar2.Click += new System.EventHandler(this.btn_Cancelar2_Click);
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 548);
            this.Controls.Add(this.btn_Cancelar2);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dtp_FechaHasta2);
            this.Controls.Add(this.dtp_FechaDesde2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_EliminarBitacora);
            this.Controls.Add(this.dataGridBitacora);
            this.Controls.Add(this.btn_Cancelar1);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.cmb_Criticidad);
            this.Controls.Add(this.chk_Criticidad);
            this.Controls.Add(this.cmb_Usuarios);
            this.Controls.Add(this.chk_Usuario);
            this.Controls.Add(this.dtp_FechaHasta1);
            this.Controls.Add(this.lbl_FechaHasta);
            this.Controls.Add(this.dtp_FechaDesde1);
            this.Controls.Add(this.chk_Fecha);
            this.Controls.Add(this.lbl_FechaDesde);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FechaDesde;
        private System.Windows.Forms.CheckBox chk_Fecha;
        private System.Windows.Forms.DateTimePicker dtp_FechaDesde1;
        private System.Windows.Forms.DateTimePicker dtp_FechaHasta1;
        private System.Windows.Forms.Label lbl_FechaHasta;
        private System.Windows.Forms.CheckBox chk_Usuario;
        private System.Windows.Forms.ComboBox cmb_Usuarios;
        private System.Windows.Forms.ComboBox cmb_Criticidad;
        private System.Windows.Forms.CheckBox chk_Criticidad;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.Button btn_Cancelar1;
        private System.Windows.Forms.DataGridView dataGridBitacora;
        private System.Windows.Forms.Label lbl_EliminarBitacora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_FechaDesde2;
        private System.Windows.Forms.DateTimePicker dtp_FechaHasta2;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cancelar2;
    }
}