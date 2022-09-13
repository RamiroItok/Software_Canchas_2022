namespace Software_Canchas_2022
{
    partial class Gestion_Canchas
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
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridCanchas = new System.Windows.Forms.DataGridView();
            this.lbl_Id_Cancha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCanchas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "F5",
            "F8",
            "F11"});
            this.cmbTipo.Location = new System.Drawing.Point(51, 47);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(142, 21);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.Tag = "cmb_Tipo";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Items.AddRange(new object[] {
            "Cesped sintetico",
            "Cesped natural",
            "Piso"});
            this.cmbMaterial.Location = new System.Drawing.Point(51, 110);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(142, 21);
            this.cmbMaterial.TabIndex = 1;
            this.cmbMaterial.Tag = "cmb_Material";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(48, 31);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Tag = "lbl_Tipo";
            this.lblTipo.Text = "Tipo";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(48, 94);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial.TabIndex = 3;
            this.lblMaterial.Tag = "lbl_Material";
            this.lblMaterial.Text = "Material";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(16, 171);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(99, 43);
            this.btnAlta.TabIndex = 4;
            this.btnAlta.Tag = "btn_Alta_Cancha";
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(140, 171);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 43);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Tag = "btn_Modificar";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(16, 231);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(99, 43);
            this.btnBaja.TabIndex = 6;
            this.btnBaja.Tag = "btn_Baja";
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(140, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 43);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Tag = "btn_Cancelar";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridCanchas
            // 
            this.dataGridCanchas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCanchas.Location = new System.Drawing.Point(266, 24);
            this.dataGridCanchas.Name = "dataGridCanchas";
            this.dataGridCanchas.Size = new System.Drawing.Size(506, 250);
            this.dataGridCanchas.TabIndex = 8;
            this.dataGridCanchas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCanchas_CellClick);
            // 
            // lbl_Id_Cancha
            // 
            this.lbl_Id_Cancha.AutoSize = true;
            this.lbl_Id_Cancha.Enabled = false;
            this.lbl_Id_Cancha.Location = new System.Drawing.Point(48, 9);
            this.lbl_Id_Cancha.Name = "lbl_Id_Cancha";
            this.lbl_Id_Cancha.Size = new System.Drawing.Size(0, 13);
            this.lbl_Id_Cancha.TabIndex = 9;
            this.lbl_Id_Cancha.Visible = false;
            // 
            // Gestion_Canchas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.lbl_Id_Cancha);
            this.Controls.Add(this.dataGridCanchas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.cmbTipo);
            this.Name = "Gestion_Canchas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Gestion_Canchas";
            this.Text = "Gestion Canchas";
            this.Load += new System.EventHandler(this.Gestion_Canchas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCanchas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridCanchas;
        private System.Windows.Forms.Label lbl_Id_Cancha;
    }
}