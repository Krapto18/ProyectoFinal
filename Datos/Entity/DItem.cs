using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entity
{
    public class DItem
    {
        public String Registrar(Item item)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    context.Item.Add(item);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Modificar(Item item)
        {
            if (string.IsNullOrWhiteSpace(item.Codigo))
                return "Código de item inválido.";
            try
            {
                using (var context = new BDFEntities())
                {
                    Item itemTemp = context.Item.FirstOrDefault(i => i.Codigo.Equals(item.Codigo));
                    if (itemTemp == null)
                    {
                        return "El item no fue encontrado para modificar.";
                    }
                    itemTemp.Titulo = item.Titulo;
                    itemTemp.Tipo = item.Tipo;
                    itemTemp.Anio = item.Anio;
                    itemTemp.Genero = item.Genero;
                    itemTemp.ColeccionId = item.ColeccionId;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public String EliminarFisico(string codigoItem)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Item itemTemp = context.Item.FirstOrDefault(i => i.Codigo.Equals(codigoItem));
                    context.Item.Remove(itemTemp);
                    context.SaveChanges();
                }
                return "Item eliminado físicamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String EliminarLogico(string codigoItem)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Item itemTemp = context.Item.FirstOrDefault(i => i.Codigo.Equals(codigoItem));
                    itemTemp.Estado = 0;
                    context.SaveChanges();
                }
                return "Item eliminado lógicamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //public List<Item> ListarItems()
        //{
        //    List<Item> items = new List<Item>();
        //    try
        //    {
        //        using (var context = new BDFEntities())
        //        {
        //            return context.Item.Include(i => i.Coleccion).ToList();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        public bool ExisteItem(string codigoItem)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    return context.Item.Any(u => u.Codigo.Equals(codigoItem));

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
