using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposUT.Data.Models
{
    public class Entrega
    {
        public int Id { get; set; }

        public int EstudianteId { get; set; }
        public Usuario Estudiante { get; set; }

        public int MateriaId { get; set; }
        public Materia Materia { get; set; }

        public string NombreArchivo { get; set; }
        public string RutaArchivo { get; set; }
        public DateTime FechaEntrega { get; set; }

        public Calificacion Calificacion { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
    }
}
