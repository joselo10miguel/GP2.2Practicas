namespace PortalWeb2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevaValoracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Valoracions",
                c => new
                    {
                        Identificador = c.String(nullable: false, maxLength: 128),
                        NombreEntrada = c.String(),
                        TipoEntrada = c.String(),
                        Voto = c.String(),
                    })
                .PrimaryKey(t => t.Identificador);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Valoracions");
        }
    }
}
