namespace Presentacion
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chkUsuarios = new System.Windows.Forms.CheckBox();
            this.TxtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.CbRolUsuario = new System.Windows.Forms.ComboBox();
            this.TxtEmailUsuario = new System.Windows.Forms.TextBox();
            this.TxtBuscarNombreUsuario = new System.Windows.Forms.TextBox();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnLimpiarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(118, 167);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(133, 42);
            this.btnRegistrarUsuario.TabIndex = 4;
            this.btnRegistrarUsuario.Text = "Registrar";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarUsuario.Location = new System.Drawing.Point(307, 167);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(133, 42);
            this.btnModificarUsuario.TabIndex = 5;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(488, 167);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(133, 42);
            this.btnEliminarUsuario.TabIndex = 6;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Buscar";
            // 
            // chkUsuarios
            // 
            this.chkUsuarios.AutoSize = true;
            this.chkUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsuarios.Location = new System.Drawing.Point(449, 268);
            this.chkUsuarios.Name = "chkUsuarios";
            this.chkUsuarios.Size = new System.Drawing.Size(203, 24);
            this.chkUsuarios.TabIndex = 9;
            this.chkUsuarios.Text = "Mostrar solo activos";
            this.chkUsuarios.UseVisualStyleBackColor = true;
            this.chkUsuarios.CheckedChanged += new System.EventHandler(this.chkUsuarios_CheckedChanged);
            // 
            // TxtCodigoUsuario
            // 
            this.TxtCodigoUsuario.Location = new System.Drawing.Point(123, 39);
            this.TxtCodigoUsuario.Name = "TxtCodigoUsuario";
            this.TxtCodigoUsuario.Size = new System.Drawing.Size(143, 22);
            this.TxtCodigoUsuario.TabIndex = 10;
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(123, 104);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(240, 22);
            this.TxtNombreUsuario.TabIndex = 11;
            // 
            // CbRolUsuario
            // 
            this.CbRolUsuario.FormattingEnabled = true;
            this.CbRolUsuario.Location = new System.Drawing.Point(518, 33);
            this.CbRolUsuario.Name = "CbRolUsuario";
            this.CbRolUsuario.Size = new System.Drawing.Size(170, 24);
            this.CbRolUsuario.TabIndex = 12;
            // 
            // TxtEmailUsuario
            // 
            this.TxtEmailUsuario.Location = new System.Drawing.Point(518, 100);
            this.TxtEmailUsuario.Name = "TxtEmailUsuario";
            this.TxtEmailUsuario.Size = new System.Drawing.Size(205, 22);
            this.TxtEmailUsuario.TabIndex = 13;
            // 
            // TxtBuscarNombreUsuario
            // 
            this.TxtBuscarNombreUsuario.Location = new System.Drawing.Point(123, 265);
            this.TxtBuscarNombreUsuario.Name = "TxtBuscarNombreUsuario";
            this.TxtBuscarNombreUsuario.Size = new System.Drawing.Size(210, 22);
            this.TxtBuscarNombreUsuario.TabIndex = 14;
            this.TxtBuscarNombreUsuario.TextChanged += new System.EventHandler(this.TxtBuscarNombreUsuario_TextChanged);
            this.TxtBuscarNombreUsuario.Enter += new System.EventHandler(this.TxtBuscarNombreUsuario_Enter);
            this.TxtBuscarNombreUsuario.Leave += new System.EventHandler(this.TxtBuscarNombreUsuario_Leave);
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(33, 298);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.RowHeadersWidth = 51;
            this.DgvUsuarios.RowTemplate.Height = 24;
            this.DgvUsuarios.Size = new System.Drawing.Size(690, 195);
            this.DgvUsuarios.TabIndex = 15;
            this.DgvUsuarios.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvUsuarios_DataError);
            this.DgvUsuarios.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DgvUsuarios_RowPrePaint);
            this.DgvUsuarios.SelectionChanged += new System.EventHandler(this.DgvUsuarios_SelectionChanged);
            // 
            // BtnLimpiarUsuario
            // 
            this.BtnLimpiarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiarUsuario.Image")));
            this.BtnLimpiarUsuario.Location = new System.Drawing.Point(341, 39);
            this.BtnLimpiarUsuario.Name = "BtnLimpiarUsuario";
            this.BtnLimpiarUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnLimpiarUsuario.Size = new System.Drawing.Size(49, 44);
            this.BtnLimpiarUsuario.TabIndex = 16;
            this.BtnLimpiarUsuario.UseVisualStyleBackColor = true;
            this.BtnLimpiarUsuario.Click += new System.EventHandler(this.BtnLimpiarUsuario_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 521);
            this.Controls.Add(this.BtnLimpiarUsuario);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.TxtBuscarNombreUsuario);
            this.Controls.Add(this.TxtEmailUsuario);
            this.Controls.Add(this.CbRolUsuario);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.TxtCodigoUsuario);
            this.Controls.Add(this.chkUsuarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuario";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkUsuarios;
        private System.Windows.Forms.TextBox TxtCodigoUsuario;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.ComboBox CbRolUsuario;
        private System.Windows.Forms.TextBox TxtEmailUsuario;
        private System.Windows.Forms.TextBox TxtBuscarNombreUsuario;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button BtnLimpiarUsuario;
    }
}