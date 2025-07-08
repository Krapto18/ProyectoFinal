using Datos.Entity;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class NItemGenero
    {
        private DItemGenero dItemGenero = new DItemGenero();

        public string AsignarGeneros(string codigoItem, List<int> generoIds)
        {
            return dItemGenero.AsignarGeneros(codigoItem, generoIds);
        }

        public List<Genero> ListarGenerosPorItem(string codigoItem)
        {
            return dItemGenero.ListarGenerosPorItem(codigoItem);
        }
    }
}
