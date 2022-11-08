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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlCliente));
            this.dataGridControl = new System.Windows.Forms.DataGridView();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Restaurar = new System.Windows.Forms.Button();
            this.cmb_Clientes = new System.Windows.Forms.ComboBox();
            this.lbl_Clientes = new System.Windows.Forms.Label();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridControl
            // 
            this.dataGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridControl.Location = new System.Drawing.Point(20, 103);
            this.dataGridControl.Name = "dataGridControl";
            this.dataGridControl.Size = new System.Drawing.Size(958, 412);
            this.dataGridControl.TabIndex = 0;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(880, 521);
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
            this.btn_Restaurar.Location = new System.Drawing.Point(762, 521);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(98, 32);
            this.btn_Restaurar.TabIndex = 2;
            this.btn_Restaurar.Tag = "btn_Restaurar";
            this.btn_Restaurar.Text = "Restaurar";
            this.btn_Restaurar.UseVisualStyleBackColor = true;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // cmb_Clientes
            // 
            this.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Clientes.FormattingEnabled = true;
            this.cmb_Clientes.Location = new System.Drawing.Point(30, 38);
            this.cmb_Clientes.Name = "cmb_Clientes";
            this.cmb_Clientes.Size = new System.Drawing.Size(153, 21);
            this.cmb_Clientes.TabIndex = 3;
            // 
            // lbl_Clientes
            // 
            this.lbl_Clientes.AutoSize = true;
            this.lbl_Clientes.Location = new System.Drawing.Point(27, 22);
            this.lbl_Clientes.Name = "lbl_Clientes";
            this.lbl_Clientes.Size = new System.Drawing.Size(44, 13);
            this.lbl_Clientes.TabIndex = 4;
            this.lbl_Clientes.Tag = "lbl_Clientes";
            this.lbl_Clientes.Text = "Clientes";
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(201, 36);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(88, 23);
            this.btn_Filtrar.TabIndex = 5;
            this.btn_Filtrar.Tag = "btn_Filtrar";
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(304, 36);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(88, 23);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Tag = "btn_Cancelar";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // ControlCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 571);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.lbl_Clientes);
            this.Controls.Add(this.cmb_Clientes);
            this.Controls.Add(this.btn_Restaurar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dataGridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Control_Cliente";
            this.Text = "ControlCliente";
            this.Load += new System.EventHandler(this.ControlCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridControl;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Restaurar;
        private System.Windows.Forms.ComboBox cmb_Clientes;
        private System.Windows.Forms.Label lbl_Clientes;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}