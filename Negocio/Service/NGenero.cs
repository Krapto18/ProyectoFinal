using Datos.Entity;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class NGenero
    {
        private DGenero dGenero = new DGenero();

        public string Registrar(Genero genero)
        {
            if (dGenero.ExisteGenero(genero.Codigo)) return "Código de género ya existe. Ingrese uno nuevo.";
            else return dGenero.Registrar(genero);
        }

        public string Modificar(Genero genero)
        {
            return dGenero.Modificar(genero);
        }

        public string EliminarLogico(string codigoGenero)
        {
            if (!dGenero.ExisteGenero(codigoGenero)) return "Género no encontrado. Ingrese un código válido.";
            else return dGenero.EliminarLogico(codigoGenero);
        }

        public List<Genero> ListarGeneros()
        {
            return dGenero.ListarGeneros();
        }
    }
}

