namespace Presentacion.Formulario
{
    partial class FrmPrincipal
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
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblRol = new System.Windows.Forms.Label();
            this.MnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plataformasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.génerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BibliotecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misColeccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intercambiosPréstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misColeccionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.misItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.LblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblUsuario.Location = new System.Drawing.Point(1114, 542);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(2, 18);
            this.LblUsuario.TabIndex = 0;
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.BackColor = System.Drawing.Color.IndianRed;
            this.LblRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRol.Location = new System.Drawing.Point(1114, 577);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(2, 18);
            this.LblRol.TabIndex = 1;
            // 
            // MnsPrincipal
            // 
            this.MnsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMantenimiento,
            this.BibliotecaToolStripMenuItem,
            this.misColeccionesToolStripMenuItem,
            this.intercambiosPréstToolStripMenuItem,
            this.auditoríaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.MnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnsPrincipal.Name = "MnsPrincipal";
            this.MnsPrincipal.Size = new System.Drawing.Size(1293, 28);
            this.MnsPrincipal.TabIndex = 8;
            this.MnsPrincipal.Text = "menuStrip1";
            // 
            // mnuMantenimiento
            // 
            this.mnuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.plataformasToolStripMenuItem,
            this.génerosToolStripMenuItem});
            this.mnuMantenimiento.Name = "mnuMantenimiento";
            this.mnuMantenimiento.Size = new System.Drawing.Size(124, 24);
            this.mnuMantenimiento.Text = "Mantenimiento";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // plataformasToolStripMenuItem
            // 
            this.plataformasToolStripMenuItem.Name = "plataformasToolStripMenuItem";
            this.plataformasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.plataformasToolStripMenuItem.Text = "Plataformas";
            this.plataformasToolStripMenuItem.Click += new System.EventHandler(this.plataformasToolStripMenuItem_Click);
            // 
            // génerosToolStripMenuItem
            // 
            this.génerosToolStripMenuItem.Name = "génerosToolStripMenuItem";
            this.génerosToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.génerosToolStripMenuItem.Text = "Géneros";
            // 
            // BibliotecaToolStripMenuItem
            // 
            this.BibliotecaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misColeccionesToolStripMenuItem1,
            this.misItemsToolStripMenuItem});
            this.BibliotecaToolStripMenuItem.Name = "BibliotecaToolStripMenuItem";
            this.BibliotecaToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.BibliotecaToolStripMenuItem.Text = "Mi Biblioteca";
            this.BibliotecaToolStripMenuItem.Click += new System.EventHandler(this.BibliotecaToolStripMenuItem_Click);
            // 
            // misColeccionesToolStripMenuItem
            // 
            this.misColeccionesToolStripMenuItem.Name = "misColeccionesToolStripMenuItem";
            this.misColeccionesToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.misColeccionesToolStripMenuItem.Text = "Mis Colecciones";
            // 
            // intercambiosPréstToolStripMenuItem
            // 
            this.intercambiosPréstToolStripMenuItem.Name = "intercambiosPréstToolStripMenuItem";
            this.intercambiosPréstToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.intercambiosPréstToolStripMenuItem.Text = "Intercambios / Préstamos";
            // 
            // auditoríaToolStripMenuItem
            // 
            this.auditoríaToolStripMenuItem.Name = "auditoríaToolStripMenuItem";
            this.auditoríaToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.auditoríaToolStripMenuItem.Text = "Auditoría";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // misColeccionesToolStripMenuItem1
            // 
            this.misColeccionesToolStripMenuItem1.Name = "misColeccionesToolStripMenuItem1";
            this.misColeccionesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.misColeccionesToolStripMenuItem1.Text = "Mis Colecciones";
            this.misColeccionesToolStripMenuItem1.Click += new System.EventHandler(this.misColeccionesToolStripMenuItem1_Click);
            // 
            // misItemsToolStripMenuItem
            // 
            this.misItemsToolStripMenuItem.Name = "misItemsToolStripMenuItem";
            this.misItemsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.misItemsToolStripMenuItem.Text = "Mis Items";
            this.misItemsToolStripMenuItem.Click += new System.EventHandler(this.misItemsToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 613);
            this.Controls.Add(this.LblRol);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.MnsPrincipal);
            this.MainMenuStrip = this.MnsPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.MnsPrincipal.ResumeLayout(false);
            this.MnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblRol;
        private System.Windows.Forms.MenuStrip MnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plataformasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem génerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BibliotecaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misColeccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intercambiosPréstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misColeccionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem misItemsToolStripMenuItem;
    }
}