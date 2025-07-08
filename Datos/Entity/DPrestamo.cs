using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Datos.Entity
{
    public class DPrestamo
    {
        public string Registrar(Prestamo prestamo)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    context.Prestamo.Add(prestamo);
                    context.SaveChanges();
                }
                return "Prestamo registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarLogico(string codigo)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    var temp = context.Prestamo.FirstOrDefault(p => p.Codigo == codigo);
                    if (temp == null) return "No encontrado";
                    temp.Estado = 0;
                    context.SaveChanges();
                    return "Eliminado correctamente";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Prestamo> Listar() => new BDFEntities().Prestamo.Include(p => p.Usuario).Include(p => p.Item).ToList();
    }
}
