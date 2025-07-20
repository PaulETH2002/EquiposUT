using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposUT.Data.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int SemestreId { get; set; }
        public Tetramestre Tetramestre { get; set; }
    }
}
