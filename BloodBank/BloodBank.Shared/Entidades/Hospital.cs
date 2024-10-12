using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BloodBank.Shared.Entidades
{
    public class Hospital
    {
        public int Id { get; set; }
        [Display(Name = "Nombre Hospital")]
        [MaxLength(50, ErrorMessage = "El nombre del hospital no puede tener más de 50 caracteres.")]
        [Required(ErrorMessage = "El nombre del hospital es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Dirección Hospital")]
        [MaxLength(50, ErrorMessage = "La direccion del hospital no puede tener más de 50 caracteres.")]
        [Required(ErrorMessage = "La dirección del hospital es obligatoria")]
        public string Direccion { get; set; }

        [Display(Name = "Telefono")]
        [MaxLength(10, ErrorMessage = "El telefono del hospital no puede tener más de 10 caracteres.")]
        [Required(ErrorMessage = "El telefono del hospital es obligatorio")]
        public string Telefono { get; set; }

        [JsonIgnore]
        public Inventario Inventarios { get; set; }
        public int InventarioId { get; set; }
    }
}
