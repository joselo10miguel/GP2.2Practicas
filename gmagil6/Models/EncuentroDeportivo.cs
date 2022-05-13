using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PortalWeb2019.Models
{
    public class EncuentroDeportivo
    {
        [Key]
        public int encuentroDeportivoId { get; set; }
        public String deporte { get; set; }
        public String equipoLocal { get; set; }
        public String equipoVisitante { get; set; }
        public String ciudad { get; set; }
        public String lugar { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime fecha { get; set; }

        [DataType(DataType.Time)]
        public DateTime hora { get; set; }

        public int precioMin { get; set; }
        public int precioMedio { get; set; }
        public int precioMax { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}