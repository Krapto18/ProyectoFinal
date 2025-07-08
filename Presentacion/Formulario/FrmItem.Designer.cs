namespace Presentacion.Formulario
{
    partial class FrmItem
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblTituloItem;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblAnio;
        private System.Windows.Forms.Label LblColeccion;
        private System.Windows.Forms.Label LblGenero;

        private System.Windows.Forms.TextBox TxtCodigoItem;
        private System.Windows.Forms.TextBox TxtTituloItem;
        private System.Windows.Forms.ComboBox CbTipoItem;
        private System.Windows.Forms.TextBox TxtAnioItem;
        private System.Windows.Forms.ComboBox CbColeccionItem;
        private System.Windows.Forms.ComboBox CbGeneroItem;
        private System.Windows.Forms.Button BtnRegistrarItem;
        private System.Windows.Forms.Button BtnModificarItem;
        private System.Windows.Forms.Button BtnEliminarItem;
        private System.Windows.Forms.Button BtnLimpiarItem;
        private System.Windows.Forms.TextBox TxtBuscarItem;
        private System.Windows.Forms.CheckBox ChkActivosItem;
        private System.Windows.Forms.DataGridView DgvItems;

        private void InitializeComponent()
        {
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblTituloItem = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblAnio = new System.Windows.Forms.Label();
            this.LblColeccion = new System.Windows.Forms.Label();
            this.LblGenero = new System.Windows.Forms.Label();
            this.TxtCodigoItem = new System.Windows.Forms.TextBox();
            this.TxtTituloItem = new System.Windows.Forms.TextBox();
            this.CbTipoItem = new System.Windows.Forms.ComboBox();
            this.TxtAnioItem = new System.Windows.Forms.TextBox();
            this.CbColeccionItem = new System.Windows.Forms.ComboBox();
            this.CbGeneroItem = new System.Windows.Forms.ComboBox();
            this.BtnRegistrarItem = new System.Windows.Forms.Button();
            this.BtnModificarItem = new System.Windows.Forms.Button();
            this.BtnEliminarItem = new System.Windows.Forms.Button();
            this.BtnLimpiarItem = new System.Windows.Forms.Button();
            this.TxtBuscarItem = new System.Windows.Forms.TextBox();
            this.ChkActivosItem = new System.Windows.Forms.CheckBox();
            this.DgvItems = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.Location = new System.Drawing.Point(20, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(257, 30);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Gestión de Ítems";
            // 
            // LblCodigo
            // 
            this.LblCodigo.Location = new System.Drawing.Point(20, 45);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(61, 23);
            this.LblCodigo.TabIndex = 1;
            this.LblCodigo.Text = "Código:";
            // 
            // LblTituloItem
            // 
            this.LblTituloItem.Location = new System.Drawing.Point(20, 75);
            this.LblTituloItem.Name = "LblTituloItem";
            this.LblTituloItem.Size = new System.Drawing.Size(61, 23);
            this.LblTituloItem.TabIndex = 3;
            this.LblTituloItem.Text = "Título:";
            // 
            // LblTipo
            // 
            this.LblTipo.Location = new System.Drawing.Point(20, 105);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(61, 23);
            this.LblTipo.TabIndex = 5;
            this.LblTipo.Text = "Tipo:";
            // 
            // LblAnio
            // 
            this.LblAnio.Location = new System.Drawing.Point(20, 135);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(61, 23);
            this.LblAnio.TabIndex = 7;
            this.LblAnio.Text = "Año:";
            // 
            // LblColeccion
            // 
            this.LblColeccion.Location = new System.Drawing.Point(12, 165);
            this.LblColeccion.Name = "LblColeccion";
            this.LblColeccion.Size = new System.Drawing.Size(69, 23);
            this.LblColeccion.TabIndex = 9;
            this.LblColeccion.Text = "Colección:";
            // 
            // LblGenero
            // 
            this.LblGenero.Location = new System.Drawing.Point(20, 195);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(61, 23);
            this.LblGenero.TabIndex = 11;
            this.LblGenero.Text = "Género:";
            // 
            // TxtCodigoItem
            // 
            this.TxtCodigoItem.Location = new System.Drawing.Point(100, 42);
            this.TxtCodigoItem.Name = "TxtCodigoItem";
            this.TxtCodigoItem.Size = new System.Drawing.Size(200, 22);
            this.TxtCodigoItem.TabIndex = 2;
            // 
            // TxtTituloItem
            // 
            this.TxtTituloItem.Location = new System.Drawing.Point(100, 72);
            this.TxtTituloItem.Name = "TxtTituloItem";
            this.TxtTituloItem.Size = new System.Drawing.Size(300, 22);
            this.TxtTituloItem.TabIndex = 4;
            // 
            // CbTipoItem
            // 
            this.CbTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoItem.Location = new System.Drawing.Point(100, 102);
            this.CbTipoItem.Name = "CbTipoItem";
            this.CbTipoItem.Size = new System.Drawing.Size(200, 24);
            this.CbTipoItem.TabIndex = 6;
            // 
            // TxtAnioItem
            // 
            this.TxtAnioItem.Location = new System.Drawing.Point(100, 132);
            this.TxtAnioItem.Name = "TxtAnioItem";
            this.TxtAnioItem.Size = new System.Drawing.Size(100, 22);
            this.TxtAnioItem.TabIndex = 8;
            // 
            // CbColeccionItem
            // 
            this.CbColeccionItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbColeccionItem.Location = new System.Drawing.Point(100, 162);
            this.CbColeccionItem.Name = "CbColeccionItem";
            this.CbColeccionItem.Size = new System.Drawing.Size(250, 24);
            this.CbColeccionItem.TabIndex = 10;
            // 
            // CbGeneroItem
            // 
            this.CbGeneroItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGeneroItem.Location = new System.Drawing.Point(100, 192);
            this.CbGeneroItem.Name = "CbGeneroItem";
            this.CbGeneroItem.Size = new System.Drawing.Size(250, 24);
            this.CbGeneroItem.TabIndex = 12;
            // 
            // BtnRegistrarItem
            // 
            this.BtnRegistrarItem.Location = new System.Drawing.Point(512, 54);
            this.BtnRegistrarItem.Name = "BtnRegistrarItem";
            this.BtnRegistrarItem.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrarItem.TabIndex = 13;
            this.BtnRegistrarItem.Text = "Registrar";
            this.BtnRegistrarItem.Click += new System.EventHandler(this.BtnRegistrarItem_Click_1);
            // 
            // BtnModificarItem
            // 
            this.BtnModificarItem.Location = new System.Drawing.Point(512, 84);
            this.BtnModificarItem.Name = "BtnModificarItem";
            this.BtnModificarItem.Size = new System.Drawing.Size(75, 23);
            this.BtnModificarItem.TabIndex = 14;
            this.BtnModificarItem.Text = "Modificar";
            this.BtnModificarItem.Click += new System.EventHandler(this.BtnModificarItem_Click_1);
            // 
            // BtnEliminarItem
            // 
            this.BtnEliminarItem.Location = new System.Drawing.Point(512, 114);
            this.BtnEliminarItem.Name = "BtnEliminarItem";
            this.BtnEliminarItem.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarItem.TabIndex = 15;
            this.BtnEliminarItem.Text = "Eliminar";
            this.BtnEliminarItem.Click += new System.EventHandler(this.BtnEliminarItem_Click_1);
            // 
            // BtnLimpiarItem
            // 
            this.BtnLimpiarItem.Location = new System.Drawing.Point(512, 144);
            this.BtnLimpiarItem.Name = "BtnLimpiarItem";
            this.BtnLimpiarItem.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiarItem.TabIndex = 16;
            this.BtnLimpiarItem.Text = "Limpiar";
            this.BtnLimpiarItem.Click += new System.EventHandler(this.BtnLimpiarItem_Click_1);
            // 
            // TxtBuscarItem
            // 
            this.TxtBuscarItem.Location = new System.Drawing.Point(100, 232);
            this.TxtBuscarItem.Name = "TxtBuscarItem";
            this.TxtBuscarItem.Size = new System.Drawing.Size(250, 22);
            this.TxtBuscarItem.TabIndex = 17;
            // 
            // ChkActivosItem
            // 
            this.ChkActivosItem.Location = new System.Drawing.Point(360, 232);
            this.ChkActivosItem.Name = "ChkActivosItem";
            this.ChkActivosItem.Size = new System.Drawing.Size(104, 24);
            this.ChkActivosItem.TabIndex = 18;
            this.ChkActivosItem.Text = "Solo activos";
            // 
            // DgvItems
            // 
            this.DgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvItems.ColumnHeadersHeight = 29;
            this.DgvItems.Location = new System.Drawing.Point(20, 260);
            this.DgvItems.Name = "DgvItems";
            this.DgvItems.ReadOnly = true;
            this.DgvItems.RowHeadersWidth = 51;
            this.DgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvItems.Size = new System.Drawing.Size(600, 250);
            this.DgvItems.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buscar:";
            // 
            // FrmItem
            // 
            this.ClientSize = new System.Drawing.Size(650, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.TxtCodigoItem);
            this.Controls.Add(this.LblTituloItem);
            this.Controls.Add(this.TxtTituloItem);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.CbTipoItem);
            this.Controls.Add(this.LblAnio);
            this.Controls.Add(this.TxtAnioItem);
            this.Controls.Add(this.LblColeccion);
            this.Controls.Add(this.CbColeccionItem);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.CbGeneroItem);
            this.Controls.Add(this.BtnRegistrarItem);
            this.Controls.Add(this.BtnModificarItem);
            this.Controls.Add(this.BtnEliminarItem);
            this.Controls.Add(this.BtnLimpiarItem);
            this.Controls.Add(this.TxtBuscarItem);
            this.Controls.Add(this.ChkActivosItem);
            this.Controls.Add(this.DgvItems);
            this.Name = "FrmItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ítems";
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}