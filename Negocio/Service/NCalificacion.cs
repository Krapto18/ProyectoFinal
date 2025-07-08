using Datos.Entity;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class NCalificacion
    {
        private DCalificacion dCalificacion = new DCalificacion();

        public string Registrar(Calificacion calificacion)
        {
            return dCalificacion.Registrar(calificacion);
        }

        public List<Calificacion> ListarPorItem(int itemId)
        {
            return dCalificacion.ListarPorItem(itemId);
        }
    }
}
