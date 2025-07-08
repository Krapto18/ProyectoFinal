using Datos.Entity;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class NPlataforma
    {
        private DPlataforma dPlataforma = new DPlataforma();

        public string Registrar(Plataforma plataforma)
        {
            if (dPlataforma.ExistePlataforma(plataforma.Codigo)) return "Código de plataforma ya existe. Ingrese uno nuevo.";
            else return dPlataforma.Registrar(plataforma);
        }

        public string Modificar(Plataforma plataforma)
        {
            return dPlataforma.Modificar(plataforma);
        }

        public string EliminarLogico(string codigoPlataforma)
        {
            if (!dPlataforma.ExistePlataforma(codigoPlataforma)) return "Plataforma no encontrada. Ingrese un código válido.";
            else return dPlataforma.EliminarLogico(codigoPlataforma);
        }

        public List<Plataforma> ListarPlataformas()
        {
            return dPlataforma.ListarPlataformas();
        }
    }
}

