﻿using Datos;
using Datos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class NUsuario
    {
        private DUsuario dUsuario = new DUsuario();
        public String Registrar(Usuario usuario) {
            if (dUsuario.ExisteUsuario(usuario.Codigo)) return "Código repetido. Ingrese uno nuevo.";
            else return dUsuario.Registrar(usuario);
        }
        public String Modificar(Usuario usuario)
        {
           return dUsuario.Modificar(usuario);
        }
        public String EliminarFisico(string codigoUsuario)
        {
            if (!dUsuario.ExisteUsuario(codigoUsuario)) return "Código  no encontrado. Ingrese uno válido.";
            else return dUsuario.EliminarFisico(codigoUsuario);
        }
        public String EliminarLogico(string codigoUsuario)
        {
            if (!dUsuario.ExisteUsuario(codigoUsuario)) return "Código  no encontrado. Ingrese uno válido.";
            else return dUsuario.EliminarLogico(codigoUsuario);
        }
        public List<Usuario> ListarUsuarios()
        {
            return dUsuario.ListarUsuarios();
        }
        public List<Usuario> ListarUsuariosActivos() {
            return dUsuario.ListarUsuarios().Where(u => u.Estado.Equals(1)).ToList();
        }
        public Usuario IniciarSesion(string nombreUsuarioOCorreo, string contrasenia)
        {
            DUsuario dUsuario = new DUsuario();
            Usuario usuario = dUsuario.IniciarSesion(nombreUsuarioOCorreo, contrasenia);

            if (usuario == null)
                throw new Exception("Usuario o contraseña incorrectas");

            return usuario;
        }
    }
}
