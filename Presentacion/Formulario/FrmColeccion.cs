using Datos;
using Datos.Entity;
using Negocio.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Formulario
{
    public partial class FrmColeccion : Form
    {
        private NColeccion nColeccion = new NColeccion();
        private Usuario usuarioLogueado;
        public FrmColeccion(Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioLogueado;
            MostrarColecciones(nColeccion.Listar());
        }

        private void MostrarColecciones(List<Coleccion> lista)
        {
            DgvColecciones.DataSource = null;
            if (lista.Count == 0) return;

            var datos = lista.Select(c => new
            {
                c.Codigo,
                c.Nombre,
                c.Descripcion,
                Estado = c.Estado == 1 ? "Activo" : "Inactivo"
            }).ToList();

            DgvColecciones.DataSource = datos;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCodigo.Text) ||
                string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Coleccion coleccion = new Coleccion
            {
                Codigo = TxtCodigo.Text,
                Nombre = TxtNombre.Text,
                Descripcion = TxtDescripcion.Text,
                UsuarioId = usuarioLogueado.Id,
                Estado = 1
            };

            string mensaje = nColeccion.Registrar(coleccion);
            MessageBox.Show(mensaje);
            MostrarColecciones(nColeccion.Listar());
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvColecciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una colección");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtCodigo.Text) ||
                string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Coleccion coleccion = new Coleccion
            {
                Codigo = TxtCodigo.Text,
                Nombre = TxtNombre.Text,
                Descripcion = TxtDescripcion.Text,
                UsuarioId = usuarioLogueado.Id
            };

            string mensaje = nColeccion.Modificar(coleccion);
            MessageBox.Show(mensaje);
            MostrarColecciones(nColeccion.Listar());
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvColecciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una colección");
                return;
            }

            string codigo = DgvColecciones.SelectedRows[0].Cells["Codigo"].Value.ToString();

            DialogResult result = MessageBox.Show("¿Desea eliminar esta colección?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            string mensaje = nColeccion.EliminarLogico(codigo);
            MessageBox.Show(mensaje);
            MostrarColecciones(nColeccion.Listar());
            BtnLimpiar_Click(null, null);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
            TxtCodigo.Enabled = true;

            TxtBuscar.Text = "Buscar por nombre...";
            TxtBuscar.ForeColor = Color.Gray;
            ChkActivos.Checked = false;
            TxtCodigo.Focus();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void TxtBuscar_Enter(object sender, EventArgs e)
        {
            if (TxtBuscar.Text == "Buscar por nombre...")
            {
                TxtBuscar.Text = "";
                TxtBuscar.ForeColor = Color.Black;
            }
        }

        private void TxtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBuscar.Text))
            {
                TxtBuscar.Text = "Buscar por nombre...";
                TxtBuscar.ForeColor = Color.Gray;
            }
        }

        private void ChkActivos_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Filtrar()
        {
            string filtro = TxtBuscar.Text.ToLower();
            if (filtro == "buscar por nombre...") filtro = "";

            bool soloActivos = ChkActivos.Checked;

            var lista = nColeccion.Listar()
                .Where(c => c.Nombre.ToLower().Contains(filtro) &&
                    (!soloActivos || c.Estado == 1)).ToList();

            MostrarColecciones(lista);
        }

        private void DgvColecciones_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvColecciones.SelectedRows.Count == 0) return;

            var fila = DgvColecciones.SelectedRows[0];
            TxtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
            TxtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            TxtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            TxtCodigo.Enabled = false;
        }

        private void DgvColecciones_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Rows[e.RowIndex].DataBoundItem == null) return;

            dynamic fila = dgv.Rows[e.RowIndex].DataBoundItem;

            try
            {
                string estado = fila.Estado;
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                    estado == "Inactivo" ? Color.LightCoral : Color.White;
            }
            catch { }
        }
    }
}