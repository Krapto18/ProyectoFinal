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
    public partial class FrmPlataforma : Form
    {
        private NPlataforma nPlataforma = new NPlataforma();

        public FrmPlataforma()
        {
            InitializeComponent();
            MostrarPlataformas(nPlataforma.ListarPlataformas());
        }

        private void MostrarPlataformas(List<Plataforma> plataformas)
        {
            DgvPlataformas.DataSource = null;

            if (plataformas.Count == 0)
                return;

            var datos = plataformas.Select(p => new
            {
                p.Codigo,
                p.Nombre,
                Estado = p.Estado == 1 ? "Activo" : "Inactivo"
            }).ToList();

            DgvPlataformas.DataSource = datos;
        }

        private void BtnRegistrarPlataforma_Click(object sender, EventArgs e)
        {
            if (TxtCodigoPlataforma.Text == "" || TxtNombrePlataforma.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Plataforma plataforma = new Plataforma()
            {
                Codigo = TxtCodigoPlataforma.Text,
                Nombre = TxtNombrePlataforma.Text,
                Estado = 1
            };

            string mensaje = nPlataforma.Registrar(plataforma);
            MessageBox.Show(mensaje);

            MostrarPlataformas(nPlataforma.ListarPlataformas());
        }

        private void DgvPlataformas_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvPlataformas.SelectedRows.Count > 0)
            {
                var fila = DgvPlataformas.SelectedRows[0];
                TxtCodigoPlataforma.Text = fila.Cells["Codigo"].Value.ToString();
                TxtNombrePlataforma.Text = fila.Cells["Nombre"].Value.ToString();
                TxtCodigoPlataforma.Enabled = false;
            }
        }

        private void BtnModificarPlataforma_Click(object sender, EventArgs e)
        {
            if (DgvPlataformas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una plataforma");
                return;
            }
            if (TxtCodigoPlataforma.Text == "" || TxtNombrePlataforma.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Plataforma plataforma = new Plataforma()
            {
                Codigo = TxtCodigoPlataforma.Text,
                Nombre = TxtNombrePlataforma.Text
            };

            string mensaje = nPlataforma.Modificar(plataforma);
            MessageBox.Show(mensaje);

            MostrarPlataformas(nPlataforma.ListarPlataformas());
        }

        private void BtnEliminarPlataforma_Click(object sender, EventArgs e)
        {
            if (DgvPlataformas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una plataforma");
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de eliminar esta plataforma?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.No)
                return;

            string codigo = DgvPlataformas.SelectedRows[0].Cells["Codigo"].Value.ToString();

            string mensaje = nPlataforma.EliminarLogico(codigo);
            MessageBox.Show(mensaje);

            MostrarPlataformas(nPlataforma.ListarPlataformas());
            BtnLimpiarPlataforma_Click(null, null);
        }

        private void BtnLimpiarPlataforma_Click(object sender, EventArgs e)
        {
            TxtCodigoPlataforma.Text = "";
            TxtNombrePlataforma.Text = "";
            TxtCodigoPlataforma.Enabled = true;

            TxtBusquedaPlataforma.Text = "Buscar por nombre...";
            ChkActivosPlataforma.Checked = false;
            TxtCodigoPlataforma.Focus();
        }

        private void TxtBusquedaPlataforma_TextChanged(object sender, EventArgs e)
        {
            FiltrarPlataformas();
        }

        private void ChkActivosPlataforma_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarPlataformas();
        }

        private void FiltrarPlataformas()
        {
            string filtro = TxtBusquedaPlataforma.Text.ToLower();
            bool soloActivos = ChkActivosPlataforma.Checked;

            if (filtro == "buscar por nombre...") filtro = "";

            var filtradas = nPlataforma.ListarPlataformas()
                .Where(p => p.Nombre.ToLower().Contains(filtro) && (!soloActivos || p.Estado == 1))
                .ToList();

            MostrarPlataformas(filtradas);
        }

        private void TxtBusquedaPlataforma_Enter(object sender, EventArgs e)
        {
            if (TxtBusquedaPlataforma.Text == "Buscar por nombre...")
            {
                TxtBusquedaPlataforma.Text = "";
                TxtBusquedaPlataforma.ForeColor = Color.Black;
            }
        }

        private void TxtBusquedaPlataforma_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBusquedaPlataforma.Text))
            {
                TxtBusquedaPlataforma.Text = "Buscar por nombre...";
                TxtBusquedaPlataforma.ForeColor = Color.Gray;
            }
        }

        private void DgvPlataformas_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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