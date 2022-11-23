namespace Software_Canchas_2022
{
    partial class ErrorIntegridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorIntegridad));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_RecalcularDV = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.dataGridTabla = new System.Windows.Forms.DataGridView();
            this.lbl_Tabla1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 0;
            // 
            // btn_RecalcularDV
            // 
            this.btn_RecalcularDV.Location = new System.Drawing.Point(219, 434);
            this.btn_RecalcularDV.Name = "btn_RecalcularDV";
            this.btn_RecalcularDV.Size = new System.Drawing.Size(134, 50);
            this.btn_RecalcularDV.TabIndex = 1;
            this.btn_RecalcularDV.Text = "Recalcular Digitos Verificadores";
            this.btn_RecalcularDV.UseVisualStyleBackColor = true;
            this.btn_RecalcularDV.Click += new System.EventHandler(this.btn_RecalcularDV_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.Location = new System.Drawing.Point(418, 434);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(134, 50);
            this.btn_Restore.TabIndex = 2;
            this.btn_Restore.Text = "Restaurar";
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // dataGridTabla
            // 
            this.dataGridTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTabla.Location = new System.Drawing.Point(57, 148);
            this.dataGridTabla.Name = "dataGridTabla";
            this.dataGridTabla.Size = new System.Drawing.Size(689, 265);
            this.dataGridTabla.TabIndex = 3;
            // 
            // lbl_Tabla1
            // 
            this.lbl_Tabla1.AutoSize = true;
            this.lbl_Tabla1.Location = new System.Drawing.Point(12, 9);
            this.lbl_Tabla1.Name = "lbl_Tabla1";
            this.lbl_Tabla1.Size = new System.Drawing.Size(0, 13);
            this.lbl_Tabla1.TabIndex = 4;
            this.lbl_Tabla1.Visible = false;
            // 
            // ErrorIntegridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 504);
            this.Controls.Add(this.lbl_Tabla1);
            this.Controls.Add(this.dataGridTabla);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.btn_RecalcularDV);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ErrorIntegridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorIntegridad";
            this.Load += new System.EventHandler(this.ErrorIntegridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_RecalcularDV;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.DataGridView dataGridTabla;
        private System.Windows.Forms.Label lbl_Tabla1;
    }
}