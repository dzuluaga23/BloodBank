using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Shared.Entidades
{
    public class Inventario
    {
        public int Id { get; set; }
        [Display(Name = "Código")]
        [Range(0, 9999, ErrorMessage = "El código de sangre debe tener entre 1 y 4 dígitos.")]
        [Required(ErrorMessage = "El código es obligatorio.")]
        public int Codigo { get; set; }

        [Display(Name = "Tipo de sangre")]
        [MaxLength(3, ErrorMessage = "El tipo de sangre no puede tener más de 3 caracteres.")]
        [Required(ErrorMessage = "El tipo de sangre es obligatorio")]
        public string Tipo { get; set; }

        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "La cantidad de sangre es obligatoria.")]
        public int Cantidad { get; set; }

    }
}
