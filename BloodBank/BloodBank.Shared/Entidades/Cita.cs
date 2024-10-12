using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BloodBank.Shared.Entidades
{
    public class Cita
    {
        public int Id { get; set; }

        [Display(Name = "Fecha de cita")]
        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Hora")]
        [Required(ErrorMessage = "La hora es obligatoria.")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Hora { get; set; }

        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "La cantidad de sangre es obligatoria.")]
        public int Cantidad { get; set; }

        [JsonIgnore]
        public Donante Donantes { get; set; }
        public int DonanteId { get; set; }

        [JsonIgnore]
        public Enfermero Enfermeros { get; set; }
        public int EnfermeroId { get; set; }

    }
}
