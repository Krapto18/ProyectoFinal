using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
			try
			{
				using (var context = new BDFEntities())
				{
					Usuario usuarioTemp= context.Usuario.Find(usuario.Codigo);
					usuarioTemp.Nombre = usuario.Nombre;
					usuarioTemp.Email= usuario.Email;
					usuarioTemp.RolId= usuario.RolId;
					context.SaveChanges();
                }
				return "Modificado correctamente";
			}
			catch (Exception ex)
			{
				
				return ex.Message;
			}
		}
		public String EliminarFisico(int codigoUsuario) {
			try
			{
				using (var context = new BDFEntities()) {
					Usuario usuarioTemp = context.Usuario.Find(codigoUsuario);
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
        public String EliminarLogico(int codigoUsuario)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Usuario usuarioTemp = context.Usuario.Find(codigoUsuario);
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
					usuarios = context.Usuario.ToList();
				}
				return usuarios;
			}
			catch (Exception)
			{

				throw;
			}
		}
    }
}
