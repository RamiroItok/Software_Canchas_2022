namespace Software_Canchas_2022
{
    partial class Gestion_Etiquetas
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
            this.lbl_Idioma = new System.Windows.Forms.Label();
            this.lbl_Etiqueta = new System.Windows.Forms.Label();
            this.cmb_Idioma = new System.Windows.Forms.ComboBox();
            this.cmb_Etiqueta = new System.Windows.Forms.ComboBox();
            this.lbl_Traduccion = new System.Windows.Forms.Label();
            this.txt_Traducciones = new System.Windows.Forms.TextBox();
            this.dataGridEtiquetas = new System.Windows.Forms.DataGridView();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Idioma
            // 
            this.lbl_Idioma.AutoSize = true;
            this.lbl_Idioma.Location = new System.Drawing.Point(26, 21);
            this.lbl_Idioma.Name = "lbl_Idioma";
            this.lbl_Idioma.Size = new System.Drawing.Size(38, 13);
            this.lbl_Idioma.TabIndex = 0;
            this.lbl_Idioma.Tag = "lbl_Idioma";
            this.lbl_Idioma.Text = "Idioma";
            // 
            // lbl_Etiqueta
            // 
            this.lbl_Etiqueta.AutoSize = true;
            this.lbl_Etiqueta.Location = new System.Drawing.Point(26, 80);
            this.lbl_Etiqueta.Name = "lbl_Etiqueta";
            this.lbl_Etiqueta.Size = new System.Drawing.Size(46, 13);
            this.lbl_Etiqueta.TabIndex = 1;
            this.lbl_Etiqueta.Tag = "lbl_Etiqueta";
            this.lbl_Etiqueta.Text = "Etiqueta";
            // 
            // cmb_Idioma
            // 
            this.cmb_Idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Idioma.FormattingEnabled = true;
            this.cmb_Idioma.Location = new System.Drawing.Point(29, 37);
            this.cmb_Idioma.Name = "cmb_Idioma";
            this.cmb_Idioma.Size = new System.Drawing.Size(194, 21);
            this.cmb_Idioma.TabIndex = 2;
            this.cmb_Idioma.Tag = "cmb_Idioma";
            this.cmb_Idioma.SelectedIndexChanged += new System.EventHandler(this.cmb_Idioma_SelectedIndexChanged);
            // 
            // cmb_Etiqueta
            // 
            this.cmb_Etiqueta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Etiqueta.FormattingEnabled = true;
            this.cmb_Etiqueta.Location = new System.Drawing.Point(29, 96);
            this.cmb_Etiqueta.Name = "cmb_Etiqueta";
            this.cmb_Etiqueta.Size = new System.Drawing.Size(194, 21);
            this.cmb_Etiqueta.TabIndex = 3;
            this.cmb_Etiqueta.Tag = "cmb_Etiqueta";
            // 
            // lbl_Traduccion
            // 
            this.lbl_Traduccion.AutoSize = true;
            this.lbl_Traduccion.Location = new System.Drawing.Point(29, 143);
            this.lbl_Traduccion.Name = "lbl_Traduccion";
            this.lbl_Traduccion.Size = new System.Drawing.Size(61, 13);
            this.lbl_Traduccion.TabIndex = 4;
            this.lbl_Traduccion.Tag = "lbl_Traduccion";
            this.lbl_Traduccion.Text = "Traduccion";
            // 
            // txt_Traducciones
            // 
            this.txt_Traducciones.Location = new System.Drawing.Point(29, 159);
            this.txt_Traducciones.Name = "txt_Traducciones";
            this.txt_Traducciones.Size = new System.Drawing.Size(194, 20);
            this.txt_Traducciones.TabIndex = 5;
            this.txt_Traducciones.Tag = "txt_Traducciones";
            // 
            // dataGridEtiquetas
            // 
            this.dataGridEtiquetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEtiquetas.Location = new System.Drawing.Point(250, 18);
            this.dataGridEtiquetas.Name = "dataGridEtiquetas";
            this.dataGridEtiquetas.Size = new System.Drawing.Size(600, 389);
            this.dataGridEtiquetas.TabIndex = 6;
            this.dataGridEtiquetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEtiquetas_CellClick);
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(29, 209);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(92, 36);
            this.btn_Alta.TabIndex = 7;
            this.btn_Alta.Tag = "btn_Alta";
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(131, 209);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(92, 36);
            this.btn_Modificar.TabIndex = 8;
            this.btn_Modificar.Tag = "btn_Modificar";
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(83, 260);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(92, 36);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Tag = "btn_Cancelar";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(188, 9);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(29, 13);
            this.lbl_Id.TabIndex = 10;
            this.lbl_Id.Text = "label";
            this.lbl_Id.Visible = false;
            // 
            // Gestion_Etiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 422);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.dataGridEtiquetas);
            this.Controls.Add(this.txt_Traducciones);
            this.Controls.Add(this.lbl_Traduccion);
            this.Controls.Add(this.cmb_Etiqueta);
            this.Controls.Add(this.cmb_Idioma);
            this.Controls.Add(this.lbl_Etiqueta);
            this.Controls.Add(this.lbl_Idioma);
            this.Name = "Gestion_Etiquetas";
            this.Text = "Gestion_Etiquetas";
            this.Load += new System.EventHandler(this.Gestion_Etiquetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtiquetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Idioma;
        private System.Windows.Forms.Label lbl_Etiqueta;
        private System.Windows.Forms.ComboBox cmb_Idioma;
        private System.Windows.Forms.ComboBox cmb_Etiqueta;
        private System.Windows.Forms.Label lbl_Traduccion;
        private System.Windows.Forms.TextBox txt_Traducciones;
        private System.Windows.Forms.DataGridView dataGridEtiquetas;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Id;
    }
}