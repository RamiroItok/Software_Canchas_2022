namespace Software_Canchas_2022
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.canchaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCanchasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaIdiomaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarEtiquetasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitácoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónFamiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionFamiliasYPatentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosAUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloqueadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeCambiosDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canchaToolStripMenuItem,
            this.gestiónToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.idiomaToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // canchaToolStripMenuItem
            // 
            this.canchaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaToolStripMenuItem});
            this.canchaToolStripMenuItem.Name = "canchaToolStripMenuItem";
            this.canchaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.canchaToolStripMenuItem.Tag = "menu_Cancha";
            this.canchaToolStripMenuItem.Text = "Cancha";
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.reservaToolStripMenuItem.Tag = "menu_Reserva";
            this.reservaToolStripMenuItem.Text = "Reserva";
            this.reservaToolStripMenuItem.Click += new System.EventHandler(this.reservaToolStripMenuItem_Click);
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionUsuariosToolStripMenuItem,
            this.gestionCanchasToolStripMenuItem,
            this.gestionClientesToolStripMenuItem,
            this.deudasToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestiónToolStripMenuItem.Tag = "menu_Gestion";
            this.gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // gestionUsuariosToolStripMenuItem
            // 
            this.gestionUsuariosToolStripMenuItem.Name = "gestionUsuariosToolStripMenuItem";
            this.gestionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestionUsuariosToolStripMenuItem.Tag = "menu_Gestion_Usuarios";
            this.gestionUsuariosToolStripMenuItem.Text = "Usuarios";
            this.gestionUsuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // gestionCanchasToolStripMenuItem
            // 
            this.gestionCanchasToolStripMenuItem.Name = "gestionCanchasToolStripMenuItem";
            this.gestionCanchasToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestionCanchasToolStripMenuItem.Tag = "menu_Gestion_Canchas";
            this.gestionCanchasToolStripMenuItem.Text = "Canchas";
            this.gestionCanchasToolStripMenuItem.Click += new System.EventHandler(this.gestionCanchasToolStripMenuItem_Click);
            // 
            // gestionClientesToolStripMenuItem
            // 
            this.gestionClientesToolStripMenuItem.Name = "gestionClientesToolStripMenuItem";
            this.gestionClientesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestionClientesToolStripMenuItem.Tag = "menu_Gestion_Clientes";
            this.gestionClientesToolStripMenuItem.Text = "Clientes";
            this.gestionClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionClientesToolStripMenuItem_Click);
            // 
            // deudasToolStripMenuItem
            // 
            this.deudasToolStripMenuItem.Name = "deudasToolStripMenuItem";
            this.deudasToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deudasToolStripMenuItem.Tag = "menu_Deudas_Pendientes";
            this.deudasToolStripMenuItem.Text = "Deudas Pendientes";
            this.deudasToolStripMenuItem.Click += new System.EventHandler(this.deudasToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Tag = "menu_Informes";
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionIdiomaToolStripMenuItem});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.idiomaToolStripMenuItem.Tag = "menu_Idioma";
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // gestionIdiomaToolStripMenuItem
            // 
            this.gestionIdiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaIdiomaToolStripMenuItem1,
            this.cargarEtiquetasToolStripMenuItem1});
            this.gestionIdiomaToolStripMenuItem.Name = "gestionIdiomaToolStripMenuItem";
            this.gestionIdiomaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.gestionIdiomaToolStripMenuItem.Tag = "menu_Gestion_Idioma";
            this.gestionIdiomaToolStripMenuItem.Text = "Gestion idioma";
            // 
            // altaIdiomaToolStripMenuItem1
            // 
            this.altaIdiomaToolStripMenuItem1.Name = "altaIdiomaToolStripMenuItem1";
            this.altaIdiomaToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.altaIdiomaToolStripMenuItem1.Tag = "menu_AltaIdioma";
            this.altaIdiomaToolStripMenuItem1.Text = "Alta idioma";
            this.altaIdiomaToolStripMenuItem1.Click += new System.EventHandler(this.altaIdiomaToolStripMenuItem1_Click);
            // 
            // cargarEtiquetasToolStripMenuItem1
            // 
            this.cargarEtiquetasToolStripMenuItem1.Name = "cargarEtiquetasToolStripMenuItem1";
            this.cargarEtiquetasToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.cargarEtiquetasToolStripMenuItem1.Tag = "menu_CargarEtiquetas";
            this.cargarEtiquetasToolStripMenuItem1.Text = "Cargar etiquetas";
            this.cargarEtiquetasToolStripMenuItem1.Click += new System.EventHandler(this.cargarEtiquetasToolStripMenuItem1_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitácoraToolStripMenuItem,
            this.backUpToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.seguridadUsuariosToolStripMenuItem,
            this.controlDeCambiosDeClienteToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Tag = "menu_Seguridad";
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // bitácoraToolStripMenuItem
            // 
            this.bitácoraToolStripMenuItem.Name = "bitácoraToolStripMenuItem";
            this.bitácoraToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.bitácoraToolStripMenuItem.Tag = "menu_Bitacora";
            this.bitácoraToolStripMenuItem.Text = "Bitácora";
            this.bitácoraToolStripMenuItem.Click += new System.EventHandler(this.bitácoraToolStripMenuItem_Click);
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.backUpToolStripMenuItem.Tag = "menu_Backup";
            this.backUpToolStripMenuItem.Text = "Copia de seguridad";
            this.backUpToolStripMenuItem.Click += new System.EventHandler(this.backUpToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.restoreToolStripMenuItem.Tag = "menu_Restore";
            this.restoreToolStripMenuItem.Text = "Restaurar";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónFamiliaToolStripMenuItem,
            this.asignarPermisosToolStripMenuItem});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.rolesToolStripMenuItem.Tag = "menu_Roles";
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // gestiónFamiliaToolStripMenuItem
            // 
            this.gestiónFamiliaToolStripMenuItem.Name = "gestiónFamiliaToolStripMenuItem";
            this.gestiónFamiliaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.gestiónFamiliaToolStripMenuItem.Tag = "menu_Roles_Familia";
            this.gestiónFamiliaToolStripMenuItem.Text = "Gestión Familia";
            this.gestiónFamiliaToolStripMenuItem.Click += new System.EventHandler(this.gestiónFamiliaToolStripMenuItem_Click);
            // 
            // asignarPermisosToolStripMenuItem
            // 
            this.asignarPermisosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionFamiliasYPatentesToolStripMenuItem,
            this.permisosAUsuariosToolStripMenuItem});
            this.asignarPermisosToolStripMenuItem.Name = "asignarPermisosToolStripMenuItem";
            this.asignarPermisosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.asignarPermisosToolStripMenuItem.Tag = "menu_Asignar_Permisos";
            this.asignarPermisosToolStripMenuItem.Text = "Asignar permisos";
            // 
            // gestionFamiliasYPatentesToolStripMenuItem
            // 
            this.gestionFamiliasYPatentesToolStripMenuItem.Name = "gestionFamiliasYPatentesToolStripMenuItem";
            this.gestionFamiliasYPatentesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.gestionFamiliasYPatentesToolStripMenuItem.Text = "Gestion familias y patentes";
            this.gestionFamiliasYPatentesToolStripMenuItem.Click += new System.EventHandler(this.gestionFamiliasYPatentesToolStripMenuItem_Click);
            // 
            // permisosAUsuariosToolStripMenuItem
            // 
            this.permisosAUsuariosToolStripMenuItem.Name = "permisosAUsuariosToolStripMenuItem";
            this.permisosAUsuariosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.permisosAUsuariosToolStripMenuItem.Text = "Permisos a usuarios";
            this.permisosAUsuariosToolStripMenuItem.Click += new System.EventHandler(this.permisosAUsuariosToolStripMenuItem_Click);
            // 
            // seguridadUsuariosToolStripMenuItem
            // 
            this.seguridadUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloqueadosToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
            this.seguridadUsuariosToolStripMenuItem.Name = "seguridadUsuariosToolStripMenuItem";
            this.seguridadUsuariosToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.seguridadUsuariosToolStripMenuItem.Tag = "menu_Seguridad_Usuarios";
            this.seguridadUsuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // bloqueadosToolStripMenuItem
            // 
            this.bloqueadosToolStripMenuItem.Name = "bloqueadosToolStripMenuItem";
            this.bloqueadosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.bloqueadosToolStripMenuItem.Tag = "menu_Usuarios_Bloqueados";
            this.bloqueadosToolStripMenuItem.Text = "Bloqueados";
            this.bloqueadosToolStripMenuItem.Click += new System.EventHandler(this.bloqueadosToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Tag = "menu_Cambiar_Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // controlDeCambiosDeClienteToolStripMenuItem
            // 
            this.controlDeCambiosDeClienteToolStripMenuItem.Name = "controlDeCambiosDeClienteToolStripMenuItem";
            this.controlDeCambiosDeClienteToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.controlDeCambiosDeClienteToolStripMenuItem.Tag = "menu_Control_Cliente";
            this.controlDeCambiosDeClienteToolStripMenuItem.Text = "Control de cambios de Clientes";
            this.controlDeCambiosDeClienteToolStripMenuItem.Click += new System.EventHandler(this.controlDeCambiosDeReservaToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiónToolStripMenuItem.Tag = "menu_Cerrar_Sesion";
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Tag = "menu_Salir";
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 794);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "menu_Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MdiChildActivate += new System.EventHandler(this.Menu_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem canchaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCanchasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitácoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónFamiliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloqueadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaIdiomaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargarEtiquetasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem controlDeCambiosDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionFamiliasYPatentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosAUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deudasToolStripMenuItem;
    }
}