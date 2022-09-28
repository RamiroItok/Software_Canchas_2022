namespace Software_Canchas_2022
{
    partial class LogInSeguridad
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
            this.lbl_Nombre_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txt_Nombre_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nombre_Usuario
            // 
            this.lbl_Nombre_Usuario.AutoSize = true;
            this.lbl_Nombre_Usuario.Location = new System.Drawing.Point(42, 28);
            this.lbl_Nombre_Usuario.Name = "lbl_Nombre_Usuario";
            this.lbl_Nombre_Usuario.Size = new System.Drawing.Size(83, 13);
            this.lbl_Nombre_Usuario.TabIndex = 0;
            this.lbl_Nombre_Usuario.Tag = "lbl_Nombre_Usuario";
            this.lbl_Nombre_Usuario.Text = "Nombre Usuario";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(42, 90);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_Contraseña.TabIndex = 1;
            this.lbl_Contraseña.Tag = "lbl_Contraseña";
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // txt_Nombre_Usuario
            // 
            this.txt_Nombre_Usuario.Location = new System.Drawing.Point(45, 44);
            this.txt_Nombre_Usuario.Name = "txt_Nombre_Usuario";
            this.txt_Nombre_Usuario.Size = new System.Drawing.Size(198, 20);
            this.txt_Nombre_Usuario.TabIndex = 2;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(45, 106);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(198, 20);
            this.txt_Contraseña.TabIndex = 3;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(45, 163);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(86, 29);
            this.btn_Aceptar.TabIndex = 4;
            this.btn_Aceptar.Tag = "btn_Aceptar";
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(157, 163);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(86, 29);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Tag = "btn_Cancelar";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // LogInSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 225);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Nombre_Usuario);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Nombre_Usuario);
            this.Name = "LogInSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInSeguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre_Usuario;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox txt_Nombre_Usuario;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}