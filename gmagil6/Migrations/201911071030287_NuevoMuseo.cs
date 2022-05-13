namespace PortalWeb2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevoMuseo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Museos",
                c => new
                    {
                        museoId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        diasCerrado = c.Int(nullable: false),
                        obras = c.String(),
                        precio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.museoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Museos");
        }
    }
}
