using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PortalWeb2019.Models
{
    public class ObraTeatro
    {
        [Key]    
        public int obrasTeatroID { get; set; }
        public String titulo { get; set; }
        public String[] actoresPrincipales { get; set; }
        public String ciudad { get; set; }
        public String lugar { get; set; }
        public int duracion { get; set; }
        public String diasSemana{ get; set; }
        public String rangoFechas { get; set; }

        [DataType(DataType.Time)]
        public DateTime hora { get; set; }
        public int duracionEstimada { get; set; }
        public int precioMinimo { get; set; }
        public int precioMedio { get; set; }
        public int precioMaximo { get; set; }
        public String descPrecios { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

    }
}