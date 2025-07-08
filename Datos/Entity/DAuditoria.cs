using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entity
{
    public class DAuditoria
    {
        public void Registrar(string tabla, string codigoRegistro, string accion, int? usuarioId, string valoresAntiguos = null, string valoresNuevos = null)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    var auditoria = new Auditoria
                    {
                        Tabla = tabla,
                        CodigoRegistro = codigoRegistro,
                        Accion = accion,
                        UsuarioId = usuarioId,
                        ValoresAntiguos = valoresAntiguos,
                        ValoresNuevos = valoresNuevos,
                        Fecha = DateTime.Now
                    };

                    context.Auditoria.Add(auditoria);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                // log opcional
            }
        }
    }
}
