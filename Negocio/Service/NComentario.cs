using Datos;
using Datos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class NComentario
    {
        private DComentario dComentario = new DComentario();

        public string Registrar(Comentario comentario)
        {
            return dComentario.Registrar(comentario);
        }

        public List<Comentario> ListarPorItem(int itemId)
        {
            return dComentario.ListarPorItem(itemId);
        }
    }
}
