using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BloodBank.Shared.Entidades
{
    public class Donacion
    {
        public int Id { get; set; }
        [Display(Name = "Observaciones y/o comentarios")]
        [DataType(DataType.MultilineText)]
        public string Observacion { get; set; }

        

        [JsonIgnore]
        public Inventario Inventarios { get; set; }
        public int InventarioId { get; set; }

        [JsonIgnore]
        public Cita Citas { get; set; }
        public int CitaId { get; set; }
    }
}
