namespace Software_Canchas_2022
{
    partial class Usuarios_Bloqueados
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
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.btn_DesbloquearUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Location = new System.Drawing.Point(23, 21);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.Size = new System.Drawing.Size(450, 369);
            this.dataGridUsuarios.TabIndex = 0;
            // 
            // btn_DesbloquearUsuario
            // 
            this.btn_DesbloquearUsuario.Location = new System.Drawing.Point(137, 406);
            this.btn_DesbloquearUsuario.Name = "btn_DesbloquearUsuario";
            this.btn_DesbloquearUsuario.Size = new System.Drawing.Size(223, 45);
            this.btn_DesbloquearUsuario.TabIndex = 1;
            this.btn_DesbloquearUsuario.Tag = "btn_DesbloquearUsuario";
            this.btn_DesbloquearUsuario.Text = "Desbloquear Usuario";
            this.btn_DesbloquearUsuario.UseVisualStyleBackColor = true;
            this.btn_DesbloquearUsuario.Click += new System.EventHandler(this.btn_DesbloquearUsuario_Click);
            // 
            // Usuarios_Bloqueados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 471);
            this.Controls.Add(this.btn_DesbloquearUsuario);
            this.Controls.Add(this.dataGridUsuarios);
            this.Name = "Usuarios_Bloqueados";
            this.Tag = "Usuarios_Bloqueados";
            this.Text = "Usuarios_Bloqueados";
            this.Load += new System.EventHandler(this.Usuarios_Bloqueados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.Button btn_DesbloquearUsuario;
    }
}