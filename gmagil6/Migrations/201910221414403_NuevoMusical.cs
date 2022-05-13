namespace PortalWeb2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevoMusical : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musicals",
                c => new
                    {
                        musicalId = c.Int(nullable: false, identity: true),
                        tituloMusical = c.String(),
                        ciudad = c.String(),
                        localizacion = c.String(),
                        duracionCiudad = c.Int(nullable: false),
                        fechaIni = c.String(),
                        fechaFin = c.String(),
                        hora = c.String(),
                        duracionObra = c.Int(nullable: false),
                        precioMin = c.Int(nullable: false),
                        precioMedio = c.Int(nullable: false),
                        precioMax = c.Int(nullable: false),
                        descripcionPrecios = c.String(),
                    })
                .PrimaryKey(t => t.musicalId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Musicals");
        }
    }
}
