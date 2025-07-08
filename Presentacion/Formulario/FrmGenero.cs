using Datos;
using Negocio.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formulario
{
    public partial class FrmGenero : Form
    {
        private NGenero nGenero = new NGenero();

        public FrmGenero()
        {
            InitializeComponent();
            MostrarGeneros(nGenero.ListarGeneros());
        }

        private void MostrarGeneros(List<Genero> generos)
        {
            DgvGeneros.DataSource = null;

            if (generos.Count == 0) return;

            var datos = generos.Select(g => new
            {
                g.Codigo,
                g.Nombre,
                Estado = g.Estado == 1 ? "Activo" : "Inactivo"
            }).ToList();

            DgvGeneros.DataSource = datos;
        }

        private void BtnRegistrarGenero_Click(object sender, EventArgs e)
        {
            if (TxtCodigoGenero.Text == "" || TxtNombreGenero.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Genero genero = new Genero()
            {
                Codigo = TxtCodigoGenero.Text,
                Nombre = TxtNombreGenero.Text,
                Estado = 1
            };

            string mensaje = nGenero.Registrar(genero);
            MessageBox.Show(mensaje);

            MostrarGeneros(nGenero.ListarGeneros());
        }

        private void DgvGeneros_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvGeneros.SelectedRows.Count > 0)
            {
                var fila = DgvGeneros.SelectedRows[0];
                TxtCodigoGenero.Text = fila.Cells["Codigo"].Value.ToString();
                TxtNombreGenero.Text = fila.Cells["Nombre"].Value.ToString();
                TxtCodigoGenero.Enabled = false;
            }
        }

        private void BtnModificarGenero_Click(object sender, EventArgs e)
        {
            if (DgvGeneros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un género");
                return;
            }
            if (TxtCodigoGenero.Text == "" || TxtNombreGenero.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Genero genero = new Genero()
            {
                Codigo = TxtCodigoGenero.Text,
                Nombre = TxtNombreGenero.Text
            };

            string mensaje = nGenero.Modificar(genero);
            MessageBox.Show(mensaje);

            MostrarGeneros(nGenero.ListarGeneros());
        }

        private void BtnEliminarGenero_Click(object sender, EventArgs e)
        {
            if (DgvGeneros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un género");
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de eliminar este género?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.No)
                return;

            string codigo = DgvGeneros.SelectedRows[0].Cells["Codigo"].Value.ToString();

            string mensaje = nGenero.EliminarLogico(codigo);
            MessageBox.Show(mensaje);

            MostrarGeneros(nGenero.ListarGeneros());
            BtnLimpiarGenero_Click(null, null);
        }

        private void BtnLimpiarGenero_Click(object sender, EventArgs e)
        {
            TxtCodigoGenero.Text = "";
            TxtNombreGenero.Text = "";
            TxtCodigoGenero.Enabled = true;

            TxtBusquedaGenero.Text = "Buscar por nombre...";
            ChkActivosGenero.Checked = false;
            TxtCodigoGenero.Focus();
        }

        private void TxtBusquedaGenero_TextChanged(object sender, EventArgs e)
        {
            FiltrarGeneros();
        }

        private void ChkActivosGenero_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarGeneros();
        }

        private void FiltrarGeneros()
        {
            string filtro = TxtBusquedaGenero.Text.ToLower();
            bool soloActivos = ChkActivosGenero.Checked;

            if (filtro == "buscar por nombre...") filtro = "";

            var filtrados = nGenero.ListarGeneros()
                .Where(g => g.Nombre.ToLower().Contains(filtro) && (!soloActivos || g.Estado == 1))
                .ToList();

            MostrarGeneros(filtrados);
        }

        private void TxtBusquedaGenero_Enter(object sender, EventArgs e)
        {
            if (TxtBusquedaGenero.Text == "Buscar por nombre...")
            {
                TxtBusquedaGenero.Text = "";
                TxtBusquedaGenero.ForeColor = Color.Black;
            }
        }

        private void TxtBusquedaGenero_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBusquedaGenero.Text))
            {
                TxtBusquedaGenero.Text = "Buscar por nombre...";
                TxtBusquedaGenero.ForeColor = Color.Gray;
            }
        }

        private void DgvGeneros_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Rows[e.RowIndex].DataBoundItem == null) return;

            dynamic fila = dgv.Rows[e.RowIndex].DataBoundItem;

            try
            {
                string estado = fila.Estado;
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = estado == "Inactivo" ? Color.LightCoral : Color.White;
            }
            catch (Exception) { }
        }
    }
}