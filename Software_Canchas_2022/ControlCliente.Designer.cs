namespace Software_Canchas_2022
{
    partial class ControlCliente
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
            this.dataGridControl = new System.Windows.Forms.DataGridView();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Restaurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridControl
            // 
            this.dataGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridControl.Location = new System.Drawing.Point(12, 26);
            this.dataGridControl.Name = "dataGridControl";
            this.dataGridControl.Size = new System.Drawing.Size(958, 412);
            this.dataGridControl.TabIndex = 0;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(872, 444);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(98, 32);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Tag = "btn_Salir";
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Location = new System.Drawing.Point(754, 444);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(98, 32);
            this.btn_Restaurar.TabIndex = 2;
            this.btn_Restaurar.Tag = "btn_Restaurar";
            this.btn_Restaurar.Text = "Restaurar";
            this.btn_Restaurar.UseVisualStyleBackColor = true;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // ControlCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 496);
            this.Controls.Add(this.btn_Restaurar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dataGridControl);
            this.Name = "ControlCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Control_Cliente";
            this.Text = "ControlCliente";
            this.Load += new System.EventHandler(this.ControlCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridControl;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Restaurar;
    }
}