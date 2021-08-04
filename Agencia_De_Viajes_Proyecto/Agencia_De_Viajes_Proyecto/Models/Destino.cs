using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agencia_De_Viajes_Proyecto.Models
{
    public class Destino
    {

        [Key]
        public int DestinoId { get; set; }
        public string DestinoPaisName { get; set; }
        public string DestinoCuidadName { get; set; }

         public IEnumerable<Hotel> Hoteles { get; set; }

    }
}
