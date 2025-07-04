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

            // Si quieres mostrar el nombre por ejemplo
            LblUsuario.Text = $"{usuarioLogueado.NombreUsuario}";
            LblRol.Text = $"{usuarioLogueado.Rol.Nombre}";
        }

    }
}
