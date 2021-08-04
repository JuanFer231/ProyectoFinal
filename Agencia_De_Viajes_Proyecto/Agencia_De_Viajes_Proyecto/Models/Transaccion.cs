using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agencia_De_Viajes_Proyecto.Models
{
    public class Transaccion
    {

        [Key]
        public int TransaccionId { get; set; }
        public DateTime TransaccionFecha { get; set; }
        public int TransaccionMonto { get; set; }
    }
}
