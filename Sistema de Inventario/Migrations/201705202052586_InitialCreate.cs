namespace Sistema_de_Inventario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegistroUsuarios",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Telefono = c.Long(nullable: false),
                        Clave = c.String(nullable: false),
                        ValidaClave = c.String(),
                        Tipo = c.String(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegistroUsuarios");
        }
    }
}
