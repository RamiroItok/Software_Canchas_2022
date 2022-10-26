namespace Software_Canchas_2022
{
    partial class GestionDeudas
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
            this.dataGridDeudas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeudas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDeudas
            // 
            this.dataGridDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeudas.Location = new System.Drawing.Point(119, 58);
            this.dataGridDeudas.Name = "dataGridDeudas";
            this.dataGridDeudas.Size = new System.Drawing.Size(780, 382);
            this.dataGridDeudas.TabIndex = 0;
            // 
            // GestionDeudas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 478);
            this.Controls.Add(this.dataGridDeudas);
            this.Name = "GestionDeudas";
            this.Text = "GestionDeudas";
            this.Load += new System.EventHandler(this.GestionDeudas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeudas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDeudas;
    }
}