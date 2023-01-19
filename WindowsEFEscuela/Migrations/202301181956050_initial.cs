namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        IdAlumno = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        FechaNacimiento = c.DateTime(),
                        Profesor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAlumno)
                .ForeignKey("dbo.Profesor", t => t.Profesor_Id, cascadeDelete: true)
                .Index(t => t.Profesor_Id);
            
            CreateTable(
                "dbo.Profesor",
                c => new
                    {
                        ProfesorId = c.Int(nullable: false, identity: true),
                        Apellido = c.String(),
                        Nombre = c.String(),
                        Titulo = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ProfesorId);
            
            CreateTable(
                "dbo.Aula",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Codigo = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Programa = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumno", "Profesor_Id", "dbo.Profesor");
            DropIndex("dbo.Alumno", new[] { "Profesor_Id" });
            DropTable("dbo.Materia");
            DropTable("dbo.Aula");
            DropTable("dbo.Profesor");
            DropTable("dbo.Alumno");
        }
    }
}
