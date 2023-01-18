using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEFEscuela.Models
{

    [Table("Profesor")]
    public class Profesor
    {

        public int ProfesorId { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }


        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Titulo { get; set; }

        public List<Alumno> Alumnos { get; set; }

    }
}
