using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entity
{
    public class DRol
    {
        public String Registrar(Rol rol)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    context.Rol.Add(rol);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Modificar(Rol rol)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Rol rolTemp = context.Rol.Find(rol.Codigo);
                    rolTemp.Nombre = rol.Nombre;
                    rolTemp.Descripcion = rol.Descripcion;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public String EliminarFisico(int codigoRol)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Rol rolTemp = context.Rol.Find(codigoRol);
                    context.Rol.Remove(rolTemp);
                    context.SaveChanges();
                }
                return "Rol eliminado físicamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String EliminarLogico(int codigoRol)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Rol rolTemp = context.Rol.Find(codigoRol);
                    rolTemp.Estado = 0;
                    context.SaveChanges();
                }
                return "Rol eliminado lógicamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Rol> ListarRoles()
        {
            List<Rol> roles = new List<Rol>();
            try
            {
                using (var context = new BDFEntities())
                {
                    roles = context.Rol.ToList();
                }
                return roles;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
