using Datos.Entity;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class NColeccion
    {
        private DColeccion dColeccion = new DColeccion();

        public string Registrar(Coleccion coleccion)
        {
            if (dColeccion.ExisteColeccion(coleccion.Codigo))
                return "Código de colección repetido. Ingrese uno nuevo.";
            return dColeccion.Registrar(coleccion);
        }

        public string Modificar(Coleccion coleccion)
        {
            return dColeccion.Modificar(coleccion);
        }

        public string EliminarFisico(string codigo)
        {
            if (!dColeccion.ExisteColeccion(codigo))
                return "Código no encontrado. Ingrese uno válido.";
            return dColeccion.EliminarFisico(codigo);
        }

        public string EliminarLogico(string codigo)
        {
            if (!dColeccion.ExisteColeccion(codigo))
                return "Código no encontrado. Ingrese uno válido.";
            return dColeccion.EliminarLogico(codigo);
        }

        public List<Coleccion> Listar()
        {
            return dColeccion.ListarColecciones();
        }

        public List<Coleccion> ListarActivas()
        {
            return dColeccion.ListarColecciones().Where(c => c.Estado == 1).ToList();
        }
    }
}
