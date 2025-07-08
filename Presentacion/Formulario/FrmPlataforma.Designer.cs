namespace Presentacion.Formulario
{
    partial class FrmPlataforma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlataforma));
            this.TxtCodigoPlataforma = new System.Windows.Forms.TextBox();
            this.TxtNombrePlataforma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkActivosPlataforma = new System.Windows.Forms.CheckBox();
            this.TxtBusquedaPlataforma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRegistrarPlataforma = new System.Windows.Forms.Button();
            this.BtnModificarPlataforma = new System.Windows.Forms.Button();
            this.BtnEliminarPlataforma = new System.Windows.Forms.Button();
            this.DgvPlataformas = new System.Windows.Forms.DataGridView();
            this.BtnLimpiarPlataforma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlataformas)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCodigoPlataforma
            // 
            this.TxtCodigoPlataforma.Location = new System.Drawing.Point(92, 78);
            this.TxtCodigoPlataforma.Name = "TxtCodigoPlataforma";
            this.TxtCodigoPlataforma.Size = new System.Drawing.Size(158, 22);
            this.TxtCodigoPlataforma.TabIndex = 0;
            // 
            // TxtNombrePlataforma
            // 
            this.TxtNombrePlataforma.Location = new System.Drawing.Point(454, 78);
            this.TxtNombrePlataforma.Name = "TxtNombrePlataforma";
            this.TxtNombrePlataforma.Size = new System.Drawing.Size(158, 22);
            this.TxtNombrePlataforma.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // ChkActivosPlataforma
            // 
            this.ChkActivosPlataforma.AutoSize = true;
            this.ChkActivosPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActivosPlataforma.Location = new System.Drawing.Point(476, 201);
            this.ChkActivosPlataforma.Name = "ChkActivosPlataforma";
            this.ChkActivosPlataforma.Size = new System.Drawing.Size(136, 20);
            this.ChkActivosPlataforma.TabIndex = 4;
            this.ChkActivosPlataforma.Text = "Mostrar Activos";
            this.ChkActivosPlataforma.UseVisualStyleBackColor = true;
            // 
            // TxtBusquedaPlataforma
            // 
            this.TxtBusquedaPlataforma.Location = new System.Drawing.Point(92, 195);
            this.TxtBusquedaPlataforma.Name = "TxtBusquedaPlataforma";
            this.TxtBusquedaPlataforma.Size = new System.Drawing.Size(203, 22);
            this.TxtBusquedaPlataforma.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar";
            // 
            // BtnRegistrarPlataforma
            // 
            this.BtnRegistrarPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarPlataforma.Location = new System.Drawing.Point(187, 137);
            this.BtnRegistrarPlataforma.Name = "BtnRegistrarPlataforma";
            this.BtnRegistrarPlataforma.Size = new System.Drawing.Size(92, 33);
            this.BtnRegistrarPlataforma.TabIndex = 7;
            this.BtnRegistrarPlataforma.Text = "Registrar";
            this.BtnRegistrarPlataforma.UseVisualStyleBackColor = true;
            // 
            // BtnModificarPlataforma
            // 
            this.BtnModificarPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarPlataforma.Location = new System.Drawing.Point(318, 137);
            this.BtnModificarPlataforma.Name = "BtnModificarPlataforma";
            this.BtnModificarPlataforma.Size = new System.Drawing.Size(92, 33);
            this.BtnModificarPlataforma.TabIndex = 8;
            this.BtnModificarPlataforma.Text = "Modificar";
            this.BtnModificarPlataforma.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarPlataforma
            // 
            this.BtnEliminarPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarPlataforma.Location = new System.Drawing.Point(461, 137);
            this.BtnEliminarPlataforma.Name = "BtnEliminarPlataforma";
            this.BtnEliminarPlataforma.Size = new System.Drawing.Size(84, 33);
            this.BtnEliminarPlataforma.TabIndex = 9;
            this.BtnEliminarPlataforma.Text = "Eliminar";
            this.BtnEliminarPlataforma.UseVisualStyleBackColor = true;
            // 
            // DgvPlataformas
            // 
            this.DgvPlataformas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPlataformas.Location = new System.Drawing.Point(24, 266);
            this.DgvPlataformas.Name = "DgvPlataformas";
            this.DgvPlataformas.RowHeadersWidth = 51;
            this.DgvPlataformas.RowTemplate.Height = 24;
            this.DgvPlataformas.Size = new System.Drawing.Size(588, 150);
            this.DgvPlataformas.TabIndex = 10;
            // 
            // BtnLimpiarPlataforma
            // 
            this.BtnLimpiarPlataforma.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiarPlataforma.Image")));
            this.BtnLimpiarPlataforma.Location = new System.Drawing.Point(295, 65);
            this.BtnLimpiarPlataforma.Name = "BtnLimpiarPlataforma";
            this.BtnLimpiarPlataforma.Size = new System.Drawing.Size(59, 54);
            this.BtnLimpiarPlataforma.TabIndex = 11;
            this.BtnLimpiarPlataforma.UseVisualStyleBackColor = true;
            // 
            // FrmPlataforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 439);
            this.Controls.Add(this.BtnLimpiarPlataforma);
            this.Controls.Add(this.DgvPlataformas);
            this.Controls.Add(this.BtnEliminarPlataforma);
            this.Controls.Add(this.BtnModificarPlataforma);
            this.Controls.Add(this.BtnRegistrarPlataforma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBusquedaPlataforma);
            this.Controls.Add(this.ChkActivosPlataforma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombrePlataforma);
            this.Controls.Add(this.TxtCodigoPlataforma);
            this.Name = "FrmPlataforma";
            this.Text = "Plataformas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlataformas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodigoPlataforma;
        private System.Windows.Forms.TextBox TxtNombrePlataforma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkActivosPlataforma;
        private System.Windows.Forms.TextBox TxtBusquedaPlataforma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRegistrarPlataforma;
        private System.Windows.Forms.Button BtnModificarPlataforma;
        private System.Windows.Forms.Button BtnEliminarPlataforma;
        private System.Windows.Forms.DataGridView DgvPlataformas;
        private System.Windows.Forms.Button BtnLimpiarPlataforma;
    }
}