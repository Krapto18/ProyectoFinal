using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Datos.Entity
{
    public class DIntercambio
    {
        public string Registrar(Intercambio intercambio)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    context.Intercambio.Add(intercambio);
                    context.SaveChanges();
                }
                return "Intercambio registrado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Intercambio> Listar()
        {
            using (var context = new BDFEntities())
            {
                return context.Intercambio
                    .Include(i => i.UsuarioOfreceId)
                    .Include(i => i.UsuarioSolicitaId)
                    .Include(i => i.ItemOfrecidoId)
                    .Include(i => i.ItemSolicitadoId)
                    .Where(i => i.Estado == 1)
                    .ToList();
            }
        }
    }
}
