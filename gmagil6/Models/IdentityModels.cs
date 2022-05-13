using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PortalWeb2019.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<PortalWeb2019.Models.Concierto> Conciertoes { get; set; }

        public System.Data.Entity.DbSet<PortalWeb2019.Models.Musical> Musicals { get; set; }

        public System.Data.Entity.DbSet<PortalWeb2019.Models.EncuentroDeportivo> EncuentroDeportivoes { get; set; }

        public System.Data.Entity.DbSet<PortalWeb2019.Models.ObraTeatro> ObraTeatroes { get; set; }

        public System.Data.Entity.DbSet<PortalWeb2019.Models.VisitaTuristica> VisitaTuristicas { get; set; }

        public System.Data.Entity.DbSet<PortalWeb2019.Models.Experiencia> Experiencias { get; set; }

        public System.Data.Entity.DbSet<PortalWeb2019.Models.Valoracion> Valoracions { get; set; }

        public System.Data.Entity.DbSet<PortalWeb2019.Models.Museo> Museos { get; set; }
    }
}