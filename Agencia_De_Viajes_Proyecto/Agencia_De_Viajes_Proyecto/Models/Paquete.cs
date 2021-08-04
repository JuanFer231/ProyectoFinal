using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Agencia_De_Viajes_Proyecto.Models
{
    public class Paquete
    {

        [Key]
        public int PaqueteId { get; set; }
        public int DestinoId { get; set; }


        [ForeignKey("DestinoId")]

        public Destino Destino { get; set; }
        public DateTime PaqueteFechaSalida { get; set; }
        public DateTime PaqueteFechaLlegada { get; set; }
        public DateTime PaqueteFechaRegreso { get; set; }
        public int PaqueteCantPersonas { get; set; }
        public int PaqueteMonto { get; set; }
    }
}
