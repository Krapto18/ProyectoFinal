using Datos.Entity;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class NIntercambio
    {
        private DIntercambio dIntercambio = new DIntercambio();

        public string Registrar(Intercambio intercambio)
        {
            return dIntercambio.Registrar(intercambio);
        }

        public List<Intercambio> Listar()
        {
            return dIntercambio.Listar();
        }
    }
}
