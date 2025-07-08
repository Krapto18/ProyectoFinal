using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entity
{
    public class DPlataforma
    {
        public String Registrar(Plataforma plataforma)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    context.Plataforma.Add(plataforma);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Modificar(Plataforma plataforma)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Plataforma plataformaTemp = context.Plataforma.FirstOrDefault(p => p.Codigo.Equals(plataforma.Codigo));
                    plataformaTemp.Nombre = plataforma.Nombre;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public String EliminarFisico(string codigoPlataforma)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Plataforma plataformaTemp = context.Plataforma.FirstOrDefault(p => p.Codigo.Equals(codigoPlataforma));
                    context.Plataforma.Remove(plataformaTemp);
                    context.SaveChanges();
                }
                return "Plataforma eliminada físicamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String EliminarLogico(string codigoPlataforma)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Plataforma plataformaTemp = context.Plataforma.FirstOrDefault(p=>p.Codigo.Equals(codigoPlataforma));
                    plataformaTemp.Estado = 0;
                    context.SaveChanges();
                }
                return "Plataforma eliminada lógicamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Plataforma> ListarPlataformas()
        {
            List<Plataforma> plataformas = new List<Plataforma>();
            try
            {
                using (var context = new BDFEntities())
                {
                    plataformas = context.Plataforma.ToList();
                }
                return plataformas;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool ExistePlataforma(string codigoPlataforma)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    return context.Plataforma.Any(p => p.Codigo.Equals(codigoPlataforma));

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
