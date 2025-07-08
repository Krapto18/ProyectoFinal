using Datos;
using Datos.Entity;
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
    public partial class FrmRol : Form
    {
        private NRol nRol = new NRol();
        public FrmRol()
        {
            InitializeComponent();
            MostrarRoles(nRol.ListarRoles());
        }
        private void MostrarRoles(List<Rol> roles)
        {
            DgvRoles.DataSource = null;

            if (roles.Count == 0)
                return;

            var datosLimpiados = roles.Select(r => new
            {
                r.Codigo,
                r.Nombre,
                r.Descripcion,
                Estado = r.Estado == 1 ? "Activo" : "Inactivo"
            }).ToList();

            DgvRoles.DataSource = datosLimpiados;
        }

        private void BtnRegistrarRol_Click(object sender, EventArgs e)
        {
            if (TxtCodigoRol.Text == "" || TxtNombreRol.Text == "" || TxtDescripcionRol.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Rol rol = new Rol()
            {
                Codigo = TxtCodigoRol.Text,
                Nombre = TxtNombreRol.Text,
                Descripcion = TxtDescripcionRol.Text,
                Estado = 1
            };

            string mensaje = nRol.Registrar(rol);
            MessageBox.Show(mensaje);

            MostrarRoles(nRol.ListarRoles());
        }

        private void DgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvRoles.SelectedRows.Count > 0)
            {
                var fila = DgvRoles.SelectedRows[0];

                TxtCodigoRol.Text = fila.Cells["Codigo"].Value.ToString();
                TxtNombreRol.Text = fila.Cells["Nombre"].Value.ToString();
                TxtDescripcionRol.Text = fila.Cells["Descripcion"].Value.ToString();

                TxtCodigoRol.Enabled = false;

            }
        }

        private void TxtBusquedaRol_TextChanged(object sender, EventArgs e)
        {
            FiltrarRoles();
        }

        private void TxtBusquedaRol_Enter(object sender, EventArgs e)
        {
            if (TxtBusquedaRol.Text == "Buscar por nombre...")
            {
                TxtBusquedaRol.Text = "";
                TxtBusquedaRol.ForeColor = Color.Black;
            }
        }

        private void TxtBusquedaRol_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBusquedaRol.Text))
            {
                TxtBusquedaRol.Text = "Buscar por nombre...";
                TxtBusquedaRol.ForeColor = Color.Gray;
            }
        }
        private void FiltrarRoles()
        {
            string filtro = TxtBusquedaRol.Text.ToLower();
            bool soloActivos = ChkActivosRol.Checked;

            if (filtro == "buscar por nombre...") filtro = "";

            var roles = nRol.ListarRoles()
                .Where(u =>
                    u.Nombre.ToLower().Contains(filtro) &&
                    (!soloActivos || u.Estado == 1)
                ).ToList();

            MostrarRoles(roles);
        }

        private void ChkActivosRol_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarRoles();
        }

        private void BtnModificarRol_Click(object sender, EventArgs e)
        {
            if (DgvRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Rol");
                return;
            }
            if (TxtNombreRol.Text == "" || TxtCodigoRol.Text == "" || TxtDescripcionRol.Text=="")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            Rol Rol = new Rol()
            {
                Codigo = TxtCodigoRol.Text,
                Nombre = TxtNombreRol.Text,
                Descripcion = TxtDescripcionRol.Text
            };
            String mensaje = nRol.Modificar(Rol);
            MessageBox.Show(mensaje);

            MostrarRoles(nRol.ListarRoles());
        }

        private void BtnEliminarRol_Click(object sender, EventArgs e)
        {
            if (DgvRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un rol");
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de eliminar este rol?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.No)
                return;

            string codigoRol = DgvRoles.SelectedRows[0].Cells["Codigo"].Value.ToString();

            string mensaje = nRol.EliminarLogico(codigoRol);
            MessageBox.Show(mensaje);

            MostrarRoles(nRol.ListarRoles());

            BtnLimpiarRol_Click(null, null);
        }

        private void BtnLimpiarRol_Click(object sender, EventArgs e)
        {
            TxtCodigoRol.Text = "";
            TxtNombreRol.Text = "";
            TxtDescripcionRol.Text = "";

            TxtCodigoRol.Enabled = true;

            TxtBusquedaRol.Text = "Buscar por nombre...";
            ChkActivosRol.Checked = false;
            TxtCodigoRol.Focus();
        }

        private void DgvRoles_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Rows[e.RowIndex].DataBoundItem == null) return;

            dynamic fila = dgv.Rows[e.RowIndex].DataBoundItem;

            try
            {

                string estado = fila.Estado;

                if (estado == "Inactivo")
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral; // rojo claro
                }
                else
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
