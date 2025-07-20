using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposUT.Data.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; } // Estudiante, Maestro, Admin

        public ICollection<Entrega> Entregas { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
    }
}
