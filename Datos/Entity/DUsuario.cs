using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data.Entity;

namespace Datos.Entity
{
    public class DUsuario
    {
        public String Registrar(Usuario usuario) {
			try
			{
				using (var context = new BDFEntities())
				{
					context.Usuario.Add(usuario);
					context.SaveChanges();
				}
				return "Registrado correctamente";
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
        }
		public String Modificar(Usuario usuario) {
            if (string.IsNullOrWhiteSpace(usuario.Codigo))
                return "Código de usuario inválido.";
            try
			{
				using (var context = new BDFEntities())
				{
                    Usuario usuarioTemp = context.Usuario.FirstOrDefault(u => u.Codigo.Equals(usuario.Codigo));
                    if (usuarioTemp == null)
                    {
                        return "El usuario no fue encontrado para modificar.";
                    }
                    usuarioTemp.Nombre = usuario.Nombre;
					usuarioTemp.Email= usuario.Email;
					usuarioTemp.RolId= usuario.RolId;
					usuarioTemp.FechaModificacion = usuario.FechaModificacion;
					context.SaveChanges();
                }
				return "Modificado correctamente";
			}
			catch (Exception ex)
			{
				
				return ex.Message;
			}
		}
		public String EliminarFisico(string codigoUsuario) {
			try
			{
				using (var context = new BDFEntities()) {
					Usuario usuarioTemp = context.Usuario.FirstOrDefault(u=>u.Codigo.Equals(codigoUsuario));
					context.Usuario.Remove(usuarioTemp);
					context.SaveChanges();
				}
				return "Usuario eliminado físicamente";
			}
			catch (Exception ex)
			{
				return ex.Message;	
			}		
		}
        public String EliminarLogico(string codigoUsuario)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Usuario usuarioTemp = context.Usuario.FirstOrDefault(u => u.Codigo.Equals(codigoUsuario));
                    usuarioTemp.Estado = 0;
                    context.SaveChanges();
                }
                return "Usuario eliminado lógicamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
		public List<Usuario> ListarUsuarios() {
			List<Usuario> usuarios = new List<Usuario>();
			try
			{
				using (var context = new BDFEntities())
				{
					return context.Usuario.Include(u=>u.Rol).ToList();
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
		public bool ExisteUsuario(string codigoUsuario) {
			try
			{
				using (var context = new BDFEntities())
				{
					return context.Usuario.Any(u => u.Codigo.Equals(codigoUsuario));

				}
			}
			catch (Exception)
			{

				throw;
			}
		}
        public Usuario IniciarSesion(string nombreUsuarioOCorreo, string contrasenia)
        {
            using (var context = new BDFEntities())
            {
                return context.Usuario
                    .Include("Rol")
                    .FirstOrDefault(u =>
                        (u.NombreUsuario == nombreUsuarioOCorreo || u.Email == nombreUsuarioOCorreo) &&
                        u.Contrasenia == contrasenia &&
                        u.Estado == 1);
            }
        }
    }
}
