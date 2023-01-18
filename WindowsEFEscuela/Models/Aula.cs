using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEFEscuela.Models
{
    [Table("Aula")]
    public class Aula
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public int Capacidad { get; set; }

        [Required]
        [Column(TypeName = "char")]
        [StringLength(1)]
        public string Codigo { get; set; }
    }
}
