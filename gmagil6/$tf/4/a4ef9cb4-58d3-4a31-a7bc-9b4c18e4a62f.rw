namespace PortalWeb2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class NuevoExperiencia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Experiencias",
                c => new
                {
                    ExperienciaId = c.Int(nullable: false, identity: true),
                    TipoExperiencia = c.String(),
                    Lugar = c.String(),
                    Ciudad_Pueblo = c.String(),
                    AgenciaPatrocinadora = c.String(),
                    DiasSemana = c.String(),
                    RangoFechas = c.String(),
                    Hora = c.Int(nullable: false),
                    DuracionEstimada = c.Int(nullable: false),
                    PrecioMin = c.Int(nullable: false),
                    PrecioMed = c.Int(nullable: false),
                    PrecioMax = c.Int(nullable: false),
                    DescPrecios = c.String(),
                    Excepciones = c.String(),

                })
                .PrimaryKey(t => t.ExperienciaId);
        }

        public override void Down()
        {
            DropTable("dbo.Experiencias");
        }
    }
}
