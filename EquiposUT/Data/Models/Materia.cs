using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposUT.Data.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }

        public int MaestroId { get; set; }
        public Usuario Maestro { get; set; }
    }
}
