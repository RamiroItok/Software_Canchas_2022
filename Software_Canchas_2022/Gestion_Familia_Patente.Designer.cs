namespace Software_Canchas_2022
{
    partial class Gestion_Familia_Patente
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
            this.lbl_Familias = new System.Windows.Forms.Label();
            this.lbl_Patentes = new System.Windows.Forms.Label();
            this.lbl_AgregarFamiliaFamilia = new System.Windows.Forms.Label();
            this.cmb_Familia1 = new System.Windows.Forms.ComboBox();
            this.cmb_Patentes = new System.Windows.Forms.ComboBox();
            this.cmb_Familia2 = new System.Windows.Forms.ComboBox();
            this.treePatenteFamilia = new System.Windows.Forms.TreeView();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_EliminarPatente = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.btn_AgregarPatente = new System.Windows.Forms.Button();
            this.btn_AgregarFamilia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Familias
            // 
            this.lbl_Familias.AutoSize = true;
            this.lbl_Familias.Location = new System.Drawing.Point(51, 34);
            this.lbl_Familias.Name = "lbl_Familias";
            this.lbl_Familias.Size = new System.Drawing.Size(44, 13);
            this.lbl_Familias.TabIndex = 0;
            this.lbl_Familias.Tag = "lbl_Familias";
            this.lbl_Familias.Text = "Familias";
            // 
            // lbl_Patentes
            // 
            this.lbl_Patentes.AutoSize = true;
            this.lbl_Patentes.Location = new System.Drawing.Point(51, 132);
            this.lbl_Patentes.Name = "lbl_Patentes";
            this.lbl_Patentes.Size = new System.Drawing.Size(49, 13);
            this.lbl_Patentes.TabIndex = 1;
            this.lbl_Patentes.Tag = "lbl_Patentes";
            this.lbl_Patentes.Text = "Patentes";
            // 
            // lbl_AgregarFamiliaFamilia
            // 
            this.lbl_AgregarFamiliaFamilia.AutoSize = true;
            this.lbl_AgregarFamiliaFamilia.Location = new System.Drawing.Point(51, 230);
            this.lbl_AgregarFamiliaFamilia.Name = "lbl_AgregarFamiliaFamilia";
            this.lbl_AgregarFamiliaFamilia.Size = new System.Drawing.Size(123, 13);
            this.lbl_AgregarFamiliaFamilia.TabIndex = 2;
            this.lbl_AgregarFamiliaFamilia.Tag = "lbl_AgregarFamiliaFamilia";
            this.lbl_AgregarFamiliaFamilia.Text = "Agregar Familia a Familia";
            // 
            // cmb_Familia1
            // 
            this.cmb_Familia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Familia1.FormattingEnabled = true;
            this.cmb_Familia1.Location = new System.Drawing.Point(54, 50);
            this.cmb_Familia1.Name = "cmb_Familia1";
            this.cmb_Familia1.Size = new System.Drawing.Size(164, 21);
            this.cmb_Familia1.TabIndex = 3;
            // 
            // cmb_Patentes
            // 
            this.cmb_Patentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Patentes.FormattingEnabled = true;
            this.cmb_Patentes.Location = new System.Drawing.Point(54, 148);
            this.cmb_Patentes.Name = "cmb_Patentes";
            this.cmb_Patentes.Size = new System.Drawing.Size(164, 21);
            this.cmb_Patentes.TabIndex = 4;
            // 
            // cmb_Familia2
            // 
            this.cmb_Familia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Familia2.FormattingEnabled = true;
            this.cmb_Familia2.Location = new System.Drawing.Point(54, 246);
            this.cmb_Familia2.Name = "cmb_Familia2";
            this.cmb_Familia2.Size = new System.Drawing.Size(164, 21);
            this.cmb_Familia2.TabIndex = 5;
            // 
            // treePatenteFamilia
            // 
            this.treePatenteFamilia.Location = new System.Drawing.Point(308, 34);
            this.treePatenteFamilia.Name = "treePatenteFamilia";
            this.treePatenteFamilia.Size = new System.Drawing.Size(347, 345);
            this.treePatenteFamilia.TabIndex = 6;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(445, 396);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(91, 42);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Tag = "btn_Guardar";
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_EliminarPatente
            // 
            this.btn_EliminarPatente.Location = new System.Drawing.Point(332, 396);
            this.btn_EliminarPatente.Name = "btn_EliminarPatente";
            this.btn_EliminarPatente.Size = new System.Drawing.Size(91, 42);
            this.btn_EliminarPatente.TabIndex = 8;
            this.btn_EliminarPatente.Tag = "btn_EliminarPatente";
            this.btn_EliminarPatente.Text = "Eliminar Patente";
            this.btn_EliminarPatente.UseVisualStyleBackColor = true;
            this.btn_EliminarPatente.Click += new System.EventHandler(this.btn_EliminarPatente_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(564, 396);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(91, 42);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Tag = "btn_Cancelar";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(82, 77);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(102, 23);
            this.btn_Listar.TabIndex = 10;
            this.btn_Listar.Tag = "btn_Listar";
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // btn_AgregarPatente
            // 
            this.btn_AgregarPatente.Location = new System.Drawing.Point(82, 175);
            this.btn_AgregarPatente.Name = "btn_AgregarPatente";
            this.btn_AgregarPatente.Size = new System.Drawing.Size(102, 23);
            this.btn_AgregarPatente.TabIndex = 11;
            this.btn_AgregarPatente.Tag = "btn_AgregarPatente";
            this.btn_AgregarPatente.Text = "Agregar Patente";
            this.btn_AgregarPatente.UseVisualStyleBackColor = true;
            this.btn_AgregarPatente.Click += new System.EventHandler(this.btn_AgregarPatente_Click);
            // 
            // btn_AgregarFamilia
            // 
            this.btn_AgregarFamilia.Location = new System.Drawing.Point(82, 273);
            this.btn_AgregarFamilia.Name = "btn_AgregarFamilia";
            this.btn_AgregarFamilia.Size = new System.Drawing.Size(102, 23);
            this.btn_AgregarFamilia.TabIndex = 12;
            this.btn_AgregarFamilia.Tag = "btn_AgregarFamilia";
            this.btn_AgregarFamilia.Text = "Agregar Familia";
            this.btn_AgregarFamilia.UseVisualStyleBackColor = true;
            this.btn_AgregarFamilia.Click += new System.EventHandler(this.btn_AgregarFamilia_Click);
            // 
            // Gestion_Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.btn_AgregarFamilia);
            this.Controls.Add(this.btn_AgregarPatente);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_EliminarPatente);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.treePatenteFamilia);
            this.Controls.Add(this.cmb_Familia2);
            this.Controls.Add(this.cmb_Patentes);
            this.Controls.Add(this.cmb_Familia1);
            this.Controls.Add(this.lbl_AgregarFamiliaFamilia);
            this.Controls.Add(this.lbl_Patentes);
            this.Controls.Add(this.lbl_Familias);
            this.Name = "Gestion_Permisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "gestion_Permisos";
            this.Text = "Gestion_Permisos";
            this.Load += new System.EventHandler(this.Gestion_Permisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Familias;
        private System.Windows.Forms.Label lbl_Patentes;
        private System.Windows.Forms.Label lbl_AgregarFamiliaFamilia;
        private System.Windows.Forms.ComboBox cmb_Familia1;
        private System.Windows.Forms.ComboBox cmb_Patentes;
        private System.Windows.Forms.ComboBox cmb_Familia2;
        private System.Windows.Forms.TreeView treePatenteFamilia;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_EliminarPatente;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.Button btn_AgregarPatente;
        private System.Windows.Forms.Button btn_AgregarFamilia;
    }
}