namespace PortalWeb2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class puba : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VisitaTuristicas",
                c => new
                    {
                        visitaId = c.Int(nullable: false, identity: true),
                        ciudad = c.String(),
                        recorrido = c.String(),
                        pago = c.Boolean(nullable: false),
                        agencia = c.String(),
                        tipo = c.String(),
                        fechaIni = c.String(),
                        fechaFin = c.String(),
                        hora = c.String(),
                        duracionEstimada = c.Int(nullable: false),
                        precio = c.Int(nullable: false),
                        excepciones = c.String(),
                    })
                .PrimaryKey(t => t.visitaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VisitaTuristicas");
        }
    }
}
