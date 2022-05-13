using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PortalWeb2019.Models
{
    public class Concierto
    {
        [Key]

        public int ConciertoId { get; set; }

        public string CantanteGrupo { get; set; }

        public string Lugar { get; set; }

        public string Ciudad { get; set; }

        public string DiasSemana { get; set; }

        public string RangoFechas { get; set; }

        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }

        public int DuracionEstimada { get; set; }

        public int PrecioMin { get; set; }

        public int PrecioMed { get; set; }

        public int PrecioMax { get; set; }

        public string DescPrecios { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}