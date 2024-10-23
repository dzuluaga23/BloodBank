using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BloodBank.Shared.Entidades
{
    public class Donante
    {
        public int Id { get; set; }
        [Display(Name = "Documento")]
        [MaxLength(10, ErrorMessage = "El documento no puede tener más de 10 caracteres.")]
        [Required(ErrorMessage = "El Documento es obligatorio")]
        public string Documento { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido")]
        [MaxLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres.")]
        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public string Apellido { get; set; }

        [Display(Name = "Foto del donante")]
        public string Imagen { get; set; }

        [Display(Name = "Correo Electrónico")]
        [MaxLength(50, ErrorMessage = "El correo no puede tener más de 50 caracteres.")]
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del correo no es válido.")]
        public string Correo { get; set; }

        [Display(Name = "Tipo de sangre")]
        [MaxLength(3, ErrorMessage = "El tipo de sangre no puede tener más de 3 caracteres.")]
        [Required(ErrorMessage = "El tipo de sangre es obligatorio")]
        public string Sangre { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Teléfono móvil")]
        [MaxLength(10, ErrorMessage = "El telefono no puede tener más de 10 caracteres.")]
        public string Telefono { get; set; }

        
    }
}
