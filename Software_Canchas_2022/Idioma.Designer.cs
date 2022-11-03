namespace Software_Canchas_2022
{
    partial class Idioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Idioma));
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dataGirdIdioma = new System.Windows.Forms.DataGridView();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.lbl_Id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdIdioma)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(25, 35);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Tag = "lbl_Nombre";
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(28, 51);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(195, 20);
            this.txt_Nombre.TabIndex = 1;
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(28, 91);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(94, 38);
            this.btn_Alta.TabIndex = 2;
            this.btn_Alta.Tag = "btn_Alta";
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(77, 147);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 38);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Tag = "btn_Cancelar";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dataGirdIdioma
            // 
            this.dataGirdIdioma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGirdIdioma.Location = new System.Drawing.Point(240, 12);
            this.dataGirdIdioma.Name = "dataGirdIdioma";
            this.dataGirdIdioma.Size = new System.Drawing.Size(240, 200);
            this.dataGirdIdioma.TabIndex = 4;
            this.dataGirdIdioma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGirdIdioma_CellClick);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(129, 91);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(94, 38);
            this.btn_Modificar.TabIndex = 5;
            this.btn_Modificar.Tag = "btn_Modificar";
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(177, 12);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(0, 13);
            this.lbl_Id.TabIndex = 6;
            // 
            // Idioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 224);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.dataGirdIdioma);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Idioma";
            this.Tag = "form_Idioma";
            this.Text = "Idioma";
            this.Load += new System.EventHandler(this.Idioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdIdioma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridView dataGirdIdioma;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label lbl_Id;
    }
}