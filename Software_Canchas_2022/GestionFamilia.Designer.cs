namespace Software_Canchas_2022
{
    partial class GestionFamilia
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
            this.lbl_NombreFamilia = new System.Windows.Forms.Label();
            this.txt_Familia = new System.Windows.Forms.TextBox();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dataGridFamilia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFamilia)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NombreFamilia
            // 
            this.lbl_NombreFamilia.AutoSize = true;
            this.lbl_NombreFamilia.Location = new System.Drawing.Point(42, 82);
            this.lbl_NombreFamilia.Name = "lbl_NombreFamilia";
            this.lbl_NombreFamilia.Size = new System.Drawing.Size(91, 13);
            this.lbl_NombreFamilia.TabIndex = 0;
            this.lbl_NombreFamilia.Tag = "lbl_NombreFamilia";
            this.lbl_NombreFamilia.Text = "Nombre de familia";
            // 
            // txt_Familia
            // 
            this.txt_Familia.Location = new System.Drawing.Point(45, 98);
            this.txt_Familia.Name = "txt_Familia";
            this.txt_Familia.Size = new System.Drawing.Size(213, 20);
            this.txt_Familia.TabIndex = 1;
            this.txt_Familia.Tag = "txt_Familia";
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(45, 144);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(93, 33);
            this.btn_Alta.TabIndex = 2;
            this.btn_Alta.Tag = "btn_Alta";
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(165, 144);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(93, 33);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Tag = "btn_Cancelar";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dataGridFamilia
            // 
            this.dataGridFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFamilia.Location = new System.Drawing.Point(309, 28);
            this.dataGridFamilia.Name = "dataGridFamilia";
            this.dataGridFamilia.Size = new System.Drawing.Size(255, 286);
            this.dataGridFamilia.TabIndex = 4;
            // 
            // GestionFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 336);
            this.Controls.Add(this.dataGridFamilia);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.txt_Familia);
            this.Controls.Add(this.lbl_NombreFamilia);
            this.Name = "GestionFamilia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionFamilia";
            this.Load += new System.EventHandler(this.GestionFamilia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFamilia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NombreFamilia;
        private System.Windows.Forms.TextBox txt_Familia;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridView dataGridFamilia;
    }
}