using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Datos.Entity
{
    public class DItem
    {
        public string Registrar(Item item)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    item.Estado = 1;
                    context.Item.Add(item);
                    context.SaveChanges();
                    return "Item registrado correctamente";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(Item item)
        {
            if (string.IsNullOrWhiteSpace(item.Codigo))
                return "Código del item inválido.";

            try
            {
                using (var context = new BDFEntities())
                {
                    var itemTemp = context.Item.FirstOrDefault(i => i.Codigo.Equals(item.Codigo));
                    if (itemTemp == null)
                        return "El item no fue encontrado.";

                    itemTemp.Titulo = item.Titulo;
                    itemTemp.Tipo = item.Tipo;
                    itemTemp.Anio = item.Anio;
                    itemTemp.GeneroId = item.GeneroId;
                    itemTemp.ColeccionId = item.ColeccionId;

                    context.SaveChanges();
                    return "Item modificado correctamente";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarLogico(string codigo)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    var item = context.Item.FirstOrDefault(i => i.Codigo.Equals(codigo));
                    if (item == null)
                        return "Item no encontrado.";

                    item.Estado = 0;
                    context.SaveChanges();
                    return "Item eliminado lógicamente";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Item> ListarItems()
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    return context.Item
                        .Include(i => i.Coleccion)
                        .Where(i => i.Estado == 1)
                        .ToList();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Item> ListarPorColeccion(int coleccionId)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    return context.Item
                        .Include(i => i.Coleccion)
                        .Include(i => i.Genero1)
                        .Where(i => i.ColeccionId == coleccionId && i.Estado == 1)
                        .ToList();
                }
            }
            catch
            {
                throw;
            }
        }

        public bool ExisteItem(string codigo)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    return context.Item.Any(i => i.Codigo.Equals(codigo));
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
