using System.ComponentModel.DataAnnotations;

namespace TallerMecanico.Models
{
    public class PersonaModel
    {
        public int IdPersona { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Identificacion { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Apellido { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Nacimiento { get; set; }

    }
}
