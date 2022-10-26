namespace Software_Canchas_2022
{
    partial class Restore
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
            this.lbl_Origen = new System.Windows.Forms.Label();
            this.txt_explorador = new System.Windows.Forms.TextBox();
            this.btn_explorador = new System.Windows.Forms.Button();
            this.btn_RealizarRestore = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Origen
            // 
            this.lbl_Origen.AutoSize = true;
            this.lbl_Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Origen.Location = new System.Drawing.Point(104, 36);
            this.lbl_Origen.Name = "lbl_Origen";
            this.lbl_Origen.Size = new System.Drawing.Size(68, 24);
            this.lbl_Origen.TabIndex = 0;
            this.lbl_Origen.Tag = "lbl_Origen";
            this.lbl_Origen.Text = "Origen";
            // 
            // txt_explorador
            // 
            this.txt_explorador.Location = new System.Drawing.Point(108, 63);
            this.txt_explorador.Name = "txt_explorador";
            this.txt_explorador.Size = new System.Drawing.Size(365, 20);
            this.txt_explorador.TabIndex = 1;
            // 
            // btn_explorador
            // 
            this.btn_explorador.Location = new System.Drawing.Point(495, 53);
            this.btn_explorador.Name = "btn_explorador";
            this.btn_explorador.Size = new System.Drawing.Size(39, 30);
            this.btn_explorador.TabIndex = 2;
            this.btn_explorador.Text = "...";
            this.btn_explorador.UseVisualStyleBackColor = true;
            this.btn_explorador.Click += new System.EventHandler(this.btn_explorador_Click);
            // 
            // btn_RealizarRestore
            // 
            this.btn_RealizarRestore.Location = new System.Drawing.Point(158, 104);
            this.btn_RealizarRestore.Name = "btn_RealizarRestore";
            this.btn_RealizarRestore.Size = new System.Drawing.Size(125, 42);
            this.btn_RealizarRestore.TabIndex = 3;
            this.btn_RealizarRestore.Tag = "btn_RealizarRestore";
            this.btn_RealizarRestore.Text = "Realizar Restore";
            this.btn_RealizarRestore.UseVisualStyleBackColor = true;
            this.btn_RealizarRestore.Click += new System.EventHandler(this.btn_RealizarRestore_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(343, 104);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(125, 42);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Tag = "btn_Cancelar";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 185);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_RealizarRestore);
            this.Controls.Add(this.btn_explorador);
            this.Controls.Add(this.txt_explorador);
            this.Controls.Add(this.lbl_Origen);
            this.Name = "Restore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Origen;
        private System.Windows.Forms.TextBox txt_explorador;
        private System.Windows.Forms.Button btn_explorador;
        private System.Windows.Forms.Button btn_RealizarRestore;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}