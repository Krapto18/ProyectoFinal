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
    }
}
