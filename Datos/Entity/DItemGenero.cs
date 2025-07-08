using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entity
{
    public class DItemGenero
    {
        public string AsignarGeneros(string codigoItem, List<int> generoIds)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    var item = context.Item.FirstOrDefault(i => i.Codigo == codigoItem);
                    if (item == null) return "Item no encontrado";

                    // Eliminar relaciones actuales
                    var actuales = context.Item_Genero.Where(ig => ig.ItemId == item.Id).ToList();
                    context.Item_Genero.RemoveRange(actuales);

                    // Agregar nuevas relaciones
                    foreach (var generoId in generoIds)
                    {
                        context.Item_Genero.Add(new Item_Genero
                        {
                            ItemId = item.Id,
                            GeneroId = generoId,
                            Estado = 1
                        });
                    }

                    context.SaveChanges();
                    return "Géneros actualizados";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Genero> ListarGenerosPorItem(string codigoItem)
        {
            using (var context = new BDFEntities())
            {
                return (from ig in context.Item_Genero
                        join g in context.Genero on ig.GeneroId equals g.Id
                        join i in context.Item on ig.ItemId equals i.Id
                        where i.Codigo == codigoItem && ig.Estado == 1
                        select g).ToList();
            }
        }
    }
}
