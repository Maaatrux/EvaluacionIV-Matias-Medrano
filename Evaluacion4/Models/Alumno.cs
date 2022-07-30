using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluacion4.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
