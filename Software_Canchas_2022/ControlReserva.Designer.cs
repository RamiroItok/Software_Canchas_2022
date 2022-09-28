namespace Software_Canchas_2022
{
    partial class ControlReserva
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridControl
            // 
            this.dataGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridControl.Location = new System.Drawing.Point(12, 26);
            this.dataGridControl.Name = "dataGridControl";
            this.dataGridControl.Size = new System.Drawing.Size(1076, 412);
            this.dataGridControl.TabIndex = 0;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(990, 444);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(98, 32);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Tag = "btn_Salir";
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // ControlReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 496);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dataGridControl);
            this.Name = "ControlReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlReserva";
            this.Load += new System.EventHandler(this.ControlReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridControl;
        private System.Windows.Forms.Button btn_Salir;
    }
}