using Datos.Entity;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class NItem
    {
        private DItem dItem = new DItem();

        public string Registrar(Item item)
        {
            if (dItem.ExisteItem(item.Codigo))
                return "Código repetido. Ingrese uno nuevo.";
            return dItem.Registrar(item);
        }

        public string Modificar(Item item)
        {
            if (!dItem.ExisteItem(item.Codigo))
                return "Código no encontrado. Ingrese uno válido.";
            return dItem.Modificar(item);
        }

        public string EliminarLogico(string codigo)
        {
            if (!dItem.ExisteItem(codigo))
                return "Código no encontrado. Ingrese uno válido.";
            return dItem.EliminarLogico(codigo);
        }

        public List<Item> ListarItems()
        {
            return dItem.ListarItems();
        }

        public List<Item> ListarPorColeccion(int coleccionId)
        {
            return dItem.ListarPorColeccion(coleccionId);
        }
    }
}
