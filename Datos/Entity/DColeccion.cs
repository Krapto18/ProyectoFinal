using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entity
{
    public class DColeccion
    {
        public String Registrar(Coleccion coleccion)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    context.Coleccion.Add(coleccion);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Modificar(Coleccion coleccion)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Coleccion coleccionTemp = context.Coleccion.Find(coleccion.Codigo);
                    coleccionTemp.Nombre = coleccion.Nombre;
                    coleccionTemp.Descripcion = coleccion.Descripcion;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public String EliminarFisico(int codigoColeccion)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Coleccion coleccionTemp = context.Coleccion.Find(codigoColeccion);
                    context.Coleccion.Remove(coleccionTemp);
                    context.SaveChanges();
                }
                return "Colección eliminada físicamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String EliminarLogico(int codigoColeccion)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Coleccion coleccionTemp = context.Coleccion.Find(codigoColeccion);
                    coleccionTemp.Estado = 0;
                    context.SaveChanges();
                }
                return "Colección eliminada lógicamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Coleccion> ListarColecciones()
        {
            List<Coleccion> colecciones = new List<Coleccion>();
            try
            {
                using (var context = new BDFEntities())
                {
                    colecciones = context.Coleccion.ToList();
                }
                return colecciones;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
