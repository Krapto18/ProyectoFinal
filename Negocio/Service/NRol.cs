using Datos.Entity;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class NRol
    {
        private DRol dRol = new DRol();
        public List<Rol> ListarRoles()
        {
            return dRol.ListarRoles();
        }
        public List<Rol> ListarRolesActivos() { 
            return dRol.ListarRoles().Where(u=>u.Estado.Equals(1)).ToList();
        }
        public String Registrar(Rol rol)
        {
            if (dRol.ExisteRol(rol.Codigo)) return "Código repetido. Ingrese uno nuevo.";
            else return dRol.Registrar(rol);
        }
        public String Modificar(Rol rol)
        {
            return dRol.Modificar(rol);
        }
        public String EliminarFisico(string codigoRol)
        {
            if (!dRol.ExisteRol(codigoRol)) return "Código  no encontrado. Ingrese uno válido.";
            else return dRol.EliminarFisico(codigoRol);
        }
        public String EliminarLogico(string codigoRol)
        {
            if (!dRol.ExisteRol(codigoRol)) return "Código  no encontrado. Ingrese uno válido.";
            else return dRol.EliminarLogico(codigoRol);
        }

    }
}
