using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PortalWeb2019.Models
{
    public class Valoracion
    {
       [Key]
       public String Identificador { get; set; }
       
       public String NombreEntrada { get; set; }

       public String TipoEntrada { get; set; }

       public String Voto { get; set; }

       public string UserId { get; set; }

       public virtual ApplicationUser User { get; set; }


    }
}