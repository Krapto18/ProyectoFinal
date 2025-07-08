using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entity
{
    public class DGenero
    {
        public string Registrar(Genero genero)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    genero.Estado = 1;
                    context.Genero.Add(genero);
                    context.SaveChanges();
                }
                return "Género registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(Genero genero)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    var temp = context.Genero.FirstOrDefault(g => g.Codigo == genero.Codigo);
                    if (temp == null) return "Género no encontrado.";
                    temp.Nombre = genero.Nombre;
                    context.SaveChanges();
                }
                return "Género modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarLogico(string codigoGenero)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    var temp = context.Genero.FirstOrDefault(g => g.Codigo == codigoGenero);
                    if (temp == null) return "Género no encontrado.";
                    temp.Estado = 0;
                    context.SaveChanges();
                }
                return "Género eliminado lógicamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ExisteGenero(string codigoGenero)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    return context.Genero.Any(g => g.Codigo == codigoGenero);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Genero> ListarGeneros()
        {
            List<Genero> generos = new List<Genero>();
            try
            {
                using (var context = new BDFEntities())
                {
                    generos = context.Genero.ToList();
                }
                return generos;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
