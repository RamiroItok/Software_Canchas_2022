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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canchaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canchasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarEtiquetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEtiquetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recalcularDigitosVerificadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitácoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónFamiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bloqueadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaToolStripMenuItem,
            this.gestiónToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.seguridadToolStripMenuItem1,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canchaToolStripMenuItem,
            this.listadoToolStripMenuItem});
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reservaToolStripMenuItem.Tag = "menu_Cancha";
            this.reservaToolStripMenuItem.Text = "Cancha";
            // 
            // canchaToolStripMenuItem
            // 
            this.canchaToolStripMenuItem.Name = "canchaToolStripMenuItem";
            this.canchaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.canchaToolStripMenuItem.Tag = "menu_Reserva";
            this.canchaToolStripMenuItem.Text = "Reserva";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.listadoToolStripMenuItem.Tag = "menu_Listado";
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.canchasToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestiónToolStripMenuItem.Tag = "menu_Gestion";
            this.gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Tag = "menu_Gestion_Usuarios";
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // canchasToolStripMenuItem
            // 
            this.canchasToolStripMenuItem.Name = "canchasToolStripMenuItem";
            this.canchasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.canchasToolStripMenuItem.Tag = "menu_Gestion_Canchas";
            this.canchasToolStripMenuItem.Text = "Canchas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.clientesToolStripMenuItem.Tag = "menu_Gestion_Cliente";
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Tag = "menu_Informes";
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaIdiomaToolStripMenuItem,
            this.cargarEtiquetasToolStripMenuItem,
            this.modificarEtiquetasToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.seguridadToolStripMenuItem.Tag = "menu_Idioma";
            this.seguridadToolStripMenuItem.Text = "Idioma";
            // 
            // altaIdiomaToolStripMenuItem
            // 
            this.altaIdiomaToolStripMenuItem.Name = "altaIdiomaToolStripMenuItem";
            this.altaIdiomaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.altaIdiomaToolStripMenuItem.Tag = "menu_Alta_Idioma";
            this.altaIdiomaToolStripMenuItem.Text = "Alta idioma";
            // 
            // cargarEtiquetasToolStripMenuItem
            // 
            this.cargarEtiquetasToolStripMenuItem.Name = "cargarEtiquetasToolStripMenuItem";
            this.cargarEtiquetasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cargarEtiquetasToolStripMenuItem.Tag = "menu_Cargar_Etiquetas";
            this.cargarEtiquetasToolStripMenuItem.Text = "Cargar etiquetas";
            // 
            // modificarEtiquetasToolStripMenuItem
            // 
            this.modificarEtiquetasToolStripMenuItem.Name = "modificarEtiquetasToolStripMenuItem";
            this.modificarEtiquetasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.modificarEtiquetasToolStripMenuItem.Tag = "menu_Modificar_Etiquetas";
            this.modificarEtiquetasToolStripMenuItem.Text = "Modificar etiquetas";
            // 
            // seguridadToolStripMenuItem1
            // 
            this.seguridadToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recalcularDigitosVerificadoresToolStripMenuItem,
            this.bitácoraToolStripMenuItem,
            this.backUpToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.usuariosToolStripMenuItem1});
            this.seguridadToolStripMenuItem1.Name = "seguridadToolStripMenuItem1";
            this.seguridadToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem1.Tag = "menu_Seguridad";
            this.seguridadToolStripMenuItem1.Text = "Seguridad";
            // 
            // recalcularDigitosVerificadoresToolStripMenuItem
            // 
            this.recalcularDigitosVerificadoresToolStripMenuItem.Name = "recalcularDigitosVerificadoresToolStripMenuItem";
            this.recalcularDigitosVerificadoresToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.recalcularDigitosVerificadoresToolStripMenuItem.Tag = "menu_Recakular_DV";
            this.recalcularDigitosVerificadoresToolStripMenuItem.Text = "Recalcular digitos verificadores";
            // 
            // bitácoraToolStripMenuItem
            // 
            this.bitácoraToolStripMenuItem.Name = "bitácoraToolStripMenuItem";
            this.bitácoraToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.bitácoraToolStripMenuItem.Tag = "menu_Bitacora";
            this.bitácoraToolStripMenuItem.Text = "Bitácora";
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.backUpToolStripMenuItem.Tag = "menu_Backup";
            this.backUpToolStripMenuItem.Text = "Copia de seguridad";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.restoreToolStripMenuItem.Tag = "menu_Restore";
            this.restoreToolStripMenuItem.Text = "Restaurar";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónFamiliaToolStripMenuItem,
            this.asignarPermisosToolStripMenuItem,
            this.consultarPermisosToolStripMenuItem});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.rolesToolStripMenuItem.Tag = "menu_Roles";
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // gestiónFamiliaToolStripMenuItem
            // 
            this.gestiónFamiliaToolStripMenuItem.Name = "gestiónFamiliaToolStripMenuItem";
            this.gestiónFamiliaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.gestiónFamiliaToolStripMenuItem.Tag = "menu_Roles_Familia";
            this.gestiónFamiliaToolStripMenuItem.Text = "Gestión Familia";
            // 
            // asignarPermisosToolStripMenuItem
            // 
            this.asignarPermisosToolStripMenuItem.Name = "asignarPermisosToolStripMenuItem";
            this.asignarPermisosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.asignarPermisosToolStripMenuItem.Tag = "menu_Asignar_Permisos";
            this.asignarPermisosToolStripMenuItem.Text = "Asignar permisos";
            // 
            // consultarPermisosToolStripMenuItem
            // 
            this.consultarPermisosToolStripMenuItem.Name = "consultarPermisosToolStripMenuItem";
            this.consultarPermisosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.consultarPermisosToolStripMenuItem.Tag = "menu_Consultar_Permisos";
            this.consultarPermisosToolStripMenuItem.Text = "Consultar permisos";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloqueadosToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.usuariosToolStripMenuItem1.Tag = "menu_Seguridad_Usuarios";
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            // 
            // bloqueadosToolStripMenuItem
            // 
            this.bloqueadosToolStripMenuItem.Name = "bloqueadosToolStripMenuItem";
            this.bloqueadosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.bloqueadosToolStripMenuItem.Tag = "menu_Usuarios_Bloqueados";
            this.bloqueadosToolStripMenuItem.Text = "Bloqueados";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Tag = "menu_Cambiar_Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
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
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(1047, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(35, 13);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 536);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Tag = "menu_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canchaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canchasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarEtiquetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEtiquetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recalcularDigitosVerificadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitácoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónFamiliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bloqueadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.Label lblBienvenido;
    }
}