using Datos.Entity;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class NJuegoPlataforma
    {
        private DJuegoPlataforma dJP = new DJuegoPlataforma();

        public string AsignarPlataformas(string codigoItem, List<int> plataformaIds)
        {
            return dJP.AsignarPlataformas(codigoItem, plataformaIds);
        }

        public List<Plataforma> ListarPlataformasPorItem(string codigoItem)
        {
            return dJP.ListarPlataformasPorItem(codigoItem);
        }
    }
}
