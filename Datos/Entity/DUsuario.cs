using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
