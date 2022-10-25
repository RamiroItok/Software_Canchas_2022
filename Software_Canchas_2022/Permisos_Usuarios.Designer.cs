namespace Software_Canchas_2022
{
    partial class Permisos_Usuarios
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
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Familia = new System.Windows.Forms.Label();
            this.cmb_Usuario = new System.Windows.Forms.ComboBox();
            this.cmb_Familia = new System.Windows.Forms.ComboBox();
            this.cmb_Patente = new System.Windows.Forms.ComboBox();
            this.lbl_Patente = new System.Windows.Forms.Label();
            this.treePermisos = new System.Windows.Forms.TreeView();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Agregar1 = new System.Windows.Forms.Button();
            this.btn_Agregar2 = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(35, 28);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(57, 17);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Tag = "lbl_Usuario";
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Familia
            // 
            this.lbl_Familia.AutoSize = true;
            this.lbl_Familia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Familia.Location = new System.Drawing.Point(35, 115);
            this.lbl_Familia.Name = "lbl_Familia";
            this.lbl_Familia.Size = new System.Drawing.Size(52, 17);
            this.lbl_Familia.TabIndex = 1;
            this.lbl_Familia.Tag = "lbl_Familia";
            this.lbl_Familia.Text = "Familia";
            // 
            // cmb_Usuario
            // 
            this.cmb_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Usuario.FormattingEnabled = true;
            this.cmb_Usuario.Location = new System.Drawing.Point(38, 48);
            this.cmb_Usuario.Name = "cmb_Usuario";
            this.cmb_Usuario.Size = new System.Drawing.Size(170, 21);
            this.cmb_Usuario.TabIndex = 2;
            // 
            // cmb_Familia
            // 
            this.cmb_Familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Familia.FormattingEnabled = true;
            this.cmb_Familia.Location = new System.Drawing.Point(38, 135);
            this.cmb_Familia.Name = "cmb_Familia";
            this.cmb_Familia.Size = new System.Drawing.Size(170, 21);
            this.cmb_Familia.TabIndex = 3;
            // 
            // cmb_Patente
            // 
            this.cmb_Patente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Patente.FormattingEnabled = true;
            this.cmb_Patente.Location = new System.Drawing.Point(38, 221);
            this.cmb_Patente.Name = "cmb_Patente";
            this.cmb_Patente.Size = new System.Drawing.Size(170, 21);
            this.cmb_Patente.TabIndex = 5;
            // 
            // lbl_Patente
            // 
            this.lbl_Patente.AutoSize = true;
            this.lbl_Patente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patente.Location = new System.Drawing.Point(35, 201);
            this.lbl_Patente.Name = "lbl_Patente";
            this.lbl_Patente.Size = new System.Drawing.Size(57, 17);
            this.lbl_Patente.TabIndex = 4;
            this.lbl_Patente.Tag = "lbl_Patente";
            this.lbl_Patente.Text = "Patente";
            // 
            // treePermisos
            // 
            this.treePermisos.Location = new System.Drawing.Point(268, 21);
            this.treePermisos.Name = "treePermisos";
            this.treePermisos.Size = new System.Drawing.Size(486, 382);
            this.treePermisos.TabIndex = 6;
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(82, 75);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 7;
            this.btn_Mostrar.Tag = "btn_Mostrar";
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_Agregar1
            // 
            this.btn_Agregar1.Location = new System.Drawing.Point(82, 162);
            this.btn_Agregar1.Name = "btn_Agregar1";
            this.btn_Agregar1.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar1.TabIndex = 8;
            this.btn_Agregar1.Tag = "btn_Agregar";
            this.btn_Agregar1.Text = "Agregar";
            this.btn_Agregar1.UseVisualStyleBackColor = true;
            this.btn_Agregar1.Click += new System.EventHandler(this.btn_Agregar1_Click);
            // 
            // btn_Agregar2
            // 
            this.btn_Agregar2.Location = new System.Drawing.Point(82, 248);
            this.btn_Agregar2.Name = "btn_Agregar2";
            this.btn_Agregar2.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar2.TabIndex = 9;
            this.btn_Agregar2.Tag = "btn_Agregar";
            this.btn_Agregar2.Text = "Agregar";
            this.btn_Agregar2.UseVisualStyleBackColor = true;
            this.btn_Agregar2.Click += new System.EventHandler(this.btn_Agregar2_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(361, 419);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(109, 42);
            this.btn_Guardar.TabIndex = 10;
            this.btn_Guardar.Tag = "btn_Guardar";
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(514, 419);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(109, 42);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Tag = "btn_Cancelar";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Permisos_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 486);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Agregar2);
            this.Controls.Add(this.btn_Agregar1);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.treePermisos);
            this.Controls.Add(this.cmb_Patente);
            this.Controls.Add(this.lbl_Patente);
            this.Controls.Add(this.cmb_Familia);
            this.Controls.Add(this.cmb_Usuario);
            this.Controls.Add(this.lbl_Familia);
            this.Controls.Add(this.lbl_Usuario);
            this.Name = "Permisos_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Permisos_Usuarios";
            this.Text = "Permisos_Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Permisos_Usuarios_FormClosed);
            this.Load += new System.EventHandler(this.Permisos_Usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Familia;
        private System.Windows.Forms.ComboBox cmb_Usuario;
        private System.Windows.Forms.ComboBox cmb_Familia;
        private System.Windows.Forms.ComboBox cmb_Patente;
        private System.Windows.Forms.Label lbl_Patente;
        private System.Windows.Forms.TreeView treePermisos;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_Agregar1;
        private System.Windows.Forms.Button btn_Agregar2;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}