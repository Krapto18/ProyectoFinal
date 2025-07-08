using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entity
{
    public class DJuegoPlataforma
    {
        public string AsignarPlataformas(string codigoItem, List<int> plataformaIds)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    var item = context.Item.FirstOrDefault(i => i.Codigo == codigoItem);
                    if (item == null) return "Item no encontrado";

                    // Eliminar relaciones actuales
                    var actuales = context.Juego_Plataforma.Where(jp => jp.JuegoId == item.Id).ToList();
                    context.Juego_Plataforma.RemoveRange(actuales);

                    // Agregar nuevas relaciones
                    foreach (var plataformaId in plataformaIds)
                    {
                        context.Juego_Plataforma.Add(new Juego_Plataforma
                        {
                            JuegoId = item.Id,
                            PlataformaId = plataformaId,
                            Estado = 1
                        });
                    }

                    context.SaveChanges();
                    return "Plataformas actualizadas";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Plataforma> ListarPlataformasPorItem(string codigoItem)
        {
            using (var context = new BDFEntities())
            {
                return (from jp in context.Juego_Plataforma
                        join p in context.Plataforma on jp.PlataformaId equals p.Id
                        join i in context.Item on jp.JuegoId equals i.Id
                        where i.Codigo == codigoItem && jp.Estado == 1
                        select p).ToList();
            }
        }
    }
}
