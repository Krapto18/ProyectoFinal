using Datos;
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
    public partial class FrmPrincipal : Form
    {
        private Usuario usuarioLogueado;
        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioLogueado = usuario;
            ConfigurarMenuPorRol();

            // Si quieres mostrar el nombre por ejemplo
            LblUsuario.Text = $"{usuarioLogueado.NombreUsuario}";
            LblRol.Text = $"{usuarioLogueado.Rol.Nombre}";
        }
        private void ConfigurarMenuPorRol()
        {
            // Ejemplo: ocultar el menú de mantenimiento si no es administrador
            mnuMantenimiento.Visible = false; // <- usa el nombre exacto del ToolStripMenuItem

            if (usuarioLogueado?.Rol?.Nombre == "Administrador")
            {
                mnuMantenimiento.Visible = true;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRol frm = new FrmRol();
            frm.Show();
        }

        private void BibliotecaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void plataformasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlataforma frm = new FrmPlataforma();
            frm.Show();
        }

        private void misColeccionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmColeccion frm = new FrmColeccion(usuarioLogueado);
            frm.Show();
        }

        private void misItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItem frm = new FrmItem();
            frm.Show();
        }
    }
}
