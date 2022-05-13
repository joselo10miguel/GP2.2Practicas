using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PortalWeb2019.Models
{
    public class Museo
    {
        [Key]
        public int museoId { get; set; }

        public String nombre { get; set; }

        public int diasCerrado { get; set; }

        public String obras { get; set; }

        public int precio { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}