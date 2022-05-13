using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PortalWeb2019.Models
{
    public class VisitaTuristica
    {
        [Key]
        public int visitaId { get; set; }
        public String ciudad { get; set; }
        public String recorrido { get; set; }
        public Boolean pago { get; set; }
        public String agencia { get; set; }
        public String tipo { get; set; }
        public String fechaIni { get; set; }
        public String fechaFin { get; set; }
        public String hora { get; set; }
        public int duracionEstimada { get; set; }
        public int precio { get; set; }
        public Boolean[] diasDeFuncion { get; set; }
        public String excepciones { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}