using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Agencia_De_Viajes_Proyecto.Models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string HotelNombre { get; set; }
        public string HotelCalificacion { get; set; }
        public int DestinoId { get; set; }

        [ForeignKey("DestinoId")]
        public Destino Destinos { get; set; }

    }
}
