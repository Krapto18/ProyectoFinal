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

namespace Presentacion
{
    public partial class FrmUsuario : Form
    {
        private NUsuario nUsuario= new NUsuario();
        private NRol nRol = new NRol();
        public FrmUsuario()
        {
            InitializeComponent();
            MostrarUsuarios(nUsuario.ListarUsuarios());
            CargarRoles();
            TxtBuscarNombreUsuario.Text = "Buscar por nombre...";
            TxtBuscarNombreUsuario.ForeColor = Color.Gray;
        }
        private void CargarRoles()
        {
            var roles = nRol.ListarRolesActivos();
            CbRolUsuario.DataSource = roles;
            CbRolUsuario.DisplayMember = "Nombre";
            CbRolUsuario.ValueMember = "Id";
            CbRolUsuario.SelectedIndex = -1;
        }
        //Configuración de data gried view de los usuarios
        private void MostrarUsuarios(List<Usuario> usuarios)
        {
            DgvUsuarios.DataSource = null;

            if (usuarios.Count == 0)
                return;

            var datosLimpiados = usuarios.Select(u => new
            {
                u.Codigo,
                u.Nombre,
                u.Email,
                Usuario = u.NombreUsuario,
                Rol = u.Rol != null ? u.Rol.Nombre : "Sin rol",
                Estado = u.Estado == 1 ? "Activo" : "Inactivo"
            }).ToList();

            DgvUsuarios.DataSource = datosLimpiados;
        }

        private void DgvUsuarios_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Evita que la app se cierre si hay error al mostrar datos
            e.ThrowException = false;

            // Opcional: muestra un mensaje si quieres saber qué pasó
            Console.WriteLine($"Error en celda [{e.RowIndex}, {e.ColumnIndex}]: {e.Exception.Message}");
        }

        private void DgvUsuarios_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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
        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvUsuarios.SelectedRows.Count > 0)
            {
                var fila = DgvUsuarios.SelectedRows[0];

                TxtCodigoUsuario.Text = fila.Cells["Codigo"].Value.ToString();
                TxtNombreUsuario.Text = fila.Cells["Nombre"].Value.ToString();
                TxtEmailUsuario.Text = fila.Cells["Email"].Value.ToString();
                TxtNombreUsuario.Text = fila.Cells["Usuario"].Value.ToString();
                //TxtContraseniaUsuario.Text = fila.Cells["Contraseña"].Value.ToString();

                // Busca el Rol por nombre y lo selecciona en el ComboBox
                string rolNombre = fila.Cells["Rol"].Value.ToString();
                CbRolUsuario.SelectedIndex = CbRolUsuario.FindStringExact(rolNombre);
                TxtCodigoUsuario.Enabled = false;
                TxtNombreUsuario.Enabled = false;
                TxtContraseniaUsuario.Enabled = false;
            }
        }
        //Configuración de caja de texto de búsqueda
        private void TxtBuscarNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }
        private void TxtBuscarNombreUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarNombreUsuario.Text == "Buscar por nombre...")
            {
                TxtBuscarNombreUsuario.Text = "";
                TxtBuscarNombreUsuario.ForeColor = Color.Black;
            }
        }

        private void TxtBuscarNombreUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBuscarNombreUsuario.Text))
            {
                TxtBuscarNombreUsuario.Text = "Buscar por nombre...";
                TxtBuscarNombreUsuario.ForeColor = Color.Gray;
            }
        }

        private void FiltrarUsuarios()
        {
            string filtro = TxtBuscarNombreUsuario.Text.ToLower();
            bool soloActivos = chkUsuarios.Checked;

            if (filtro == "buscar por nombre...") filtro = "";

            var usuarios = nUsuario.ListarUsuarios()
                .Where(u =>
                    u.Nombre.ToLower().Contains(filtro) &&
                    (!soloActivos || u.Estado == 1)
                ).ToList();

            MostrarUsuarios(usuarios);
        }

        private void chkUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }
        //Configuración de botones
        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (TxtNombreUsuario.Text == "" || TxtCodigoUsuario.Text == "" || TxtEmailUsuario.Text == "" || TxtUsuario.Text=="" 
                || TxtContraseniaUsuario.Text==""|| CbRolUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Usuario usuario = new Usuario()
            {
                Codigo = TxtCodigoUsuario.Text,
                Nombre = TxtNombreUsuario.Text,
                Email = TxtEmailUsuario.Text,
                RolId = Convert.ToInt32(CbRolUsuario.SelectedValue),
                NombreUsuario=TxtUsuario.Text,
                Contrasenia=TxtContraseniaUsuario.Text,
                Estado = 1,
                FechaRegistro = DateTime.Now
            };

            string mensaje = nUsuario.Registrar(usuario);
            MessageBox.Show(mensaje);

            MostrarUsuarios(nUsuario.ListarUsuarios());
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (DgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Usuario");
                return;
            }
            if (TxtNombreUsuario.Text == "" || TxtCodigoUsuario.Text == "" || TxtEmailUsuario.Text == "" || CbRolUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            Usuario usuario = new Usuario()
            {
                Codigo = TxtCodigoUsuario.Text,
                Nombre = TxtNombreUsuario.Text,
                Email = TxtEmailUsuario.Text,
                RolId = Convert.ToInt32(CbRolUsuario.SelectedValue),
                FechaModificacion= DateTime.Now,
            };
            String mensaje = nUsuario.Modificar(usuario);
            MessageBox.Show(mensaje);

            MostrarUsuarios(nUsuario.ListarUsuarios());

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (DgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.No)
                return;

            string codigoUsuario = DgvUsuarios.SelectedRows[0].Cells["Codigo"].Value.ToString();

            string mensaje = nUsuario.EliminarLogico(codigoUsuario);
            MessageBox.Show(mensaje);

            MostrarUsuarios(nUsuario.ListarUsuarios());

            BtnLimpiarUsuario_Click(null, null);
        }

        private void BtnLimpiarUsuario_Click(object sender, EventArgs e)
        {
            TxtCodigoUsuario.Text = "";
            TxtNombreUsuario.Text = "";
            TxtEmailUsuario.Text = "";
            CbRolUsuario.SelectedIndex = -1; 

            TxtCodigoUsuario.Enabled = true; 

            TxtBuscarNombreUsuario.Text = "Buscar por nombre...";
            chkUsuarios.Checked = false;
            TxtCodigoUsuario.Focus();
        }
    }
}
