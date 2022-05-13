namespace PortalWeb2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevoEncuentroDeportivo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EncuentroDeportivoes",
                c => new
                    {
                        encuentroDeportivoId = c.Int(nullable: false, identity: true),
                        deporte = c.String(),
                        equipoLocal = c.String(),
                        equipoVisitante = c.String(),
                        ciudad = c.String(),
                        lugar = c.String(),
                        fecha = c.String(),
                        hora = c.String(),
                        precioMin = c.Int(nullable: false),
                        precioMedio = c.Int(nullable: false),
                        precioMax = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.encuentroDeportivoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EncuentroDeportivoes");
        }
    }
}
