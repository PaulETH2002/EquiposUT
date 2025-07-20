using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposUT.Data.Models
{
    public class Horario
    {
        public int Id { get; set; }

        public int MateriaId { get; set; }
        public Materia Materia { get; set; }

        public string Dia { get; set; } // Lunes, Martes, etc.
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
    }
}
