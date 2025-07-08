using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Datos.Entity
{
    public class DCalificacion
    {
        public string Registrar(Calificacion calificacion)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    context.Calificacion.Add(calificacion);
                    context.SaveChanges();
                }
                return "Calificación registrada";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Calificacion> ListarPorItem(int itemId)
        {
            using (var context = new BDFEntities())
            {
                return context.Calificacion
                    .Include(c => c.Usuario)
                    .Where(c => c.ItemId == itemId && c.Estado == 1)
                    .ToList();
            }
        }
    }
}
