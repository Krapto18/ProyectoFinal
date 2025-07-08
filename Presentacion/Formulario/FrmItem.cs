using Datos;
using Datos.Entity;
using Negocio.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace Presentacion.Formulario
{
    public partial class FrmItem : Form
    {
        private NItem nItem = new NItem();
        private NColeccion nColeccion = new NColeccion();
        private NGenero nGenero = new NGenero();

        public FrmItem()
        {
            InitializeComponent();
            CargarColecciones();
            CargarGeneros();
            CargarTipos();
            MostrarItems(nItem.ListarItems());
        }

        private void CargarColecciones()
        {
            var colecciones = nColeccion.Listar();
            CbColeccionItem.DataSource = colecciones;
            CbColeccionItem.DisplayMember = "Nombre";
            CbColeccionItem.ValueMember = "Id";
            CbColeccionItem.SelectedIndex = -1;
        }

        private void CargarGeneros()
        {
            var generos = nGenero.ListarGeneros().Where(g => g.Estado == 1).ToList();
            CbGeneroItem.DataSource = generos;
            CbGeneroItem.DisplayMember = "Nombre";
            CbGeneroItem.ValueMember = "Id";
            CbGeneroItem.SelectedIndex = -1;
        }

        private void CargarTipos()
        {
            CbTipoItem.Items.Clear();
            CbTipoItem.Items.AddRange(new string[] { "Libro", "Película", "Juego", "Otro" });
            CbTipoItem.SelectedIndex = -1;
        }

        private void MostrarItems(List<Item> items)
        {
            DgvItems.DataSource = null;
            if (items.Count == 0) return;

            var datos = items.Select(i => new
            {
                i.Codigo,
                i.Titulo,
                i.Tipo,
                i.Anio,
                Genero = i.Genero1 != null ? i.Genero1.Nombre : "",
                Coleccion = i.Coleccion != null ? i.Coleccion.Nombre : "",
                Estado = i.Estado == 1 ? "Activo" : "Inactivo"
            }).ToList();

            DgvItems.DataSource = datos;
        }

        private void BtnRegistrarItem_Click(object sender, EventArgs e)
        {

        }

        private void DgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvItems.SelectedRows.Count == 0) return;

            var fila = DgvItems.SelectedRows[0];
            TxtCodigoItem.Text = fila.Cells["Codigo"].Value.ToString();
            TxtTituloItem.Text = fila.Cells["Titulo"].Value.ToString();
            CbTipoItem.Text = fila.Cells["Tipo"].Value.ToString();
            TxtAnioItem.Text = fila.Cells["Anio"].Value.ToString();
            CbGeneroItem.Text = fila.Cells["Genero"].Value.ToString();
            CbColeccionItem.Text = fila.Cells["Coleccion"].Value.ToString();

            TxtCodigoItem.Enabled = false;
        }

        private void BtnModificarItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiarItem_Click(object sender, EventArgs e)
        {

        }

        private void TxtBuscarItem_TextChanged(object sender, EventArgs e)
        {
            string filtro = TxtBuscarItem.Text.ToLower();
            if (filtro == "buscar por título...") filtro = "";

            var items = nItem.ListarItems().Where(i => i.Titulo.ToLower().Contains(filtro)).ToList();
            MostrarItems(items);
        }

        private void TxtBuscarItem_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarItem.Text == "Buscar por título...")
            {
                TxtBuscarItem.Text = "";
                TxtBuscarItem.ForeColor = Color.Black;
            }
        }

        private void TxtBuscarItem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBuscarItem.Text))
            {
                TxtBuscarItem.Text = "Buscar por título...";
                TxtBuscarItem.ForeColor = Color.Gray;
            }
        }

        private void ChkActivosItem_CheckedChanged(object sender, EventArgs e)
        {
            string filtro = TxtBuscarItem.Text.ToLower();
            if (filtro == "buscar por título...") filtro = "";

            bool soloActivos = ChkActivosItem.Checked;

            var items = nItem.ListarItems()
                .Where(i => i.Titulo.ToLower().Contains(filtro) && (!soloActivos || i.Estado == 1))
                .ToList();

            MostrarItems(items);
        }

        private void DgvItems_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Rows[e.RowIndex].DataBoundItem == null) return;

            dynamic fila = dgv.Rows[e.RowIndex].DataBoundItem;
            try
            {
                string estado = fila.Estado;
                if (estado == "Inactivo")
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
            catch (Exception) { }
        }

        private void BtnModificarItem_Click_1(object sender, EventArgs e)
        {
            if (DgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un ítem");
                return;
            }

            if (TxtCodigoItem.Text == "" || TxtTituloItem.Text == "" ||
                CbTipoItem.SelectedIndex == -1 || TxtAnioItem.Text == "" ||
                CbColeccionItem.SelectedIndex == -1 || CbGeneroItem.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Item item = new Item()
            {
                Codigo = TxtCodigoItem.Text,
                Titulo = TxtTituloItem.Text,
                Tipo = CbTipoItem.SelectedItem.ToString(),
                Anio = Convert.ToInt32(TxtAnioItem.Text),
                ColeccionId = Convert.ToInt32(CbColeccionItem.SelectedValue),
                GeneroId = Convert.ToInt32(CbGeneroItem.SelectedValue)
            };

            string mensaje = nItem.Modificar(item);
            MessageBox.Show(mensaje);
            MostrarItems(nItem.ListarItems());
        }

        private void BtnRegistrarItem_Click_1(object sender, EventArgs e)
        {
            if (TxtCodigoItem.Text == "" || TxtTituloItem.Text == "" ||
    CbTipoItem.SelectedIndex == -1 || TxtAnioItem.Text == "" ||
    CbColeccionItem.SelectedIndex == -1 || CbGeneroItem.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese todos los campos obligatorios");
                return;
            }

            Item item = new Item()
            {
                Codigo = TxtCodigoItem.Text,
                Titulo = TxtTituloItem.Text,
                Tipo = CbTipoItem.SelectedItem.ToString(),
                Anio = Convert.ToInt32(TxtAnioItem.Text),
                ColeccionId = Convert.ToInt32(CbColeccionItem.SelectedValue),
                GeneroId = Convert.ToInt32(CbGeneroItem.SelectedValue),
                Estado = 1
            };

            string mensaje = nItem.Registrar(item);
            MessageBox.Show(mensaje);
            MostrarItems(nItem.ListarItems());

        }

        private void BtnEliminarItem_Click_1(object sender, EventArgs e)
        {
            if (DgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un item");
                return;
            }

            string codigo = DgvItems.SelectedRows[0].Cells["Codigo"].Value.ToString();
            string mensaje = nItem.EliminarLogico(codigo);
            MessageBox.Show(mensaje);
            MostrarItems(nItem.ListarItems());
        }

        private void BtnLimpiarItem_Click_1(object sender, EventArgs e)
        {
            TxtCodigoItem.Text = "";
            TxtTituloItem.Text = "";
            TxtAnioItem.Text = "";
            CbTipoItem.SelectedIndex = -1;
            CbColeccionItem.SelectedIndex = -1;
            CbGeneroItem.SelectedIndex = -1;

            TxtCodigoItem.Enabled = true;
            TxtCodigoItem.Focus();

        }
    }
}