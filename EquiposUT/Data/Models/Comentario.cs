using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposUT.Data.Models
{
    public class Comentario
    {
        public int Id { get; set; }

        public int EntregaId { get; set; }
        public Entrega Entrega { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public string Texto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
