using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposUT.Data.Models
{
    public class Tetramestre
    {
        public int Id { get; set; }
        public int Numero { get; set; }

        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }
    }
}
