namespace Presentacion.Formulario
{
    partial class FrmColeccion
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;

        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDescripcion;

        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;

        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox ChkActivos;
        private System.Windows.Forms.DataGridView DgvColecciones;

        private void InitializeComponent()
        {
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.ChkActivos = new System.Windows.Forms.CheckBox();
            this.DgvColecciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvColecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.Location = new System.Drawing.Point(17, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(291, 37);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Gestión de Colecciones";
            // 
            // LblCodigo
            // 
            this.LblCodigo.Location = new System.Drawing.Point(20, 50);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(100, 23);
            this.LblCodigo.TabIndex = 1;
            this.LblCodigo.Text = "Código:";
            // 
            // LblNombre
            // 
            this.LblNombre.Location = new System.Drawing.Point(20, 80);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(100, 23);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.Location = new System.Drawing.Point(20, 110);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(100, 23);
            this.LblDescripcion.TabIndex = 5;
            this.LblDescripcion.Text = "Descripción:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(100, 50);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(200, 22);
            this.TxtCodigo.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(100, 80);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(300, 22);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(100, 110);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(400, 22);
            this.TxtDescripcion.TabIndex = 6;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(520, 50);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 7;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(520, 80);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(520, 110);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(520, 140);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(118, 162);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(250, 22);
            this.TxtBuscar.TabIndex = 11;
            // 
            // ChkActivos
            // 
            this.ChkActivos.Location = new System.Drawing.Point(378, 162);
            this.ChkActivos.Name = "ChkActivos";
            this.ChkActivos.Size = new System.Drawing.Size(104, 24);
            this.ChkActivos.TabIndex = 12;
            this.ChkActivos.Text = "Solo activos";
            this.ChkActivos.CheckedChanged += new System.EventHandler(this.ChkActivos_CheckedChanged);
            // 
            // DgvColecciones
            // 
            this.DgvColecciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvColecciones.ColumnHeadersHeight = 29;
            this.DgvColecciones.Location = new System.Drawing.Point(20, 190);
            this.DgvColecciones.Name = "DgvColecciones";
            this.DgvColecciones.ReadOnly = true;
            this.DgvColecciones.RowHeadersWidth = 51;
            this.DgvColecciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvColecciones.Size = new System.Drawing.Size(700, 270);
            this.DgvColecciones.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar:";
            // 
            // FrmColeccion
            // 
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.ChkActivos);
            this.Controls.Add(this.DgvColecciones);
            this.Name = "FrmColeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colecciones";
            ((System.ComponentModel.ISupportInitialize)(this.DgvColecciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}
