using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Datos.Entity
{
    public class DComentario
    {
        public string Registrar(Comentario comentario)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    context.Comentario.Add(comentario);
                    context.SaveChanges();
                }
                return "Comentario registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Comentario> ListarPorItem(int itemId)
        {
            using (var context = new BDFEntities())
            {
                return context.Comentario
                    .Include(c => c.Usuario)
                    .Where(c => c.ItemId == itemId && c.Estado == 1)
                    .ToList();
            }
        }
    }
}
