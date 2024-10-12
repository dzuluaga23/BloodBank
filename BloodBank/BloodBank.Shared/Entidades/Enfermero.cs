using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BloodBank.Shared.Entidades
{
    public class Enfermero
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

        [Display(Name = "Correo Electrónico")]
        [MaxLength(50, ErrorMessage = "El correo no puede tener más de 50 caracteres.")]
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del correo no es válido.")]
        public string Correo { get; set; }

        [JsonIgnore]
        public Hospital Hospitales { get; set; }
        public int HospitalId { get; set; }
    }
}
