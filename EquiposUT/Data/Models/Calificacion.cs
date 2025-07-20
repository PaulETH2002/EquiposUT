using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposUT.Data.Models
{
    public class Calificacion
    {
        public int Id { get; set; }

        public int EntregaId { get; set; }
        public Entrega Entrega { get; set; }

        public int MaestroId { get; set; }
        public Usuario Maestro { get; set; }

        public double Nota { get; set; }
        public string Comentario { get; set; }
    }
}
