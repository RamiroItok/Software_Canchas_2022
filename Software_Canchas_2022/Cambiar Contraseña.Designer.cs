namespace Software_Canchas_2022
{
    partial class Cambiar_Contraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cambiar_Contraseña));
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_ContraseñaActual = new System.Windows.Forms.Label();
            this.lbl_NuevaContraseña = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ContraseñaActual = new System.Windows.Forms.TextBox();
            this.txt_NuevaContraseña = new System.Windows.Forms.TextBox();
            this.txt_ConfirmarContraseñaNueva = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_usuario_nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(75, 28);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Tag = "lbl_Usuario";
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_ContraseñaActual
            // 
            this.lbl_ContraseñaActual.AutoSize = true;
            this.lbl_ContraseñaActual.Location = new System.Drawing.Point(76, 89);
            this.lbl_ContraseñaActual.Name = "lbl_ContraseñaActual";
            this.lbl_ContraseñaActual.Size = new System.Drawing.Size(93, 13);
            this.lbl_ContraseñaActual.TabIndex = 1;
            this.lbl_ContraseñaActual.Tag = "lbl_ContraseñaActual";
            this.lbl_ContraseñaActual.Text = "Contraseña actual";
            // 
            // lbl_NuevaContraseña
            // 
            this.lbl_NuevaContraseña.AutoSize = true;
            this.lbl_NuevaContraseña.Location = new System.Drawing.Point(76, 150);
            this.lbl_NuevaContraseña.Name = "lbl_NuevaContraseña";
            this.lbl_NuevaContraseña.Size = new System.Drawing.Size(96, 13);
            this.lbl_NuevaContraseña.TabIndex = 2;
            this.lbl_NuevaContraseña.Tag = "lbl_NuevaContraseña";
            this.lbl_NuevaContraseña.Text = "Nueva Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 3;
            this.label1.Tag = "lbl_Confirmar_NuevaContraseña";
            this.label1.Text = "Confirmar Nueva Contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ContraseñaActual
            // 
            this.txt_ContraseñaActual.Location = new System.Drawing.Point(78, 105);
            this.txt_ContraseñaActual.Name = "txt_ContraseñaActual";
            this.txt_ContraseñaActual.PasswordChar = '*';
            this.txt_ContraseñaActual.Size = new System.Drawing.Size(156, 20);
            this.txt_ContraseñaActual.TabIndex = 5;
            // 
            // txt_NuevaContraseña
            // 
            this.txt_NuevaContraseña.Location = new System.Drawing.Point(79, 166);
            this.txt_NuevaContraseña.Name = "txt_NuevaContraseña";
            this.txt_NuevaContraseña.PasswordChar = '*';
            this.txt_NuevaContraseña.Size = new System.Drawing.Size(156, 20);
            this.txt_NuevaContraseña.TabIndex = 6;
            // 
            // txt_ConfirmarContraseñaNueva
            // 
            this.txt_ConfirmarContraseñaNueva.Location = new System.Drawing.Point(79, 229);
            this.txt_ConfirmarContraseñaNueva.Name = "txt_ConfirmarContraseñaNueva";
            this.txt_ConfirmarContraseñaNueva.PasswordChar = '*';
            this.txt_ConfirmarContraseñaNueva.Size = new System.Drawing.Size(156, 20);
            this.txt_ConfirmarContraseñaNueva.TabIndex = 7;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(47, 272);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(95, 30);
            this.btn_Aceptar.TabIndex = 8;
            this.btn_Aceptar.Tag = "btn_Aceptar";
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(174, 272);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(95, 30);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Tag = "btn_Cancelar";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_usuario_nombre
            // 
            this.lbl_usuario_nombre.AutoSize = true;
            this.lbl_usuario_nombre.Location = new System.Drawing.Point(76, 51);
            this.lbl_usuario_nombre.Name = "lbl_usuario_nombre";
            this.lbl_usuario_nombre.Size = new System.Drawing.Size(0, 13);
            this.lbl_usuario_nombre.TabIndex = 10;
            // 
            // Cambiar_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 346);
            this.Controls.Add(this.lbl_usuario_nombre);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_ConfirmarContraseñaNueva);
            this.Controls.Add(this.txt_NuevaContraseña);
            this.Controls.Add(this.txt_ContraseñaActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_NuevaContraseña);
            this.Controls.Add(this.lbl_ContraseñaActual);
            this.Controls.Add(this.lbl_Usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cambiar_Contraseña";
            this.Text = "Cambiar_Contraseña";
            this.Load += new System.EventHandler(this.Cambiar_Contraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_ContraseñaActual;
        private System.Windows.Forms.Label lbl_NuevaContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ContraseñaActual;
        private System.Windows.Forms.TextBox txt_NuevaContraseña;
        private System.Windows.Forms.TextBox txt_ConfirmarContraseñaNueva;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_usuario_nombre;
    }
}