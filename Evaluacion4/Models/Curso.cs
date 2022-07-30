using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluacion4.Models
{
    [Table("Curso")]
    public class Curso
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int NroSala { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool? Activo { get; set; }
        public virtual ICollection<Alumno> Alumnos { get; set; }
    }
}
