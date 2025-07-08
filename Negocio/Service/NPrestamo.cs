using Datos.Entity;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class NPrestamo
    {
        private DPrestamo dPrestamo = new DPrestamo();

        public string Registrar(Prestamo prestamo)
        {
            return dPrestamo.Registrar(prestamo);
        }

        public string EliminarLogico(string codigo)
        {
            return dPrestamo.EliminarLogico(codigo);
        }

        public List<Prestamo> Listar()
        {
            return dPrestamo.Listar();
        }
    }
}
