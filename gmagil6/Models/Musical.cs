using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PortalWeb2019.Models
{
    public class Musical
    {
        [Key]
        public int musicalId { get; set; }
        public String tituloMusical { get; set; }
        public String[] actoresPrincipales { get; set; }
        public String ciudad { get; set; }
        public String localizacion { get; set; }
        public int duracionCiudad { get; set; }
        public Boolean[] diasDeFuncion { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime fechaIni { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime fechaFin { get; set; }

        [DataType(DataType.Time)]
        public DateTime hora { get; set; }

        public int duracionObra { get; set; }
        public int precioMin { get; set; }
        public int precioMedio { get; set; }
        public int precioMax { get; set; }
        public String descripcionPrecios { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}