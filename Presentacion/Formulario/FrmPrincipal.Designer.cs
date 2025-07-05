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
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coleccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plataformasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.génerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuMantenimiento});
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
            this.coleccionesToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.plataformasToolStripMenuItem,
            this.génerosToolStripMenuItem});
            this.mnuMantenimiento.Name = "mnuMantenimiento";
            this.mnuMantenimiento.Size = new System.Drawing.Size(124, 24);
            this.mnuMantenimiento.Text = "Mantenimiento";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // coleccionesToolStripMenuItem
            // 
            this.coleccionesToolStripMenuItem.Name = "coleccionesToolStripMenuItem";
            this.coleccionesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.coleccionesToolStripMenuItem.Text = "Colecciones";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // plataformasToolStripMenuItem
            // 
            this.plataformasToolStripMenuItem.Name = "plataformasToolStripMenuItem";
            this.plataformasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.plataformasToolStripMenuItem.Text = "Plataformas";
            // 
            // génerosToolStripMenuItem
            // 
            this.génerosToolStripMenuItem.Name = "génerosToolStripMenuItem";
            this.génerosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.génerosToolStripMenuItem.Text = "Géneros";
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
        private System.Windows.Forms.ToolStripMenuItem coleccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plataformasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem génerosToolStripMenuItem;
    }
}