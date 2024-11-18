using System.ComponentModel.DataAnnotations;

namespace WebApiFinal2024II.Dal.Entities
{
    public class Libros : AuditBase
    {
        [Display(Name = "Título")] //Para identificar el nombre de la propiedad mas fácil
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")] //Longitud max
        [Required(ErrorMessage = "Es campo {0} obligatorio")] //Campo obligatoria
        public string titulo { get; set; }
        public string autor { get; set; }

        [Display(Name = "Género")]
        public string genero { get; set; }
    }
}
