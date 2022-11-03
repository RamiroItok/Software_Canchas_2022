namespace Software_Canchas_2022
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Destino = new System.Windows.Forms.Label();
            this.txt_Explorador = new System.Windows.Forms.TextBox();
            this.btn_Explorador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Backup
            // 
            this.btn_Backup.Location = new System.Drawing.Point(167, 115);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(116, 46);
            this.btn_Backup.TabIndex = 3;
            this.btn_Backup.Tag = "btn_Backup";
            this.btn_Backup.Text = "Realizar Backup";
            this.btn_Backup.UseVisualStyleBackColor = true;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(332, 115);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(116, 46);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Tag = "btn_Cancelar";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Destino
            // 
            this.lbl_Destino.AutoSize = true;
            this.lbl_Destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Destino.Location = new System.Drawing.Point(90, 51);
            this.lbl_Destino.Name = "lbl_Destino";
            this.lbl_Destino.Size = new System.Drawing.Size(73, 24);
            this.lbl_Destino.TabIndex = 5;
            this.lbl_Destino.Tag = "lbl_Destino";
            this.lbl_Destino.Text = "Destino";
            // 
            // txt_Explorador
            // 
            this.txt_Explorador.Location = new System.Drawing.Point(94, 78);
            this.txt_Explorador.Name = "txt_Explorador";
            this.txt_Explorador.Size = new System.Drawing.Size(394, 20);
            this.txt_Explorador.TabIndex = 6;
            // 
            // btn_Explorador
            // 
            this.btn_Explorador.Location = new System.Drawing.Point(506, 69);
            this.btn_Explorador.Name = "btn_Explorador";
            this.btn_Explorador.Size = new System.Drawing.Size(38, 29);
            this.btn_Explorador.TabIndex = 7;
            this.btn_Explorador.Text = "...";
            this.btn_Explorador.UseVisualStyleBackColor = true;
            this.btn_Explorador.Click += new System.EventHandler(this.btn_Explorador_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 211);
            this.Controls.Add(this.btn_Explorador);
            this.Controls.Add(this.txt_Explorador);
            this.Controls.Add(this.lbl_Destino);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Backup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Destino;
        private System.Windows.Forms.TextBox txt_Explorador;
        private System.Windows.Forms.Button btn_Explorador;
    }
}