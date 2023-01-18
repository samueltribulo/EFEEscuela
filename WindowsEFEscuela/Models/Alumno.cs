using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEFEscuela.Models
{
    [Table("Alumno")]
    public class Alumno
    {

        [Key]
        public int IdAlumno { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public int Profesor_Id { get; set; }

        [ForeignKey("Profesor_Id")]
        public Profesor Profesor { get; set; }


    }
}
