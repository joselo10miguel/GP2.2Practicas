namespace PortalWeb2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificacionFechas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Conciertoes", "Hora", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EncuentroDeportivoes", "fecha", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EncuentroDeportivoes", "hora", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Experiencias", "Hora", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Musicals", "fechaIni", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Musicals", "fechaFin", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Musicals", "hora", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ObraTeatroes", "hora", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ObraTeatroes", "hora", c => c.Int(nullable: false));
            AlterColumn("dbo.Musicals", "hora", c => c.String());
            AlterColumn("dbo.Musicals", "fechaFin", c => c.String());
            AlterColumn("dbo.Musicals", "fechaIni", c => c.String());
            AlterColumn("dbo.Experiencias", "Hora", c => c.Int(nullable: false));
            AlterColumn("dbo.EncuentroDeportivoes", "hora", c => c.String());
            AlterColumn("dbo.EncuentroDeportivoes", "fecha", c => c.String());
            AlterColumn("dbo.Conciertoes", "Hora", c => c.Int(nullable: false));
        }
    }
}
