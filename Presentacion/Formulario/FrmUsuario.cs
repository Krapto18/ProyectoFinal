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
        }
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
                Rol = u.Rol != null ? u.Rol.Nombre : "Sin rol",
                Estado = u.Estado == 1 ? "Activo" : "Inactivo"
            }).ToList();

            DgvUsuarios.DataSource = datosLimpiados;
        }
        private void CargarRoles()
        {
            var roles = nRol.ListarRolesActivos();
            CbRolUsuario.DataSource = roles;
            CbRolUsuario.DisplayMember = "Nombre";
            CbRolUsuario.ValueMember = "Id";
            CbRolUsuario.SelectedIndex = -1;
        }
        private void TxtBuscarNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            string filtro = TxtBuscarNombreUsuario.Text.ToLower();
            DgvUsuarios.DataSource = nUsuario.ListarUsuarios().Where(u =>
                u.Nombre.ToLower().Contains(filtro) 
            ).ToList();
        }

        private void DgvUsuarios_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Evita que la app se cierre si hay error al mostrar datos
            e.ThrowException = false;

            // Opcional: muestra un mensaje si quieres saber qué pasó
            Console.WriteLine($"Error en celda [{e.RowIndex}, {e.ColumnIndex}]: {e.Exception.Message}");
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
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
                Estado = 1
            };

            string mensaje = nUsuario.Registrar(usuario);
            MessageBox.Show(mensaje);

            MostrarUsuarios(nUsuario.ListarUsuarios());
        }
    }
}
