using Datos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class NAuditoria
    {
        private DAuditoria dAuditoria = new DAuditoria();

        public void Registrar(string tabla, string codigoRegistro, string accion, int? usuarioId, string valoresAntiguos = null, string valoresNuevos = null)
        {
            dAuditoria.Registrar(tabla, codigoRegistro, accion, usuarioId, valoresAntiguos, valoresNuevos);
        }
    }
}
