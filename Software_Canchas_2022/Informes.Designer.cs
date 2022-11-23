using System;

namespace Software_Canchas_2022
{
    partial class Informes
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
            this.reporteCanchaMasReservada = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteHorarioMasReservadoDelMes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporteCanchaMasReservada
            // 
            this.reporteCanchaMasReservada.LocalReport.ReportEmbeddedResource = "Software_Canchas_2022.ReporteCanchaMasReservadaDelMes.rdlc";
            this.reporteCanchaMasReservada.Location = new System.Drawing.Point(1, -1);
            this.reporteCanchaMasReservada.Name = "reporteCanchaMasReservada";
            this.reporteCanchaMasReservada.ServerReport.BearerToken = null;
            this.reporteCanchaMasReservada.Size = new System.Drawing.Size(549, 362);
            this.reporteCanchaMasReservada.TabIndex = 0;
            // 
            // reporteHorarioMasReservadoDelMes
            // 
            this.reporteHorarioMasReservadoDelMes.Location = new System.Drawing.Point(550, -1);
            this.reporteHorarioMasReservadoDelMes.Name = "reporteHorarioMasReservadoDelMes";
            this.reporteHorarioMasReservadoDelMes.ServerReport.BearerToken = null;
            this.reporteHorarioMasReservadoDelMes.Size = new System.Drawing.Size(549, 362);
            this.reporteHorarioMasReservadoDelMes.TabIndex = 1;
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 623);
            this.Controls.Add(this.reporteHorarioMasReservadoDelMes);
            this.Controls.Add(this.reporteCanchaMasReservada);
            this.Name = "Informes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.Informes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteCanchaMasReservada;
        private Microsoft.Reporting.WinForms.ReportViewer reporteHorarioMasReservadoDelMes;
    }
}