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
            this.cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_PagarDeuda = new System.Windows.Forms.Button();
            this.btn_Cancelar2 = new System.Windows.Forms.Button();
            this.lbl_IdReserva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeudas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDeudas
            // 
            this.dataGridDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeudas.Location = new System.Drawing.Point(12, 84);
            this.dataGridDeudas.Name = "dataGridDeudas";
            this.dataGridDeudas.Size = new System.Drawing.Size(780, 382);
            this.dataGridDeudas.TabIndex = 0;
            this.dataGridDeudas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDeudas_CellClick);
            // 
            // cmb_Cliente
            // 
            this.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cliente.FormattingEnabled = true;
            this.cmb_Cliente.Location = new System.Drawing.Point(17, 44);
            this.cmb_Cliente.Name = "cmb_Cliente";
            this.cmb_Cliente.Size = new System.Drawing.Size(222, 21);
            this.cmb_Cliente.TabIndex = 1;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cliente.Location = new System.Drawing.Point(16, 13);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(53, 18);
            this.lbl_Cliente.TabIndex = 2;
            this.lbl_Cliente.Tag = "lbl_Cliente";
            this.lbl_Cliente.Text = "Cliente";
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(264, 13);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(108, 23);
            this.btn_Filtrar.TabIndex = 3;
            this.btn_Filtrar.Tag = "btn_Filtrar";
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(264, 42);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(108, 23);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Tag = "btn_Cancelar";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_PagarDeuda
            // 
            this.btn_PagarDeuda.Location = new System.Drawing.Point(254, 484);
            this.btn_PagarDeuda.Name = "btn_PagarDeuda";
            this.btn_PagarDeuda.Size = new System.Drawing.Size(108, 23);
            this.btn_PagarDeuda.TabIndex = 5;
            this.btn_PagarDeuda.Tag = "btn_PagarDeuda";
            this.btn_PagarDeuda.Text = "Pagar deuda";
            this.btn_PagarDeuda.UseVisualStyleBackColor = true;
            this.btn_PagarDeuda.Click += new System.EventHandler(this.btn_PagarDeuda_Click);
            // 
            // btn_Cancelar2
            // 
            this.btn_Cancelar2.Location = new System.Drawing.Point(393, 484);
            this.btn_Cancelar2.Name = "btn_Cancelar2";
            this.btn_Cancelar2.Size = new System.Drawing.Size(108, 23);
            this.btn_Cancelar2.TabIndex = 6;
            this.btn_Cancelar2.Tag = "btn_Cancelar";
            this.btn_Cancelar2.Text = "Cancelar";
            this.btn_Cancelar2.UseVisualStyleBackColor = true;
            this.btn_Cancelar2.Click += new System.EventHandler(this.btn_Cancelar2_Click);
            // 
            // lbl_IdReserva
            // 
            this.lbl_IdReserva.AutoSize = true;
            this.lbl_IdReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdReserva.Location = new System.Drawing.Point(498, 42);
            this.lbl_IdReserva.Name = "lbl_IdReserva";
            this.lbl_IdReserva.Size = new System.Drawing.Size(0, 18);
            this.lbl_IdReserva.TabIndex = 7;
            this.lbl_IdReserva.Tag = "";
            // 
            // GestionDeudas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 522);
            this.Controls.Add(this.lbl_IdReserva);
            this.Controls.Add(this.btn_Cancelar2);
            this.Controls.Add(this.btn_PagarDeuda);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.cmb_Cliente);
            this.Controls.Add(this.dataGridDeudas);
            this.Name = "GestionDeudas";
            this.Tag = "Gestion_Deudas";
            this.Text = "GestionDeudas";
            this.Load += new System.EventHandler(this.GestionDeudas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeudas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDeudas;
        private System.Windows.Forms.ComboBox cmb_Cliente;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_PagarDeuda;
        private System.Windows.Forms.Button btn_Cancelar2;
        private System.Windows.Forms.Label lbl_IdReserva;
    }
}