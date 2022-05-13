namespace PortalWeb2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductoConUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Conciertoes", "UserId", c => c.String(maxLength: 128));
            AddColumn("dbo.EncuentroDeportivoes", "UserId", c => c.String(maxLength: 128));
            AddColumn("dbo.Experiencias", "UserId", c => c.String(maxLength: 128));
            AddColumn("dbo.Museos", "UserId", c => c.String(maxLength: 128));
            AddColumn("dbo.Musicals", "UserId", c => c.String(maxLength: 128));
            AddColumn("dbo.ObraTeatroes", "UserId", c => c.String(maxLength: 128));
            AddColumn("dbo.Valoracions", "UserId", c => c.String(maxLength: 128));
            AddColumn("dbo.VisitaTuristicas", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Conciertoes", "UserId");
            CreateIndex("dbo.EncuentroDeportivoes", "UserId");
            CreateIndex("dbo.Experiencias", "UserId");
            CreateIndex("dbo.Museos", "UserId");
            CreateIndex("dbo.Musicals", "UserId");
            CreateIndex("dbo.ObraTeatroes", "UserId");
            CreateIndex("dbo.Valoracions", "UserId");
            CreateIndex("dbo.VisitaTuristicas", "UserId");
            AddForeignKey("dbo.Conciertoes", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.EncuentroDeportivoes", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Experiencias", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Museos", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Musicals", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.ObraTeatroes", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Valoracions", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.VisitaTuristicas", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VisitaTuristicas", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Valoracions", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ObraTeatroes", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Musicals", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Museos", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Experiencias", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.EncuentroDeportivoes", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Conciertoes", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.VisitaTuristicas", new[] { "UserId" });
            DropIndex("dbo.Valoracions", new[] { "UserId" });
            DropIndex("dbo.ObraTeatroes", new[] { "UserId" });
            DropIndex("dbo.Musicals", new[] { "UserId" });
            DropIndex("dbo.Museos", new[] { "UserId" });
            DropIndex("dbo.Experiencias", new[] { "UserId" });
            DropIndex("dbo.EncuentroDeportivoes", new[] { "UserId" });
            DropIndex("dbo.Conciertoes", new[] { "UserId" });
            DropColumn("dbo.VisitaTuristicas", "UserId");
            DropColumn("dbo.Valoracions", "UserId");
            DropColumn("dbo.ObraTeatroes", "UserId");
            DropColumn("dbo.Musicals", "UserId");
            DropColumn("dbo.Museos", "UserId");
            DropColumn("dbo.Experiencias", "UserId");
            DropColumn("dbo.EncuentroDeportivoes", "UserId");
            DropColumn("dbo.Conciertoes", "UserId");
        }
    }
}
