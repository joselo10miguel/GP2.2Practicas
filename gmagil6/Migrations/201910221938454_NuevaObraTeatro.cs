namespace PortalWeb2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevaObraTeatro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ObraTeatroes",
                c => new
                    {
                        obrasTeatroID = c.Int(nullable: false, identity: true),
                        titulo = c.String(),
                        ciudad = c.String(),
                        lugar = c.String(),
                        duracion = c.Int(nullable: false),
                        diasSemana = c.String(),
                        rangoFechas = c.String(),
                        hora = c.Int(nullable: false),
                        duracionEstimada = c.Int(nullable: false),
                        precioMinimo = c.Int(nullable: false),
                        precioMedio = c.Int(nullable: false),
                        precioMaximo = c.Int(nullable: false),
                        descPrecios = c.String(),
                    })
                .PrimaryKey(t => t.obrasTeatroID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ObraTeatroes");
        }
    }
}
