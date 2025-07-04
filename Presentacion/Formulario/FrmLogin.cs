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
    public partial class FrmLogin : Form
    {
        private NUsuario nUsuario = new NUsuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string input = TxtUsuarioLogin.Text.Trim();
                string contrasenia = TxtContrasenia.Text;

                Usuario usuario = nUsuario.IniciarSesion(input, contrasenia);

                MessageBox.Show($"Bienvenido {usuario.Nombre} ({usuario.Rol.Nombre})");

                // Aquí podrías abrir el formulario principal según el rol
                this.Hide();
                new FrmPrincipal(usuario).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
