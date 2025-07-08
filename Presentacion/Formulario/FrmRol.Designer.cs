namespace Presentacion.Formulario
{
    partial class FrmRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRol));
            this.DgvRoles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigoRol = new System.Windows.Forms.TextBox();
            this.TxtNombreRol = new System.Windows.Forms.TextBox();
            this.TxtDescripcionRol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRegistrarRol = new System.Windows.Forms.Button();
            this.BtnModificarRol = new System.Windows.Forms.Button();
            this.BtnEliminarRol = new System.Windows.Forms.Button();
            this.TxtBusquedaRol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChkActivosRol = new System.Windows.Forms.CheckBox();
            this.BtnLimpiarRol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRoles
            // 
            this.DgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRoles.Location = new System.Drawing.Point(23, 278);
            this.DgvRoles.Name = "DgvRoles";
            this.DgvRoles.RowHeadersWidth = 51;
            this.DgvRoles.RowTemplate.Height = 24;
            this.DgvRoles.Size = new System.Drawing.Size(749, 142);
            this.DgvRoles.TabIndex = 0;
            this.DgvRoles.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DgvRoles_RowPrePaint);
            this.DgvRoles.SelectionChanged += new System.EventHandler(this.DgvRoles_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // TxtCodigoRol
            // 
            this.TxtCodigoRol.Location = new System.Drawing.Point(129, 72);
            this.TxtCodigoRol.Name = "TxtCodigoRol";
            this.TxtCodigoRol.Size = new System.Drawing.Size(150, 22);
            this.TxtCodigoRol.TabIndex = 4;
            // 
            // TxtNombreRol
            // 
            this.TxtNombreRol.Location = new System.Drawing.Point(129, 120);
            this.TxtNombreRol.Name = "TxtNombreRol";
            this.TxtNombreRol.Size = new System.Drawing.Size(150, 22);
            this.TxtNombreRol.TabIndex = 5;
            // 
            // TxtDescripcionRol
            // 
            this.TxtDescripcionRol.Location = new System.Drawing.Point(536, 66);
            this.TxtDescripcionRol.Name = "TxtDescripcionRol";
            this.TxtDescripcionRol.Size = new System.Drawing.Size(185, 22);
            this.TxtDescripcionRol.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripción";
            // 
            // BtnRegistrarRol
            // 
            this.BtnRegistrarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarRol.Location = new System.Drawing.Point(249, 156);
            this.BtnRegistrarRol.Name = "BtnRegistrarRol";
            this.BtnRegistrarRol.Size = new System.Drawing.Size(100, 43);
            this.BtnRegistrarRol.TabIndex = 9;
            this.BtnRegistrarRol.Text = "Registrar";
            this.BtnRegistrarRol.UseVisualStyleBackColor = true;
            this.BtnRegistrarRol.Click += new System.EventHandler(this.BtnRegistrarRol_Click);
            // 
            // BtnModificarRol
            // 
            this.BtnModificarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarRol.Location = new System.Drawing.Point(366, 156);
            this.BtnModificarRol.Name = "BtnModificarRol";
            this.BtnModificarRol.Size = new System.Drawing.Size(97, 43);
            this.BtnModificarRol.TabIndex = 10;
            this.BtnModificarRol.Text = "Modificar";
            this.BtnModificarRol.UseVisualStyleBackColor = true;
            this.BtnModificarRol.Click += new System.EventHandler(this.BtnModificarRol_Click);
            // 
            // BtnEliminarRol
            // 
            this.BtnEliminarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarRol.Location = new System.Drawing.Point(481, 156);
            this.BtnEliminarRol.Name = "BtnEliminarRol";
            this.BtnEliminarRol.Size = new System.Drawing.Size(99, 43);
            this.BtnEliminarRol.TabIndex = 11;
            this.BtnEliminarRol.Text = "Eliminar";
            this.BtnEliminarRol.UseVisualStyleBackColor = true;
            this.BtnEliminarRol.Click += new System.EventHandler(this.BtnEliminarRol_Click);
            // 
            // TxtBusquedaRol
            // 
            this.TxtBusquedaRol.Location = new System.Drawing.Point(148, 222);
            this.TxtBusquedaRol.Name = "TxtBusquedaRol";
            this.TxtBusquedaRol.Size = new System.Drawing.Size(211, 22);
            this.TxtBusquedaRol.TabIndex = 12;
            this.TxtBusquedaRol.TextChanged += new System.EventHandler(this.TxtBusquedaRol_TextChanged);
            this.TxtBusquedaRol.Enter += new System.EventHandler(this.TxtBusquedaRol_Enter);
            this.TxtBusquedaRol.Leave += new System.EventHandler(this.TxtBusquedaRol_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Buscar";
            // 
            // ChkActivosRol
            // 
            this.ChkActivosRol.AutoSize = true;
            this.ChkActivosRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActivosRol.Location = new System.Drawing.Point(506, 228);
            this.ChkActivosRol.Name = "ChkActivosRol";
            this.ChkActivosRol.Size = new System.Drawing.Size(169, 20);
            this.ChkActivosRol.TabIndex = 15;
            this.ChkActivosRol.Text = "Mostrar solo activos";
            this.ChkActivosRol.UseVisualStyleBackColor = true;
            this.ChkActivosRol.CheckedChanged += new System.EventHandler(this.ChkActivosRol_CheckedChanged);
            // 
            // BtnLimpiarRol
            // 
            this.BtnLimpiarRol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLimpiarRol.BackgroundImage")));
            this.BtnLimpiarRol.Location = new System.Drawing.Point(335, 73);
            this.BtnLimpiarRol.Name = "BtnLimpiarRol";
            this.BtnLimpiarRol.Size = new System.Drawing.Size(55, 56);
            this.BtnLimpiarRol.TabIndex = 16;
            this.BtnLimpiarRol.UseVisualStyleBackColor = true;
            this.BtnLimpiarRol.Click += new System.EventHandler(this.BtnLimpiarRol_Click);
            // 
            // FrmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLimpiarRol);
            this.Controls.Add(this.ChkActivosRol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBusquedaRol);
            this.Controls.Add(this.BtnEliminarRol);
            this.Controls.Add(this.BtnModificarRol);
            this.Controls.Add(this.BtnRegistrarRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDescripcionRol);
            this.Controls.Add(this.TxtNombreRol);
            this.Controls.Add(this.TxtCodigoRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvRoles);
            this.Name = "FrmRol";
            this.Text = "FrmRol";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigoRol;
        private System.Windows.Forms.TextBox TxtNombreRol;
        private System.Windows.Forms.TextBox TxtDescripcionRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRegistrarRol;
        private System.Windows.Forms.Button BtnModificarRol;
        private System.Windows.Forms.Button BtnEliminarRol;
        private System.Windows.Forms.TextBox TxtBusquedaRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChkActivosRol;
        private System.Windows.Forms.Button BtnLimpiarRol;
    }
}